using System;
using System.Reflection;

namespace OneNoteExporter.AppConfig
{
    public static class ApplicationUtility
    {
        /// <summary>Returns the name from the EntryAssembly </summary>
        /// <returns>string</returns>
        public static string GetApplicationName()
        {
            return Assembly.GetExecutingAssembly()?.GetName().Name?.ToUpper().Replace(".STARTUP", "") ?? "Unknown";
        }

        /// <summary>Assembly version </summary>
        /// <returns>Version</returns>
        public static Version GetApplicationVersion()
        {
            return Assembly.GetEntryAssembly().GetName().Version;
        }
    }
}