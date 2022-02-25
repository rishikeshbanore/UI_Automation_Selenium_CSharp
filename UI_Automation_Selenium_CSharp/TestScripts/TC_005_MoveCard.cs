using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UI_Automation_Selenium_CSharp
{
    [TestClass]
    public class TC_005_Move_Card : BaseClass
    {
        [TestInitialize]
        public void TestSetup()
        {
            //This is a call to a method for trello Login.
            objGeneric.TrelloLogin(ProjectConfiguration.Selenium_UserName, ProjectConfiguration.Selenium_Password, JSONDataReader.Text_HomePage_Verification);
        }

        [TestCategory("Regression")]
        [Priority(5)]
        [TestMethod]
        public void TC005_Move_Card()
        {
            try
            {
                ReportLogger.Info("Starting test script for moving a card.");
                //This is a call to a method for cmoving a card.
                objTrelloHome.moveCard();
                ReportLogger.Info("Card is moved successfully to another list.");
            }
            catch (Exception e)
            {
                ReportLogger.Fail(e.Message + "Exception in TC005_Move_Card Test Case.");
                objSeleniumMethodLib.ScreenShotonFailure();
                Assert.Fail(e.Message + "Exception in TC005_Move_Card Test Case. ");
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
