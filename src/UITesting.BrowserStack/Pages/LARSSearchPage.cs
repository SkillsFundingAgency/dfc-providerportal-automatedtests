using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.BrowserStack.Pages
{
    public class LARSSearchPage : BasePage
    {
        private static String PAGE_TITLE = "Provider Search";

        public LARSSearchPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        //private By searchField = By.Name("LarsSearchTerm");
        private readonly By UKPRN = By.Id("UKPrn");
        private readonly By SearchBtn = By.Id("search");
        private readonly By searchResults = By.Id("live");

        public LARSSearchPage EnterSearchTextAndSubmit(String searchText)
        {
            FormCompletionHelper.EnterText(UKPRN, searchText);
            return new LARSSearchPage(webDriver);
        }


        public LARSSearchPage Submit()
        {
            FormCompletionHelper.ClickElement(SearchBtn);
            return new LARSSearchPage(webDriver);
        }

        public LARSSearchPage ConfirmLARSdisplayed()
        {
            PageInteractionHelper.IsElementDisplayed(searchResults);
            return new LARSSearchPage(webDriver);
        }
    }
}