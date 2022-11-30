using Honeycomb.OpenTelemetry;
using System.Diagnostics.Metrics;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OpenTelemetry;
using OpenTelemetry.Trace;
using OpenTelemetry.Metrics;

namespace OneNoteExporter.Tests
{
    [TestClass()]
    public class ConverterTests
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("Inside ClassInitialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("Inside ClassCleanup");
        }

        [TestMethod()]
        public void ConvertOneNote_Successful()
        {
            //arrange
            //Mock app
            var mockApp = new Mock<Microsoft.Office.Interop.OneNote.Application>();
            
            //Mock configuration
            var _configurationRoot = new Mock<IConfigurationRoot>();
            _configurationRoot.SetupGet(x => x[It.IsAny<string>()]).Returns("the string you want to return");
            
            //mock tracer
            var _telemetryTracer = new Mock<Tracer>();
            var _tracerProvider = Sdk.CreateTracerProviderBuilder().Build();
            //_tracerProvider.

            //_telemetryTracer.SetupGet(x => x)
            //var ts = new 
            //Tracer tracer = OpenTelemetry.getTracer("instrumentation-library-name", "1.0.0");
            //mock meter

            //create the meter
            var _ApplicationMeter = new Meter("instrumentation-library-name", "1.0.0");

            //add meter to provider
            using var meterProvider = Sdk.CreateMeterProviderBuilder()
              .AddMeter("instrumentation-library-name")
              .AddConsoleExporter()
              .Build();


            
            var _meter = new Mock<System.Diagnostics.Metrics.Meter>();

            var c = new Converter(mockApp.Object,  _telemetryTracer.Object, _meter.Object);
           
            //act

            var result = c.ConvertPages();

            //assert
            Assert.IsTrue(result > 0);


           // Assert.Fail();
        }


    }
}