using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Office.Interop.OneNote;
using OneNoteExporter.AppConfig;
using Serilog;
using System.Diagnostics;
using OpenTelemetry.Trace;
using Honeycomb.OpenTelemetry;
using OpenTelemetry;
using System.Diagnostics.Metrics;
using OpenTelemetry.Metrics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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

            //var serviceProvider = ServicesConfigure();
            //serviceProvider.GetService<Converter>().Convert.Process();


            var honeycombOptions = new HoneycombOptions
            {
                ServiceName = ApplicationUtility.GetApplicationName(),
                ServiceVersion = ApplicationUtility.GetApplicationVersion().ToString(),
                ApiKey = _configuration["HoneyComb:apikey"],

            };

            // configure OpenTelemetry SDK to send metric data to Honeycomb
      

            //configure OT SDK to send traces to Honeycomb
            using var tracerProvider = Sdk.CreateTracerProviderBuilder()
            .AddHoneycomb(honeycombOptions)
            .AddConsoleExporter() // for debugging
            .Build();
            //.AddAutoInstrumentations()  //get redis cache error
            //System.InvalidOperationException: 'StackExchange.Redis IConnectionMultiplexer could not be resolved through application IServiceProvider'

            // get an instance of a tracer that can be used to create spans
            var tracer = tracerProvider.GetTracer(honeycombOptions.ServiceName);

            
            // Register Tracer so it can be injected into other components (eg Controllers)
            //builder.Services.AddSingleton(TracerProvider.Default.GetTracer(honeycombOptions.ServiceName));

            // create span to describe some application logic
            using var span = tracer.StartActiveSpan("doSomething");
            span.SetAttribute("app.manual-span.message", "Adding custom spans is also super easy!");
            span.SetAttribute("user_id", 123);
            span.End(new DateTimeOffset());

          
            _converter = new Converter(OnenoteApp,_configuration, tracer, honeycombOptions);
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


        public static ServiceProvider ServicesConfigure()
        {
            return new ServiceCollection()
                .AddLogging(l => l.AddConsole())
                .Configure<LoggerFilterOptions>(c => c.MinLevel = LogLevel.Trace)
                //.AddSingleton<IPrintSettingsProvider, PrintSettingsProvider>()
                //.AddSingleton<IConsolePrinter, ConsolePrinter>()
                .AddSingleton<Converter>()
                .BuildServiceProvider();
        }


    }


}
