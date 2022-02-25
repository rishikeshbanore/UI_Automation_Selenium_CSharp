//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;


//namespace UI_Automation_Selenium_CSharp
//{
//    [TestClass]
//    public class TC_Trello_Playbook : BaseClass
//    {
//        [TestInitialize]
//        public void TestSetup()
//        {
//            //This is a call to a method for trello Login.
//            objGeneric.TrelloLogin(ProjectConfiguration.Selenium_UserName, ProjectConfiguration.Selenium_Password, JSONDataReader.Text_HomePage_Verification);
//        }

//        [TestCategory("Regression")]
//        [Priority(1)]
//        [TestMethod]
//        public void TC001_Create_Board()
//        {
//            try
//            {
//                //This is a call to a method for deleting test data created by test script during previous test run
//                 //objGeneric.deleteBoard();

//                //This is a call to a method for creating board.
//                ReportLogger.Info("Starting test script for creating new board");
//                objTrelloHome.createBoard(JSONDataReader.Text_Board_Title);
//                ReportLogger.Info("New Board is created Successfully");
//            }
//            catch (Exception e)
//            {
//                ReportLogger.Fail(e.Message + "Exception in TC_001_Create_Board Test Case. Board is NOT Created");
//                objSeleniumMethodLib.ScreenShotonFailure();
//                Assert.Fail(e.Message + "Exception in TC_001_Create_Board Test Case. ");
//            }

//        }

//        [TestCategory("Regression")]
//        [Priority(2)]
//        [TestMethod]
//        public void TC002_Add_Card()
//        {
//            try
//            {
//                ReportLogger.Info("Starting test script for adding new card");
//                //This is a call to a method for creating a card.
//                objTrelloHome.creatCard(JSONDataReader.Text_Task_Title);
//                ReportLogger.Info("New Card is created Successfully");
//            }
//            catch (Exception e)
//            {
//                ReportLogger.Fail(e.Message + "Exception in TC002_Add_Card Test Case.");
//                objSeleniumMethodLib.ScreenShotonFailure();
//                Assert.Fail(e.Message + "Exception in TC002_Add_Card Test Case. ");
//            }

//        }

//        [TestCategory("Regression")]
//        [Priority(3)]
//        [TestMethod]
//        public void TC003_Add_List()
//        {
//            try
//            {
//                ReportLogger.Info("Starting test script for adding new list");
//                //This is a call to a method for creating a list.
//                objTrelloHome.creatList(JSONDataReader.Text_List_Title);
//                ReportLogger.Info("New List added Successfully.");
//            }
//            catch (Exception e)
//            {
//                ReportLogger.Fail(e.Message + "Exception in TC003_Add_List Test Case.");
//                objSeleniumMethodLib.ScreenShotonFailure();
//                Assert.Fail(e.Message + "Exception in TC003_Add_List Test Case. ");
//            }
//        }

//        [TestCategory("Regression")]
//        [Priority(4)]
//        [TestMethod]
//        public void TC004_Edit_Card()
//        {
//            try
//            {
//                ReportLogger.Info("Starting test script for editing a card.");
//                //This is a call to a method for editing a card.
//                objTrelloHome.editCard(JSONDataReader.Text_Edit_Card);
//                ReportLogger.Info("New Card Edited Successfully.");
//            }
//            catch (Exception e)
//            {
//                ReportLogger.Fail(e.Message + "Exception in TC004_Edit_Card Test Case.");
//                objSeleniumMethodLib.ScreenShotonFailure();
//                Assert.Fail(e.Message + "Exception in TC004_Edit_Card Test Case. ");
//            }
//        }

//        [TestCategory("Regression")]
//        [Priority(5)]
//        [TestMethod]
//        public void TC005_Move_Card()
//        {
//            try
//            {
//                ReportLogger.Info("Starting test script for moving a card.");
//                //This is a call to a method for cmoving a card.
//                objTrelloHome.moveCard();
//                ReportLogger.Info("Card is moved successfully to another list.");
//            }
//            catch (Exception e)
//            {
//                ReportLogger.Fail(e.Message + "Exception in TC005_Move_Card Test Case.");
//                objSeleniumMethodLib.ScreenShotonFailure();
//                Assert.Fail(e.Message + "Exception in TC005_Move_Card Test Case. ");
//            }
//        }

//        [TestCleanup]
//        public void CleanUp()
//        {
//            try
//            {

//            }
//            finally
//            {
//                //driver close and Report writing
//                TestCleanup();
//            }
//        }
//    }
//}
