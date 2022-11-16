using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Office.Interop.OneNote;
using OneNoteExporter.AppConfig;
using Serilog;
using System.Diagnostics;
using OpenTelemetry.Trace;


namespace OneNoteExporter
{
    public class Program
    {

        private static IConfigurationRoot _configuration;

        //private static ActivitySource applicaitonActivitySource;

        private static readonly Application OnenoteApp = new Application();

        private static Converter _converter;

        public static void Main()
        {

            //var appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            //var appVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            InitializeApplicationConfiguration();

            Log.Logger = ConfigureLog.Configure();
            Log.Information($"File Configuration Loaded for {ApplicationUtility.GetApplicationName()} ");

            _converter = new(OnenoteApp, _configuration);
            _converter.Convert(Convert.ToBoolean(_configuration["removeIntermediateWordFiles"]));

            Log.CloseAndFlush();

        }




        private static void InitializeApplicationConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile("loggerconfig.json", false, true) //mantained separate config file
                .AddEnvironmentVariables()
                .AddUserSecrets<Program>();

            _configuration = builder.Build();
        }



    }


}
