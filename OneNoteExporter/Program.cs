using System;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
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
        private static string ExportPath { get; set; }
        private static string FilteredNoteBookName { get; set; }

        public static void Main()
        {
            InitializeConfiguration();

            InitializeLogger();


            ExportPath = _configuration["exportedFilePath"]; //"D:\\output";
            FilteredNoteBookName = _configuration["NoteBookName"]; //"DevOps Team Notebook";
            //var filteredSectionName = _configuration["SectionName"]; //"SOP";

            var notebooks = OnenoteApp.GetNotebooks();

            foreach (var notebook in notebooks)
            {
                if (string.Equals(notebook.Title, FilteredNoteBookName, StringComparison.CurrentCultureIgnoreCase))
                {
                    Log.Information($"NoteBook: {notebook.Title}");

                    var sections = OnenoteApp.GetSections(notebook.Id);

                    foreach (var section in sections)
                    {
                        //if(string.IsNullOrEmpty(filteredSectionName)) //process each section
                        //if (!string.Equals(section.Title, filteredSectionName, StringComparison.CurrentCultureIgnoreCase)) continue;

                        Log.Information($"Section {section.Title}");

                        var pages = OnenoteApp.GetPages(section.Id);

                        foreach (var pageInfo in pages)
                        {
                            var filePath = $"{ExportPath}\\{section.Title.GetSafeFilename()}\\{pageInfo.Title.GetSafeFilename()}.docx";
                            CreateDirectory(filePath);
                            ExtractPageToDocx(filePath, pageInfo);
                            ConvertDocxToMarkdown(filePath);
                        }
                    }
                }
            }
        }

        private static void ConvertDocxToMarkdown(string docxfilePath)
        {
            //SET CMD=%localappdata%\Pandoc\pandoc.exe %1 -w gfm -o "%BASEDIR%\%~n1\%~n1.md" %1 --extract-media=""
            var fileInfo = new FileInfo(docxfilePath);

            var processName = "pandoc.exe";
            var arguments = $"\"{docxfilePath}\"  " +
                            $"-w gfm " +
                            $"-o \"{docxfilePath.Replace("docx", "md")}\" " +
                            $"--extract-media=\"{fileInfo.Name.Replace(fileInfo.Extension, "")}\"";
           
            
            var psi = new ProcessStartInfo
            {
                FileName = processName,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                WorkingDirectory = fileInfo.Directory.FullName
            };

            var process = new Process { StartInfo = psi };
            process.Start();
        }

        private static void ExtractPageToDocx(string filePath, PageInfo pageInfo )
        {
            if (pageInfo == null) throw new ArgumentNullException(nameof(pageInfo));
            
            Log.Information($"Page: {pageInfo.Title}");
            
            try
            {
                //File.Delete(filePath);
                if(!File.Exists(filePath))
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
    }
}