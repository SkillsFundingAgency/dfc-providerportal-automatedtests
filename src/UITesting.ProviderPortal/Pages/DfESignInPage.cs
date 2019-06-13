using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.ProviderPortal.Pages.Data_Quality_Indicators;

namespace UITesting.ProviderPortal.Pages
{ 

    public class DfESignInPage : BasePage
    {
        private static String PAGE_TITLE = "DfE Sign-in";
        private By usernameField = By.Id("username");
        private By passwordField = By.Id("password");
        private By signInButton = By.ClassName("button");
        private By SearchField = By.Id("SearchTerm");
        private By DQIUpdateStartDateLink = By.PartialLinkText("courses need their start date updating");
        private By HomePageTitle = By.XPath(".//*[@id='VenueSearchResultContainer']/h1");

        public DfESignInPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public DfESignInPage EnterUsername(String user)
        {
            FormCompletionHelper.EnterText(usernameField, user);
            return new DfESignInPage(webDriver);
        }

        public DfESignInPage EnterPassword(String pass)
        {
            FormCompletionHelper.EnterText(passwordField, pass);
            return new DfESignInPage(webDriver);
        }

        public SearchProviderPage ClickSignInButton()
        {
            FormCompletionHelper.ClickElement(signInButton);
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(SearchField, 60);
            return new SearchProviderPage(webDriver);
        }

        public DQIDashbordPage ClickSignInButtonProvider()
        {
            FormCompletionHelper.ClickElement(signInButton);
            //System.Threading.Thread.Sleep(4000);
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(HomePageTitle, 60);
            return new DQIDashbordPage(webDriver);
        }

    }
}