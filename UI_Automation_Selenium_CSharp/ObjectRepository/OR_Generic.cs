using OpenQA.Selenium;
using AventStack.ExtentReports;
using OpenQA.Selenium.Interactions;

namespace UI_Automation_Selenium_CSharp
{
    public class OR_Generic
    {
        public IWebDriver driver;
        SeleniumSetMethodLibrary objSeleniumMethodLib;
        public ExtentTest ReportLogger;
        string TestCaseName;

        public OR_Generic(IWebDriver driver, string TCName, ExtentTest ReportLogger)
        {
            this.driver = driver;
            this.TestCaseName = TCName;
            this.ReportLogger = ReportLogger;
            objSeleniumMethodLib = new SeleniumSetMethodLibrary(this.driver,TestCaseName, ReportLogger);
        }

        #region Locators for Generic functionalities

        //Locator for Page Container
        public IWebElement Container_PageText => driver.FindElement(By.XPath("//*[contains(.,.)]"));

        //Locator for userName
        public IWebElement TB_UserName => driver.FindElement(By.Id("user"));

        //Locator for Password
        public IWebElement TB_Password => driver.FindElement(By.Id("password"));

        //Locator for Loginwithaltessian
        public IWebElement Button_Login_Altassian => driver.FindElement(By.Id("login"));

        //Locator for Log-in
        public IWebElement Button_Login => driver.FindElement(By.Id("login-submit"));

        //Locator for Board Home
        public IWebElement Link_Boards => driver.FindElement(By.XPath("//*[@data-test-id='home-team-boards-tab']"));

        //Locator for Expanding Sidebar
        public IWebElement Expander_Sidebar => driver.FindElement(By.XPath("//*[@class='_1e3OHas5aNG1hj']"));

        //Locator for Trello Name
        public IWebElement Link_Trello_Home => driver.FindElement(By.XPath(" //*[@aria-label='Back to home']"));

        //Locator for Test Board
        public IWebElement Link_Test_Board => driver.FindElement(By.XPath("//*[@title='Board_001']"));

        //Locator for Hidden Menu Oprion
        public IWebElement Button_Menu_Options => driver.FindElement(By.XPath("(//*[@aria-label='OverflowMenuHorizontalIcon'])[2]"));

        //Locator for Close Board 
        public IWebElement Button_Close_Board => driver.FindElement(By.XPath("(//*[@title='Close board...']/span)[1]"));

        //Locator For Close board Confirmation 
        public IWebElement Button_Close_Board_Confirmation => driver.FindElement(By.XPath("//*[@type='button'][@title='Close']"));
        

        #endregion Locators for Generic functionalities

        #region Methods for Generic Functionalities

        //Method for login
        public void TrelloLogin(string UserName, string Password, string Verification_Text)
        {
            ReportLogger.Info("Entering Username.");
            objSeleniumMethodLib.enterText(TB_UserName, UserName);

            ReportLogger.Info("Clicking on Altassian login button.");
            objSeleniumMethodLib.clickElement(Button_Login_Altassian);

            ReportLogger.Info("Entering Password.");
            objSeleniumMethodLib.enterText(TB_Password, Password);

            ReportLogger.Info("Clicking on Login Button.");
            objSeleniumMethodLib.clickElement(Button_Login);
            objSeleniumMethodLib.ThreadSleep(3000);

            if (SeleniumSetMethodLibrary.waitTillElementisDisplayed(driver,By.XPath("//*[@data-test-id='home-team-boards-tab']"),7000))
            {
                ReportLogger.Info("User is logged in Successfully");
            }
            else
            {
                ReportLogger.Info("User is NOT logged in Successfully");
            }
        }

        public void deleteBoard()
        {
            objSeleniumMethodLib.clickElement(Link_Trello_Home);
            objSeleniumMethodLib.waitForPageLoad(3000);
            objSeleniumMethodLib.clickElement(Link_Test_Board);
            objSeleniumMethodLib.waitForPageLoad(5000);

            ReportLogger.Info("Clickig on Expander button on Sidebar.");
            objSeleniumMethodLib.clickElement(Expander_Sidebar);

            ReportLogger.Info("Hovering over element using action class.");
            Actions action = new Actions(driver);
            action.MoveToElement(Button_Menu_Options).Build().Perform();

            ReportLogger.Info("Clicking on Menu Option Button.");
            objSeleniumMethodLib.clickElement(Button_Menu_Options);

            ReportLogger.Info("Clicking on Close Board Button.");
            objSeleniumMethodLib.clickElement(Button_Close_Board);

            ReportLogger.Info("Clicking on confirmation to close the board.");
            objSeleniumMethodLib.clickElement(Button_Close_Board_Confirmation);

            objSeleniumMethodLib.clickElement(Link_Trello_Home);
            objSeleniumMethodLib.waitForPageLoad(3000);

        }

        #endregion Methods for Generic Functionalities



    }

}
