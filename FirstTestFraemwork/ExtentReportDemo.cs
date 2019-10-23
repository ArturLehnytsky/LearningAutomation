using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Net;

namespace FirstTestFraemwork
{
    [TestClass]
    public class ExtentReportDemo
    {
        [TestMethod]
        public void ExtentTestCase()
        {
            var htmlReporter = new ExtentHtmlReporter("extentReport.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            //use real value
            string hostname = Dns.GetHostName();
            OperatingSystem os = Environment.OSVersion;
            
            
            //Hard coding
            extent.AddSystemInfo("Operating System", os.ToString());
            extent.AddSystemInfo("Hostname: ", hostname);
            extent.AddSystemInfo("Browser: ", "Google Chrome");

            var test = extent.CreateTest("ExtentTestCase");
            test.Log(Status.Info, "Step 1: Test case Starts.");
            test.Log(Status.Pass, "Step 2: Test case for Pass");
            test.Log(Status.Fail, "Step 3: Test case failed");
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
            test.Pass("Screenshot").AddScreenCaptureFromPath("screenshot.png");
            extent.Flush();

        }
    }
}
