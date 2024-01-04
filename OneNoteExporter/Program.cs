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

using io.harness.cfsdk.client.dto;
using io.harness.cfsdk.client.api;
using io.harness.cfsdk.client.connector;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OneNoteExporter
{
    public class Program
    {
        private static IConfigurationRoot _configuration;
        private static readonly Application OnenoteApp = new();
        private static ConverterService _converter;

        private static readonly ActivitySource ActivitySource = new ActivitySource(ApplicationUtility.GetApplicationName());
        private static TracerProvider TraceProvider;
        private static MeterProvider MeterProvider;
        private static Tracer ApplicationTracer;
        private static Meter ApplicationMeter;
        private static HoneycombOptions honeycombOptions;
        private static AppSettings appSettings;
        private static bool FlagSkipProcessing = false;

        public static void Main(AppSettings appSettings)
        {
            InitializeApplicationConfiguration();

            Log.Logger = ConfigureLog.Configure();
            Log.Information($"Configuration Loaded for {ApplicationUtility.GetApplicationName()}");

            // configure OpenTelemetry SDK to send metric data to Honeycomb
            InitializeTelementry(honeycombOptions);

            using (var activity = ActivitySource.StartActivity($"{ApplicationUtility.GetApplicationName()}.Start"))
            {
                activity?.SetTag("foo", "value"); //test tag
                var spanConvert = ApplicationTracer.StartSpan("Prorgram Started", SpanKind.Client, startTime: DateTimeOffset.UtcNow);
                try
                {
                    _converter = new ConverterService(appSettings, OnenoteApp, ApplicationTracer, ApplicationMeter);
                    var pages = _converter.GetPagesToProcess();
                    _converter.ConvertPages(pages);


                    if (Convert.ToBoolean(_configuration["DeleteOneNoteDocxFiles"]))
                        FileSystemHelper.RemoveFiles(_converter.FilesToBeDeleted);

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
            .AddSource(ApplicationUtility.GetApplicationName())
            .AddHoneycomb(honeycombOptions)//Vendor specific
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
                .AddUserSecrets<Program>()
                ;

            _configuration = builder.Build();

            honeycombOptions = new HoneycombOptions
            {
                ServiceName = ApplicationUtility.GetApplicationName(),
                ServiceVersion = ApplicationUtility.GetApplicationVersion().ToString(),
                ApiKey = _configuration["Honeycomb:ApiKey"],

            };

            appSettings = AppSettings.LoadAppSettings();
            //ConfigureFeatureFlag().Wait(); TODO: Harness call has issue if now api key is in filestore

        }

        private static async Task ConfigureFeatureFlag()
        {
            FileMapStore fileStore = new FileMapStore("Non-Freemium");
            LocalConnector connector = new LocalConnector("local");
            //var featureToggleClient = new CfClient(connector, Config.builder().store(fileStore).build());
            var harnessConfig = new Config();
            harnessConfig = Config.Builder()
                .SetPollingInterval(60000)
                .SetAnalyticsEnabled()
                .SetStreamEnabled(true)
                .SetStore(fileStore)
                .Build();

            await CfClient.Instance.Initialize(_configuration["Harness:FeatureFlagKey"], harnessConfig);


            Target target = Target.builder()
                .Name(_configuration["Harness:UserName"]) //can change with your target name
                .Identifier(_configuration["Harness:Identifier"]) //can change with your target identifier
                .build();

            FlagSkipProcessing = CfClient.Instance.boolVariation("skipprocessing", target, false);
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
