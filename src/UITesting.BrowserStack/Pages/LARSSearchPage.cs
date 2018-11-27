using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.BrowserStack.Pages
{
    public class LARSSearchPage : BasePage
    {
        private static String PAGE_TITLE = "Customised page template";

        public LARSSearchPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        //private By searchField = By.Name("LarsSearchTerm");
        private readonly By location = By.Name("LarsSearchTerm");
        private readonly By searchResults = By.XPath(".//*[@id='LarsSearchResultContainer']");

        internal LARSSearchPage EnterSearchTextAndSubmit(String searchText)
        {
            FormCompletionHelper.EnterText(location, searchText);
            return new LARSSearchPage(webDriver);
        }

        internal LARSSearchPage ConfirmLARSdisplayed(String searchText)
        {
            PageInteractionHelper.IsElementDisplayed(searchResults);
            return new LARSSearchPage(webDriver);
        }
    }
}