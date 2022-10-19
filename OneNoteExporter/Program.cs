using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Office.Interop.OneNote;
using OneNoteExporter.AppConfig;
using Serilog;
using PageInfo = OneNoteExporter.OneNoteModels.PageInfo;

namespace OneNoteExporter
{
    public class Program
    {
        private static readonly Application OnenoteApp = new Application();

        private static IConfigurationRoot _configuration;
        private static List<string> FilesToBeDeleted = new List<string>();


        public static void Main()
        {
            InitializeConfiguration();

            InitializeLogger();

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 10
            };

            var ExportPath = _configuration["exportedFilePath"];
            var FilteredNoteBookName = _configuration["NoteBookName"];
            var FilteredSectionName = _configuration["SectionName"];
            var ConfigPandocPath = _configuration["pandocpath"];

            OneNoteModels.NotebookInfo[] FilteredNotebooks;
            OneNoteModels.SectionBase[] FilteredSections;

            FilteredNotebooks = GetFilteredNotebookInfos(OnenoteApp.GetNotebooks(), FilteredNoteBookName);

            foreach (var notebook in FilteredNotebooks)
            {
                Log.Information($"NoteBook: {notebook.Title}");

                FilteredSections = GetFilteredSections(OnenoteApp.GetSections(notebook.Id), FilteredSectionName);

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
                        OrchestratePageExtraction(section.Title.GetSafeFilename(), i, ExportPath, ConfigPandocPath);
                    });

                }

            }

            //TODO: make into config item if we want to retain
            RemoveExtractedWordFiles(FilesToBeDeleted);

        }

        private static void RemoveExtractedWordFiles(List<string> filesToBeDeleted)
        {
            foreach (var file in filesToBeDeleted)
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

        private static OneNoteModels.NotebookInfo[] GetFilteredNotebookInfos(OneNoteModels.NotebookInfo[] collecction, string filterContentName)
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

        private static OneNoteModels.SectionBase[] GetFilteredSections(OneNoteModels.SectionBase[] collection, string filterContentName)
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

        private static void ConvertDocxToMarkdown(string docxfilePath, string pandocPath)
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

        private static void CallConverterExecutable(ProcessStartInfo psi)
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

        private static void ExtractPageToDocx(string filePath, PageInfo pageInfo)
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

        private static void CreateDirectory(string filePath)
        {
            var directoryInfo = new FileInfo(filePath).Directory;
            directoryInfo?.Create();
        }

        private static void InitializeLogger()
        {
            Log.Logger = new ConfigureLog().Configuration.CreateLogger();
            Log.Information($"File Configuration Loaded for {ApplicationUtility.GetApplicationName()} ");
        }


        private static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            _configuration = builder.Build();
        }

        private static void OrchestratePageExtraction(string sectionFileName, PageInfo pageInfo, string exportPath, string pandocPath)
        {
            var filePath = $"{exportPath}\\{sectionFileName}\\{pageInfo.Title.GetSafeFilename()}.docx";
            CreateDirectory(filePath);
            ExtractPageToDocx(filePath, pageInfo);
            ConvertDocxToMarkdown(filePath, pandocPath);
            FilesToBeDeleted.Add(filePath); //the convert cannot be guarenteed to complete due to interop call

        }

    }
}
