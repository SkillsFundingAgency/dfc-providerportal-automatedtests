using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Provider_Management;

namespace UITesting.ProviderPortal.Pages
{ 

    public class HomePage : BasePage
    {
        private static String PAGE_TITLE = "Welcome to the Course Directory";
        private By loginLink = By.LinkText("Login");
        private By signIn = By.XPath(".//*[@id='form-signin']/div[2]/button"); 

        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }


        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }


        public LoginPage ClickLogin()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(loginLink);
            System.Threading.Thread.Sleep(3000);
            PageInteractionHelper.WaitForPageToLoad();
            return new LoginPage(webDriver);
        }


        public DfESignInPage ClickLoginDfE()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(loginLink);
          //  System.Threading.Thread.Sleep(3000);
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(signIn, 20);
            return new DfESignInPage(webDriver);
        }

    }
}