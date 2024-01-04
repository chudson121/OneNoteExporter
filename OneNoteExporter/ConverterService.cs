using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Office.Interop.OneNote;
using OneNoteExporter.AppConfig;
using OpenTelemetry.Trace;
using Serilog;

using PageInfo = OneNoteExporter.OneNoteModels.PageInfo;

namespace OneNoteExporter
{
    public class ConverterService
    {
        public readonly List<string> FilesToBeDeleted = new();
        private readonly Application OnenoteApp;

        //Configuration
        private readonly AppSettings _appSettings;
        
        public string ExportPath { get; set; }

        public string PandocPath { get; set; }

        public int ParallelThreadCount { get; set; } = 10;

        public string FilteredNoteBookName { get; set; }

        public string FilteredSectionName { get; set; }

        public bool RemoveIntermediateConvertedFiles { get; set; } = true;

        public bool BypassConvertion { get; set; } = false; //for testing

        public long FilesProcessedCount { get; private set; }

        //Telemetry
        private readonly Tracer Tracer;
        private readonly Counter<int> NoteBookCounter;
        private readonly Counter<int> SectionCounter;
        private readonly Counter<int> PagesCounter;

        private List<OneNoteModels.NotebookInfo> FilteredNotebooks { get; }
        private List<OneNoteModels.SectionBase> FilteredSections { get; }
        private List<PageInfo> PagesToProcess { get; set; }


        public ConverterService(AppSettings _settings, Application app, Tracer tracer, Meter meter)
        {
            _appSettings = _settings;
            
            //ExportPath = _appSettings.ExportedFilePath;
            FilteredNoteBookName = _appSettings.NoteBookName;
            FilteredSectionName = _appSettings.SectionName;
            PandocPath = _appSettings.PanDocPath;
            ParallelThreadCount = _appSettings.AppParallelismCount;
            BypassConvertion = _appSettings.Debug;

            Tracer = tracer;
            NoteBookCounter = meter.CreateCounter<int>("Notebooks");
            SectionCounter = meter.CreateCounter<int>("Sections");
            PagesCounter = meter.CreateCounter<int>("Pages");

            OnenoteApp = app;

            FilteredNotebooks = OneNoteExtensions.GetNotebookInfos(OnenoteApp.GetNotebooks(), FilteredNoteBookName);
            NoteBookCounter.Add(FilteredNotebooks.Count);

            FilteredSections = OneNoteExtensions.GetFilteredSections(FilteredNotebooks, FilteredSectionName);
            SectionCounter.Add(FilteredSections.Count);

            


        }

        public List<PageInfo> GetPagesToProcess()
        {

            PagesToProcess = OneNoteExtensions.GetPageInfoForSections(OnenoteApp, FilteredSections);
            FilesProcessedCount += PagesToProcess.Count;

            return PagesToProcess;

        }


        public long ConvertPages(List<PageInfo> Pages)
        {
            using var span = Tracer.StartActiveSpan("FilteredNotebooks");
            span.SetAttribute("app.Converter.message", "Notebook processing started!");

            //Defense gates
            if (string.IsNullOrEmpty(ExportPath))
                throw new ArgumentNullException(nameof(ExportPath));

            if (string.IsNullOrEmpty(FilteredNoteBookName))
                throw new ArgumentNullException(nameof(FilteredNoteBookName));

            if (string.IsNullOrEmpty(PandocPath))
                throw new ArgumentNullException(nameof(PandocPath));

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = ParallelThreadCount
            };

            Parallel.ForEach(Pages, options, OrchestratePageExtraction);

            span.SetStatus(Status.Ok.WithDescription("Completed page Conversions"));
            span.End(endTimestamp: DateTimeOffset.UtcNow);


            return FilesProcessedCount;


        }
               

        private void OrchestratePageExtraction(PageInfo pageInfo)
        {
            PagesCounter.Add(1);

            Log.Information($"Extracting Section {pageInfo.SectionName} - Page: {pageInfo.Title}");

            if (BypassConvertion) // test mode
            {
                return;
            }

            var filePath = $"{ExportPath}\\{pageInfo.SectionName.GetSafeFilename()}\\{pageInfo.Title.GetSafeFilename()}.docx";
            FileSystemHelper.CreateDirectory(filePath);
            ConvertOneNotePageToWordDoc(filePath, pageInfo);
            ConvertDocxToMarkdown(filePath, PandocPath);
            FilesToBeDeleted.Add(filePath); //the convert cannot be guarantied to complete due to interop call
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

        private void PageMdPostConvertion(Page page, ref string mdFileContent)
        {
            if (_appSettings.DeduplicateLinebreaks)
            {
                mdFileContent = StringUtility.DeduplicateLinebreaks(mdFileContent);
            }

            mdFileContent = StringUtility.RemoveHtmlCommentBlocks(mdFileContent);

            mdFileContent = StringUtility.RemoveUTF8NonBreakingSpace(mdFileContent);

            if (_appSettings.PostProcessingRemoveQuotationBlocks)
            {
                mdFileContent = StringUtility.RemoveQuotationBlocks(mdFileContent);
            }

            if (_appSettings.MaxTwoLineBreaksInARow)
            {
                mdFileContent = StringUtility.MaxTwoLineBreaksInARow(mdFileContent);
            }

            if (_appSettings.PostProcessingRemoveOneNoteHeader)
            {
                mdFileContent = StringUtility.RemoveOneNoteHeader(mdFileContent);
            }

            mdFileContent = StringUtility.InsertMdHighlight(mdFileContent);
        }


    }
}
