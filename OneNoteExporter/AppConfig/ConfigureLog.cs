using System;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace OneNoteExporter.AppConfig
{
    public class ConfigureLog
    {
        private const string Logformattedoutput = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u} | {MachineName} | {Application} | {ApplicationName} | {Environment} | MESSAGE={Message} | {ThreadId} | {SourceContext} | EXCEPTION={Exception} | {NewLine}";
        private const string ErrorLogPath = @"Logs\\Error-{Date}.log";
        private const string InfoLogPath = @"Logs\\Info-{Date}.log";
        private const int RetainedLogFiles = 10;
        private const long LogFileMaxSizeInBytes = 26214400;
        private const string AspnetcoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        public LoggerConfiguration Configuration { get; }

        private readonly LoggingLevelSwitch loggingLevelSwitch = new LoggingLevelSwitch();

        public ConfigureLog()
        {
            
            Configuration = new LoggerConfiguration();
            
            AddMinimumLevels(loggingLevelSwitch, Configuration);

            AddLoggerEnrichments(Configuration);

            AddLoggerOutputs(loggingLevelSwitch, Configuration);

            
        }

        private void AddMinimumLevels(LoggingLevelSwitch levelSwitch, LoggerConfiguration config)
        {
            config.MinimumLevel.ControlledBy(levelSwitch)
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning);
        }

        private void AddLoggerOutputs(LoggingLevelSwitch loggingLevelSwitch, LoggerConfiguration config)
        {
            config
                .WriteTo.RollingFile(InfoLogPath, outputTemplate: Logformattedoutput, retainedFileCountLimit: RetainedLogFiles, fileSizeLimitBytes: LogFileMaxSizeInBytes, levelSwitch: loggingLevelSwitch) //Serilog.Sinks.RollingFile
                .WriteTo.Logger(l => l.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Error).WriteTo.RollingFile(ErrorLogPath, outputTemplate: Logformattedoutput, retainedFileCountLimit: RetainedLogFiles, fileSizeLimitBytes: LogFileMaxSizeInBytes)) //Serilog.Sinks.RollingFile
                .WriteTo.Console();
                
        }

        private void AddLoggerEnrichments(LoggerConfiguration config)
        {
            var appName = ApplicationUtility.GetApplicationName();
            var version = ApplicationUtility.GetApplicationVersion().ToString();
            var deploymentEnvironment = Environment.GetEnvironmentVariable(AspnetcoreEnvironment);

            config.Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithThreadId()
                .Enrich.WithProperty(@"ApplicationName", appName)
                .Enrich.WithProperty(@"Environment", deploymentEnvironment)
                .Enrich.WithProperty(@"Version", version);
        }

    }
}
