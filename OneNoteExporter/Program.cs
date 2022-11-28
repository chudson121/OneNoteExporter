using System;
using System.Diagnostics.Metrics;
using System.IO;

using Microsoft.Extensions.Configuration;
using Microsoft.Office.Interop.OneNote;
using Honeycomb.OpenTelemetry;
using OneNoteExporter.AppConfig;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;
using Serilog;

namespace OneNoteExporter
{
    public class Program
    {
        private static IConfigurationRoot _configuration;
        private static readonly Application OnenoteApp = new();
        private static Converter _converter;

        private static HoneycombOptions honeycombOptions;
        private static TracerProvider TraceProvider;
        private static MeterProvider MeterProvider;
        private static Tracer ApplicationTracer;
        private static Meter ApplicationMeter;

        public static void Main()
        {
            InitializeApplicationConfiguration();

            Log.Logger = ConfigureLog.Configure();
            Log.Information($"Configuration Loaded for {ApplicationUtility.GetApplicationName()}");

            // configure OpenTelemetry SDK to send metric data to Honeycomb
            InitializeTelementry(honeycombOptions);

            var spanConvert = ApplicationTracer.StartSpan("Prorgram Started", SpanKind.Client, startTime: DateTimeOffset.UtcNow);
            try
            {
                _converter = new Converter(OnenoteApp, ApplicationTracer, ApplicationMeter)
                {
                    RemoveIntermediateConvertedFiles = Convert.ToBoolean(_configuration["removeIntermediateWordFiles"]),
                    ExportPath = _configuration["exportedFilePath"],
                    FilteredNoteBookName = _configuration["NoteBookName"],
                    FilteredSectionName = _configuration["SectionName"],
                    PandocPath = _configuration["pandocpath"],
                    ParallelThreadCount = Convert.ToInt32(_configuration["appParallelismCount"]),
                    BypassConvertion = Convert.ToBoolean(_configuration["debugBypassHeavyWorkload"])
                };


                _converter.ConvertPages();

            }
            catch (Exception ex)
            {
                spanConvert.SetStatus(Status.Error.WithDescription(ex.ToString()));
                throw;
            }
            finally
            {
                spanConvert.SetStatus(Status.Ok.WithDescription("Completed All Conversions"));
                spanConvert.End(endTimestamp: DateTimeOffset.UtcNow);
            }

            //If using DI
            // Register Tracer so it can be injected into other components (eg Controllers)
            //builder.Services.AddSingleton(TracerProvider.Default.GetTracer(honeycombOptions.ServiceName));

            // Example create span to describe some application logic
            //using var span = _ApplicationTracer.StartActiveSpan("doSomething");
            //span.SetAttribute("app.manual-span.message", "Adding custom spans is also super easy!");
            //span.SetAttribute("user_id", 123);
            //span.End(new DateTimeOffset()); 

            Log.CloseAndFlush();

            MeterProvider.Dispose();
            TraceProvider.Dispose();
            ApplicationMeter.Dispose();
            



        }

        private static void InitializeTelementry(HoneycombOptions honeycombOptions)
        {
            //configure OpenTel send traces to Honeycomb
            var traceProviderBuilder = Sdk.CreateTracerProviderBuilder()
            .AddHoneycomb(honeycombOptions)
            .AddConsoleExporter(); // for debugging
            //.AddAutoInstrumentations();  //get redis cache error - probably only used in asp.net core apps
            //System.InvalidOperationException: 'StackExchange.Redis IConnectionMultiplexer could not be resolved through application IServiceProvider'

            TraceProvider = traceProviderBuilder.Build();
            
            // get an instance of a tracer that can be used to create spans
            ApplicationTracer = TraceProvider.GetTracer(honeycombOptions.ServiceName);
            
            //create the meter (why doesnt this follow the same pattern as tracerprovider?)
            ApplicationMeter = new Meter(honeycombOptions.ServiceName, honeycombOptions.ServiceVersion);

            //add meter to provider
            var meterProviderBuilder = Sdk.CreateMeterProviderBuilder()
              .AddHoneycomb(honeycombOptions)
              .AddMeter(honeycombOptions.ServiceName)
              .AddConsoleExporter();

            MeterProvider = meterProviderBuilder.Build();
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

            honeycombOptions = new HoneycombOptions
            {
                ServiceName = ApplicationUtility.GetApplicationName(),
                ServiceVersion = ApplicationUtility.GetApplicationVersion().ToString(),
                ApiKey = _configuration["Honeycomb:ApiKey"],

            };
        }

        //If using DI
        //public static ServiceProvider ServicesConfigure()
        //{
        //    return new ServiceCollection()
        //        .AddLogging(l => l.AddConsole())
        //        .Configure<LoggerFilterOptions>(c => c.MinLevel = LogLevel.Trace)
        //        //.AddSingleton<IPrintSettingsProvider, PrintSettingsProvider>()
        //        //.AddSingleton<IConsolePrinter, ConsolePrinter>()
        //        .AddSingleton<Converter>()
        //        .BuildServiceProvider();
        //}


    }


}
