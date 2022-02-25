using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UI_Automation_Selenium_CSharp
{
    [TestClass]
    public class TC_002_Add_List : BaseClass
    {
        [TestInitialize]
        public void TestSetup()
        {
            //This is a call to a method for trello Login.
            objGeneric.TrelloLogin(ProjectConfiguration.Selenium_UserName, ProjectConfiguration.Selenium_Password, JSONDataReader.Text_HomePage_Verification);
        }

        [TestCategory("Regression")]
        [Priority(2)]
        [TestMethod]
        public void TC002_Add_List()
        {
            try
            {
                ReportLogger.Info("Starting test script for adding new list");
                //This is a call to a method for creating a list.
                objTrelloHome.creatList(JSONDataReader.Text_List_Title_1, JSONDataReader.Text_List_Title_2, JSONDataReader.Text_List_Title_3, JSONDataReader.Text_List_Title_4);
                ReportLogger.Info("New List added Successfully.");
            }
            catch (Exception e)
            {
                ReportLogger.Fail(e.Message + "Exception in TC003_Add_List Test Case.");
                objSeleniumMethodLib.ScreenShotonFailure();
                Assert.Fail(e.Message + "Exception in TC003_Add_List Test Case. ");
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
