
using OpenQA.Selenium;
using AventStack.ExtentReports;
using OpenQA.Selenium.Interactions;

namespace UI_Automation_Selenium_CSharp
{
    public class OR_Trello_Home
    {
        public IWebDriver driver;
        SeleniumSetMethodLibrary objSeleniumMethodLib;
        public ExtentTest ReportLogger;
        string TestCaseName;

        public OR_Trello_Home(IWebDriver driver,string TCName, ExtentTest ReportLogger)
        {
            this.driver = driver;
            this.TestCaseName = TCName;
            this.ReportLogger = ReportLogger;
            objSeleniumMethodLib = new SeleniumSetMethodLibrary(this.driver,TestCaseName, ReportLogger);
        }

        #region Locators for Trello Board Page Page

        //Locator for Page Container
        public IWebElement Container_PageText => driver.FindElement(By.XPath("//*[contains(.,.)]"));

        //Locator for Create button on header
        public IWebElement Button_Create => driver.FindElement(By.XPath("//div[@id='header']/div[3]/div/div[2]/button"));

        //Locator for Create your First Board
        public IWebElement Button_Create_Your_First_Board => driver.FindElement(By.XPath("//button[.='Create your first board']"));

        //Locator for title of the board
        public IWebElement TB_Board_Title => driver.FindElement(By.XPath("//input[@data-test-id='create-board-title-input']"));

        //Locator for Create Board Button
        public IWebElement Button_Create_Board => driver.FindElement(By.XPath("//button[@data-test-id='create-board-submit-button']"));

        //Locator for Create New Board
        public IWebElement Button_Create_New_Board => driver.FindElement(By.XPath("//*[@data-test-id='create-board-tile']"));

        //Locator for Boards
        public IWebElement Link_Boards_ => driver.FindElement(By.LinkText("Boards"));

        //Locator for Board Home
        public IWebElement Link_Boards => driver.FindElement(By.XPath("//*[@data-test-id='home-team-boards-tab']"));

        //Locator for Title of Card
        public IWebElement TB_Card_Title => driver.FindElement(By.XPath("//*[@placeholder='Enter a title for this card…']"));

        //Locator for Add Card Button
        public IWebElement Button_Add_Card => driver.FindElement(By.XPath("//*[@type='submit'][@value='Add card']"));

        //Locator for Test Board
        public IWebElement Link_Test_Board => driver.FindElement(By.XPath("//*[@title='Board_001']"));

        //Button for Add Card
        public IWebElement Button_Add_a_Card => driver.FindElement(By.XPath("(//*[@class='js-add-a-card'])[1]"));

        //Placeholder For Add Card to Newly Created List
        public IWebElement Placeholder_Add_a_Card => driver.FindElement(By.XPath("(//*[@class='js-add-a-card'])[4]"));
        

        //Locator for Add Another List
        public IWebElement Button_Add_Another_List => driver.FindElement(By.XPath("//*[@class='open-add-list js-open-add-list']"));

        //Locator for Add Another List
        public IWebElement TB_Title_For_List => driver.FindElement(By.XPath("//*[@class='list-name-input']"));

        //Locator for Add List Button
        public IWebElement Button_Add_List => driver.FindElement(By.XPath("//*[@type='submit'][@value='Add list']"));

        //Locator for hidden Edit Task Icon
        public IWebElement Button_Hidden_Edit_Icon => driver.FindElement(By.XPath("//*[@class='icon-sm icon-edit list-card-operation dark-hover js-open-quick-card-editor js-card-menu']"));
        
        //Locator for Edit Icon
        public IWebElement Icon_Edit_Task => driver.FindElement(By.CssSelector(".icon-edit"));

        //Locator for Editing Lable
        public IWebElement Lable_Edit_Task_Title => driver.FindElement(By.XPath("//*[@class='list-card-edit-title js-edit-card-title']"));
        
        //Locator for Save button for Editing Task
        public IWebElement Button_Save_Edited_Task => driver.FindElement(By.XPath("//*[@type='submit'][@value='Save']"));

        //Locator Move Menu Option
        public IWebElement MenuButton_Move => driver.FindElement(By.XPath("//*[@class='quick-card-editor-buttons-item js-move-card']/span[2]"));

        //Locator for Dropdown List
        public IWebElement DD_List => driver.FindElement(By.XPath("//*[@class='js-select-list']"));

        //Locator for Move Button
        public IWebElement Button_Move_Task => driver.FindElement(By.XPath("//*[@type='submit'][@value='Move']"));

        //Locator for Clicking onPop Up
        public IWebElement PopUp_Move => driver.FindElement(By.XPath("//*[@class='pop-over-content js-pop-over-content u-fancy-scrollbar js-tab-parent']/div/div/div/h4"));

        #endregion Locators Locators for Trello Home Page

        #region Methods for Trello Home Page Application

        //This method will create a board. 
        public void createBoard(string BoardTitle)
        {
            objSeleniumMethodLib.clickElement(Link_Boards_);
            objSeleniumMethodLib.ThreadSleep(1500);

            ReportLogger.Info("Clicking on Create New Board Button.");
            objSeleniumMethodLib.clickElement(Button_Create_New_Board);

            ReportLogger.Info("Entering title for New board.");
            objSeleniumMethodLib.enterText(TB_Board_Title, BoardTitle);

            ReportLogger.Info("Clicking on Create New Board Button.");
            objSeleniumMethodLib.clickElement(Button_Create_Board);
        }

        //This method will create a Card.
        public void createCard(string CardTitle)
        {
            objSeleniumMethodLib.clickElement(Link_Test_Board);
            objSeleniumMethodLib.waitForPageLoad(5000);

            ReportLogger.Info("Clicking on Add New Card Button.");
            objSeleniumMethodLib.clickElement(Button_Add_a_Card);

            ReportLogger.Info("Entering title for New Card.");
            objSeleniumMethodLib.enterText(TB_Card_Title, CardTitle);

            ReportLogger.Info("Clicking on Add Card Button.");
            objSeleniumMethodLib.clickElement(Button_Add_Card);
        }

        //This method will create a List.
        public void creatList(string ListTitle_1, string ListTitle_2, string ListTitle_3, string ListTitle_4)
        {
            objSeleniumMethodLib.clickElement(Link_Test_Board);
            objSeleniumMethodLib.waitForPageLoad(5000);

            ReportLogger.Info("Clicking on Add Another List Button.");
            objSeleniumMethodLib.clickElement(Button_Add_Another_List);

            ReportLogger.Info("entering title for Newly Added List.- To Do");
            objSeleniumMethodLib.enterText(TB_Title_For_List, ListTitle_1);

            ReportLogger.Info("Clicking on Add List Button.");
            objSeleniumMethodLib.clickElement(Button_Add_List);


            ReportLogger.Info("entering title for Newly Added List.- Doing");
            objSeleniumMethodLib.enterText(TB_Title_For_List, ListTitle_2);

            ReportLogger.Info("Clicking on Add List Button.");
            objSeleniumMethodLib.clickElement(Button_Add_List);


            ReportLogger.Info("entering title for Newly Added List.- Done");
            objSeleniumMethodLib.enterText(TB_Title_For_List, ListTitle_3);

            ReportLogger.Info("Clicking on Add List Button.");
            objSeleniumMethodLib.clickElement(Button_Add_List);


            ReportLogger.Info("entering title for Newly Added List.- Deployed To Production.");
            objSeleniumMethodLib.enterText(TB_Title_For_List, ListTitle_4);

            ReportLogger.Info("Clicking on Add List Button.");
            objSeleniumMethodLib.clickElement(Button_Add_List);
        }

        //This method will edit a card.
        public void editCard(string EditedText)
        {
            objSeleniumMethodLib.clickElement(Link_Test_Board);
            objSeleniumMethodLib.waitForPageLoad(5000);

            ReportLogger.Info("Using Action class to hover on the control to make edit icon visible.");
            Actions action = new Actions(driver);
            action.MoveToElement(Button_Hidden_Edit_Icon).Build().Perform();

            ReportLogger.Info("Clicking on Edit Icon.");
            objSeleniumMethodLib.clickElement(Icon_Edit_Task);

            ReportLogger.Info("Clearing Existing title.");
            objSeleniumMethodLib.clearText(Lable_Edit_Task_Title);

            ReportLogger.Info("Entering new title for Task.");
            objSeleniumMethodLib.enterText(Lable_Edit_Task_Title,EditedText);

            ReportLogger.Info("Clicking on Save Edited Task button.");
            objSeleniumMethodLib.clickElement(Button_Save_Edited_Task);
        }

        //This method will move a card.
        public void moveCard()
        {
            objSeleniumMethodLib.clickElement(Link_Test_Board);
            objSeleniumMethodLib.ThreadSleep(1500);

            ReportLogger.Info("Using Action class to hover on the control to make edit icon visible.");
            Actions action = new Actions(driver);
            action.MoveToElement(Button_Hidden_Edit_Icon).Build().Perform();

            objSeleniumMethodLib.ThreadSleep(1500);

            ReportLogger.Info("Using Action class to drag and drop the card from one list to another");
            action.ClickAndHold(Icon_Edit_Task).MoveToElement(Placeholder_Add_a_Card).Release(Placeholder_Add_a_Card).Build().Perform();

        }

        #endregion Methods for Trello Home Page Application


    }
}
