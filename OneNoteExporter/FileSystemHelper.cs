using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace OneNoteExporter
{
    public static class FileSystemHelper
    {
        public static void CreateDirectory(string filePath)
        {
            var directoryInfo = new FileInfo(filePath).Directory;
            directoryInfo?.Create();
        }

        public static void RemoveFiles(List<string> filelist)
        {
            foreach (var file in filelist)
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
    }
}
