using System;
using Serilog;
using Serilog.Core;

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
                .WriteTo.Console()
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
