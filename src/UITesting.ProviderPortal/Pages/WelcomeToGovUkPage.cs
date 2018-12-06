using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

/*namespace UITesting.ProviderPortal.Pages
{
    public class WelcomeToGovUkPage : BasePage
    {
        private static String PAGE_TITLE = "Welcome to GOV.UK";

        public WelcomeToGovUkPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By searchField = By.Name("q");
        //private By searchButton = By.CssSelector(".search-submit");
		private By searchButton = By.XPath (".//*[@id='content']/header/div/div/div/div[1]/div/form/div/div/div/button");

		public SearchResultsPage EnterSearchTextAndSubmit(String searchText)
        {
            FormCompletionHelper.EnterText(searchField, searchText);
            FormCompletionHelper.ClickElement(searchButton);
            return new SearchResultsPage(webDriver);
        }
    }
}*/