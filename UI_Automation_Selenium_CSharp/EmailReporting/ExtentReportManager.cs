using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UI_Automation_Selenium_CSharp
{
    public class ExtentReportManager
    {
        private static ExtentReports extent;
        private static ExtentV3HtmlReporter htmlReporter;

        public static ExtentReports GetExtent()
        {
            if (extent != null)
                return extent;
            extent = new ExtentReports();
            extent.AddSystemInfo("Environment - URL", ProjectConfiguration.Selenium_URL);
            extent.AddSystemInfo("Created By", "BANORE,Rishikesh");
            extent.AddSystemInfo("Created For", "Trello Team | BANORE,Rishikesh");
            extent.AttachReporter(getHtmlReporter());
            return extent;
        }

        private static ExtentV3HtmlReporter getHtmlReporter()
        {
            htmlReporter = new ExtentV3HtmlReporter(GetFilePath());
            htmlReporter.Config.Theme = Theme.Dark;
            htmlReporter.Config.ReportName = "Trello_UI_Automation_Test_Execution_Report";
            htmlReporter.Config.DocumentTitle = "Trello_UI_Automation_Test_Execution_Report";
            htmlReporter.Config.EnableTimeline = true;
            return htmlReporter;
        }

        public static bool hasFailures()
        {
            List<Status> _logStatus = htmlReporter.StatusList;

            if (_logStatus != null && _logStatus.Any(x => x == Status.Fail))
            {
                return true;
            }
            return false;
        }

        public static string GetFilePath()
        {
            string todaysDate = DateTime.Now.ToString("yyyy-MM-dd");
            var reportFile = Path.Combine(ProjectConfiguration.Selenium_ReportLocation, ProjectConfiguration.Selenium_ReportName + "_" + todaysDate + ".html");
            return reportFile;
        }

        public static ExtentTest createTest(string name, string description)
        {
            return extent.CreateTest(name, description); ;
        }

    }
}
