using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UI_Automation_Selenium_CSharp
{
    [TestClass]
    public class TC_004_Edit_Card : BaseClass
    {
        [TestInitialize]
        public void TestSetup()
        {
            //This is a call to a method for trello Login.
            objGeneric.TrelloLogin(ProjectConfiguration.Selenium_UserName, ProjectConfiguration.Selenium_Password, JSONDataReader.Text_HomePage_Verification);
        }

        [TestCategory("Regression")]
        [Priority(4)]
        [TestMethod]
        public void TC004_Edit_Card()
        {
            try
            {
                ReportLogger.Info("Starting test script for editing a card.");
                //This is a call to a method for editing a card.
                objTrelloHome.editCard(JSONDataReader.Text_Edit_Card);
                ReportLogger.Info("New Card Edited Successfully.");
            }
            catch (Exception e)
            {
                ReportLogger.Fail(e.Message + "Exception in TC004_Edit_Card Test Case.");
                objSeleniumMethodLib.ScreenShotonFailure();
                Assert.Fail(e.Message + "Exception in TC004_Edit_Card Test Case. ");
            }
        }

        [TestCleanup]
        public void CleanUp()
        {
            try
            {

            }
            finally
            {
                //driver close and Report writing
                TestCleanup();
            }
        }
    }
}
