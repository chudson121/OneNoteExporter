using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Office.Interop.OneNote;
using OpenTelemetry.Trace;
using Serilog;
using static System.Collections.Specialized.BitVector32;
using PageInfo = OneNoteExporter.OneNoteModels.PageInfo;

namespace OneNoteExporter
{
    public class Converter
    {
        private readonly List<string> FilesToBeDeleted = new();
        private readonly Application OnenoteApp;

        //Configuration
        //private IConfigurationRoot configuration;
        public string ExportPath { get; set; }
        public string PandocPath { get; set; }
        public int ParallelThreadCount { get; set; }
        public string FilteredNoteBookName { get; set; }
        public string FilteredSectionName { get; set; }

        public bool RemoveIntermediateConvertedFiles { get; set; } = true;

        public bool BypassConvertion { get; set; } = false;

        public long FilesProcessedCount { get; private set; }

        //Telemetry
        private readonly Tracer Tracer;
        private readonly Counter<int> NoteBookCounter;
        private readonly Counter<int> SectionCounter;
        private readonly Counter<int> PagesCounter;


        public Converter(Application app, Tracer tracer, Meter meter)
        {
            
            OnenoteApp = app;
            Tracer = tracer;

            NoteBookCounter = meter.CreateCounter<int>("Notebooks");
            SectionCounter = meter.CreateCounter<int>("Sections");
            PagesCounter = meter.CreateCounter<int>("Pages");
                      
        }

        //this is doing lots of stuff, is it all its own concern
        public long ConvertPages()
        {
                          
            using var span = Tracer.StartActiveSpan("FilteredNotebooks");
            span.SetAttribute("app.Converter.message", "Notebook processing started!");
            
            //Defense gates
            if (string.IsNullOrEmpty(ExportPath))
                throw new ArgumentNullException(nameof(ExportPath)); 

            if(string.IsNullOrEmpty(FilteredNoteBookName))
                throw new ArgumentNullException(nameof(FilteredNoteBookName));

            if (string.IsNullOrEmpty(PandocPath))
                throw new ArgumentNullException(nameof(PandocPath));


            var FilteredNotebooks = GetNotebookInfos(OnenoteApp.GetNotebooks(), FilteredNoteBookName);
            var FilteredSections = GetFilteredSections(FilteredNotebooks, FilteredSectionName);
            var PagesToProcess = GetPageInfoForSections(FilteredSections);

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = ParallelThreadCount
            };

            Parallel.ForEach(PagesToProcess, options, OrchestratePageExtraction);

            if (RemoveIntermediateConvertedFiles)
                FileSystemHelper.RemoveFiles(FilesToBeDeleted);


            span.SetStatus(Status.Ok.WithDescription("Completed page Conversions"));
            span.End(endTimestamp: DateTimeOffset.UtcNow);
            


            return FilesProcessedCount;

                        
        }

        //TODO: this should be in the OneNoteClass
        public List<OneNoteModels.NotebookInfo> GetNotebookInfos(OneNoteModels.NotebookInfo[] notebookCollecction, string filterContentName)
        {
            var returnedList = new List<OneNoteModels.NotebookInfo>();

            if (string.IsNullOrEmpty(filterContentName)) //process all
            {
                return returnedList;
            }

            foreach (var nb in from nb in notebookCollecction
                               where string.Equals(nb.Title, filterContentName, StringComparison.CurrentCultureIgnoreCase)
                               select nb)
            {
                returnedList.Add(nb);
                break;
            }

            NoteBookCounter.Add(returnedList.Count);
            return returnedList;
        }

        public List<OneNoteModels.SectionBase> GetFilteredSections(List<OneNoteModels.NotebookInfo> notebookCollecction, string sectionName)
        {
            var returnedSections = new List<OneNoteModels.SectionBase>();
                        
            foreach (var nb in notebookCollecction)
            {
                
                //empty filter add all sections from notebook
                if (string.IsNullOrEmpty(sectionName)) //process all sections
                {
                    return returnedSections = new List<OneNoteModels.SectionBase>(nb.Sections);
                }

                //Filter
                var sectionBaseMatchingFilter = nb.Sections.FirstOrDefault(
                        name => name.Title.ToLowerInvariant() == sectionName.ToLowerInvariant());

                returnedSections.Add(sectionBaseMatchingFilter);    

            }

            return returnedSections;

        }

        public List<PageInfo> GetPageInfoForSections(List<OneNoteModels.SectionBase> FilteredSections)
        {
          
            var pageInfoList = new List<PageInfo>();

            using var span = Tracer.StartActiveSpan("Getting pages");
            

            foreach (var section in FilteredSections)
            {
                span.SetAttribute("app.PageInfo.message", $"Getting pages for Section: {section.Title}");
                //Log.Information($"Getting pages for Section: {section.Title}");
                SectionCounter.Add(1);
                pageInfoList.AddRange(OnenoteApp.GetPages(section));

                FilesProcessedCount +=  pageInfoList.Count;

            }

            span.End(new DateTimeOffset());

            return pageInfoList;


        }

        public void OrchestratePageExtraction(PageInfo pageInfo)
        {
            PagesCounter.Add(1);

            Log.Information($"Extracting Section {pageInfo.SectionName} - Page: {pageInfo.Title}");

            if (BypassConvertion)
            {
                return;
            }

            var filePath = $"{ExportPath}\\{pageInfo.SectionName.GetSafeFilename()}\\{pageInfo.Title.GetSafeFilename()}.docx";
            FileSystemHelper.CreateDirectory(filePath);
            ConvertOneNotePageToWordDoc(filePath, pageInfo);
            ConvertDocxToMarkdown(filePath, PandocPath);
            FilesToBeDeleted.Add(filePath); //the convert cannot be guarenteed to complete due to interop call
        }


        private void ConvertDocxToMarkdown(string docxfilePath, string pandocPath)
        {
            //SET CMD=%localappdata%\Pandoc\pandoc.exe %1 -w gfm -o "%BASEDIR%\%~n1\%~n1.md" %1 --extract-media=""
            var fileInfo = new FileInfo(docxfilePath);
            var processName = string.Format("{0}pandoc.exe", pandocPath);
            var arguments = $"\"{docxfilePath}\"  " +
                            $"-w gfm " +
                            $"-o \"{docxfilePath.Replace("docx", "md")}\" " +
                            $"--extract-media=\"{fileInfo.Name.Replace(fileInfo.Extension, "")}\"";

            Log.Information($"arguments {arguments}");

            var psi = new ProcessStartInfo
            {
                FileName = processName,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                WorkingDirectory = fileInfo.Directory.FullName
            };

            try
            {
                var process = new Process { StartInfo = psi };
                process.Start();
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Is Pandoc Installed?", ex);
            }

        }
               
        private void ConvertOneNotePageToWordDoc(string filePath, PageInfo pageInfo)
        {
            if (pageInfo == null) throw new ArgumentNullException(nameof(pageInfo));

            Log.Information($"Page: {pageInfo.Title}");

            try
            {
                //File.Delete(filePath);
                if (!File.Exists(filePath))
                    OnenoteApp.Publish(pageInfo.Id, filePath, PublishFormat.pfWord);
            }
            catch (Exception e)
            {
                Log.Error(filePath);
                Log.Error(e.Message);
                //continue on processing files
            }
        }

        //FileSystemStuff
      
    }
}
