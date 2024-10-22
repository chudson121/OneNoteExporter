using System;
using System.IO;
using System.Text;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.RollingFile.Extension;
using Serilog.Sinks.SystemConsole.Themes;

namespace OneNoteExporter.AppConfig
{
    public static class ConfigureLog
    {
        private const string AspnetcoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        public static Logger Configure()
        {
            var appName = ApplicationUtility.GetApplicationName();
            var version = ApplicationUtility.GetApplicationVersion().ToString();
            var deploymentEnvironment = Environment.GetEnvironmentVariable(AspnetcoreEnvironment);


            var configuration = new LoggerConfiguration().ReadFrom.AppSettings()
                .WriteTo.Console(
                    LogEventLevel.Verbose,
                    theme: AnsiConsoleTheme.Literate,
                    outputTemplate: "{Timestamp:HH:mm:ss} [{Level:u3}] {Message} {NewLine}{Exception}"
                    )

                .WriteTo.File(
                    Path.Combine($"log/{System.DateTime.Today}/", ".txt"), 
                    rollingInterval: RollingInterval.Day, 
                    flushToDiskInterval: System.TimeSpan.FromSeconds(1),
                    retainedFileCountLimit: 30,
                    encoding: Encoding.UTF8
                )

                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithThreadId()
                .Enrich.WithProperty(@"ApplicationName", appName)
                .Enrich.WithProperty(@"Environment", deploymentEnvironment)
                .Enrich.WithProperty(@"Version", version);

            return configuration.CreateLogger();

        }

    }
}
