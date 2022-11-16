using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.OneNote;
using PageInfo = OneNoteExporter.OneNoteModels.PageInfo;
using Serilog;
using Microsoft.Extensions.Configuration;

namespace OneNoteExporter
{
    public class Converter
    {
        private List<string> FilesToBeDeleted = new List<string>();
        private IConfigurationRoot configuration;
        private readonly Application OnenoteApp = new Application();

        public string ExportPath { get; private set; }
        public string PandocPath { get; private set; }
        public int ParallelThreadCount { get; private set; }
        public string FilteredNoteBookName { get; private set; }
        public string FilteredSectionName { get; private set; }
        


        public Converter(Application app, IConfigurationRoot config)
        {
            configuration = config;
            OnenoteApp = app;

            ExportPath = configuration["exportedFilePath"];
            FilteredNoteBookName = configuration["NoteBookName"];
            FilteredSectionName = configuration["SectionName"];
            PandocPath = configuration["pandocpath"];
            ParallelThreadCount = System.Convert.ToInt32(configuration["appParallelismCount"]);
        }

        public void Convert(bool removeIntermediateFiles)
        {
            OneNoteModels.NotebookInfo[] FilteredNotebooks;


            FilteredNotebooks = GetFilteredNotebookInfos(OnenoteApp.GetNotebooks(), FilteredNoteBookName);
            ProcessNoteBooks(FilteredNotebooks);

            if (removeIntermediateFiles)
                RemoveExtractedWordFiles();

        }

        private void ProcessNoteBooks(OneNoteModels.NotebookInfo[] FilteredNotebooks)
        {

            OneNoteModels.SectionBase[] FilteredSections;

            foreach (var notebook in FilteredNotebooks)
            {
                Log.Information($"NoteBook: {notebook.Title}");

                FilteredSections = GetFilteredSections(OnenoteApp.GetSections(notebook.Id), FilteredSectionName);

                ProcessSection(FilteredSections);

            }


        }

        private void ProcessSection(OneNoteModels.SectionBase[] FilteredSections)
        {
            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = ParallelThreadCount
            };

            foreach (var section in FilteredSections)
            {
                Log.Information($"Section {section.Title}");

                var pages = OnenoteApp.GetPages(section.Id);

                //testing single thread proc
                //foreach (var pageInfo in pages)
                //{
                //    OrchestratePageExtraction(section.Title.GetSafeFilename(), pageInfo, ExportPath, ConfigPandocPath);
                //}

                // This is working 
                Parallel.ForEach(pages, options, i =>
                {
                    OrchestratePageExtraction(section.Title.GetSafeFilename(), i);
                });

            }
        }

        private void OrchestratePageExtraction(string sectionFileName, PageInfo pageInfo)
        {
            var filePath = $"{ExportPath}\\{sectionFileName}\\{pageInfo.Title.GetSafeFilename()}.docx";
            CreateDirectory(filePath);
            ExtractPageToDocx(filePath, pageInfo);
            ConvertDocxToMarkdown(filePath, PandocPath);
            FilesToBeDeleted.Add(filePath); //the convert cannot be guarenteed to complete due to interop call

        }



        public void RemoveExtractedWordFiles()
        {
            foreach (var file in FilesToBeDeleted)
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception ex)
                {
                    Log.Error($"Problem deleteing file {file} exception: {ex}");
                }

            }
        }

        public OneNoteModels.NotebookInfo[] GetFilteredNotebookInfos(OneNoteModels.NotebookInfo[] collecction, string filterContentName)
        {
            if (string.IsNullOrEmpty(filterContentName)) //process all
            {
                return collecction;
            }

            var returnedList = new List<OneNoteModels.NotebookInfo>();

            foreach (var item in collecction)
            {
                if (string.Equals(item.Title, filterContentName, StringComparison.CurrentCultureIgnoreCase))
                {
                    returnedList.Add(item);
                    break;
                }
            }

            return returnedList.ToArray();
        }

        public OneNoteModels.SectionBase[] GetFilteredSections(OneNoteModels.SectionBase[] collection, string filterContentName)
        {
            if (string.IsNullOrEmpty(filterContentName)) //process all sections
            {
                return collection;
            }

            var returnedSections = new List<OneNoteModels.SectionBase>();

            foreach (var item in collection)
            {
                if (string.Equals(item.Title, filterContentName, StringComparison.CurrentCultureIgnoreCase)) //filter to specific section
                {
                    returnedSections.Add(item);
                    break;
                }

            }
            return returnedSections.ToArray();

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

            CallConverterExecutable(psi);

        }

        private void CallConverterExecutable(ProcessStartInfo psi)
        {
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

        private void ExtractPageToDocx(string filePath, PageInfo pageInfo)
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

        private void CreateDirectory(string filePath)
        {
            var directoryInfo = new FileInfo(filePath).Directory;
            directoryInfo?.Create();
        }


    }
}
