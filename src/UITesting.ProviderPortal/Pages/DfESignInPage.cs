using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Provider_Management;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages
{
    public class DfESignInPage : BasePage
    {
        private static String PAGE_TITLE = "DfE Sign-in";
        private By username = By.Id("username");
        private By password = By.Id("password");
        //private By signinButton = By.XPath(".//*[@id='form - signin']/div[1]/button");
        private By signinButton = By.ClassName("button");



        public DfESignInPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public DfESignInPage EnterUsername(String user)
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.EnterText(username, user);
            return new DfESignInPage(webDriver);
        }

        public DfESignInPage EnterPassword(String pass)
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.EnterText(password, pass);
            return new DfESignInPage(webDriver);
        }

        public SearchProviderPage ClickSignIn()
        {
            FormCompletionHelper.ClickElement(signinButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new SearchProviderPage(webDriver);
        }

       
    }
}