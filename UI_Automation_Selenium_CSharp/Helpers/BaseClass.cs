using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports;

namespace UI_Automation_Selenium_CSharp
{
    [TestClass]
    public class BaseClass : Driver
    {
        public ExtentReports reportsclass { get; set; }
        public ExtentTest ReportLogger { get; set; }
        public SeleniumSetMethodLibrary objSeleniumMethodLib { get; set; }
        public OR_Trello_Home objTrelloHome { get; set; }
        public OR_Generic objGeneric{ get; set; }


        public string testCaseName { get; set; }

        // Contructor for the class
        public BaseClass()
        {
            this.testCaseName = this.GetType().Name;
            reportsclass = ExtentReportManager.GetExtent();
            ReportLogger = reportsclass.CreateTest(testCaseName);
            objSeleniumMethodLib = new SeleniumSetMethodLibrary(driver, testCaseName, ReportLogger);
            objTrelloHome = new OR_Trello_Home(driver,  testCaseName, ReportLogger);
            objGeneric = new OR_Generic(driver,  testCaseName, ReportLogger);
        }

        // Generic TestCleanup() method for all the test scripts
        public void TestCleanup()
        {
            driver.Quit();

            driver.Dispose();
            if (ProjectConfiguration.Selenium_ReportWriting.ToLower() == "yes")
            {
                reportsclass.Flush();
            }
        }

        // Everything under 'Assembly Cleanup' will get executed after all the tests have finished       
        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            // Email test report after all tests have been executed and there is ata least one failed test case       
            bool hasFailures = ExtentReportManager.hasFailures();

            if (ProjectConfiguration.Selenium_EmailReport.ToLower() == "yes")
            {
                EmailReport emailReport = new EmailReport();
                emailReport.sendEmail(ProjectConfiguration.Selenium_Recipient1, ProjectConfiguration.Selenium_Recipient2, ProjectConfiguration.Selenium_Recipient3, ProjectConfiguration.Selenium_Recipient4);
            }
        }
    }
}
