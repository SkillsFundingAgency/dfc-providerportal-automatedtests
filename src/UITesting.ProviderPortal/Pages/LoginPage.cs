using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Provider_Management;

namespace UITesting.ProviderPortal.Pages
{ 

    public class LoginPage : BasePage
    {
        private static String PAGE_TITLE = "Use a local account to log in.";
        private By usernameField = By.Id("Input_UserName");
        private By passwordField = By.Id("Input_Password");
        private By rememberMe = By.XPath(".//*[@id='main-content']/div/div/form/div[4]/div/div/input");
        private By LoginButton = By.XPath(".//*[@id='main-content']/div/div/form/button");


        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public LoginPage EnterUsername(String user)
        {
            FormCompletionHelper.EnterText(usernameField, user);
            return new LoginPage(webDriver);
        }

        public LoginPage EnterPassword(String pass)
        {
            FormCompletionHelper.EnterText(passwordField, pass);
            return new LoginPage(webDriver);
        }

        public SearchProviderPage ClickLoginButton()
        {
            FormCompletionHelper.ClickElement(LoginButton);
            System.Threading.Thread.Sleep(3000);
            PageInteractionHelper.WaitForPageToLoad();
            return new SearchProviderPage(webDriver);
        }

    }
}