using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class SearchProviderNewPage : BasePage
    {
        private static String PAGE_TITLE = "Search providers";
        private By SearchField = By.Id("providerSearchTerm");
        private By SearchButton = By.Id("searchProvider");
        private By ViewCoursesButton = By.Id("btnQualificationList");
        private By searchResults = By.XPath(".//*[@id='ProviderSearchResultContainer']/div/table/tbody/tr/td[1]");
        private By LoginLink = By.LinkText("Login");
        private By FirstUKPRN = By.XPath(".//*[@id='ProviderSearchResultContainer']/div/table/tbody/tr/td[1]");
        private By FirstProvider = By.XPath(".//*[@id='ProviderSearchResultContainer']/div/table/tbody/tr/td[2]");
        private By FirstViewLink = By.XPath(".//*[@id='ProviderSearchResultContainer']/div/table/tbody/tr[1]/td[5]/a");


        public SearchProviderNewPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(SearchButton, 20);
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public SearchProviderNewPage EnterUKPRN(String UKPRN)
        {
            FormCompletionHelper.EnterText(SearchField, UKPRN);
            return new SearchProviderNewPage(webDriver);
        }

        public SearchProviderNewPage ClickSearchButton()
        {
            FormCompletionHelper.ClickElement(SearchButton);
            return new SearchProviderNewPage(webDriver);
        }

        public ProviderDetailsPage ViewProvider()
        {
            FormCompletionHelper.ClickElement(FirstViewLink);
            PageInteractionHelper.WaitForPageToLoad();
            return new ProviderDetailsPage(webDriver);
        }

        public SearchProviderNewPage GetUKPRN(String UKPRN)
        {
            var UKPRNvalue = webDriver.FindElement(FirstUKPRN).GetAttribute("textContent");
            if (UKPRNvalue != UKPRN)
            {
                throw new Exception("UKPRN not returned in results");
            }
            return new SearchProviderNewPage(webDriver);
        }

        public SearchProviderNewPage GetProviderName(String ProviderName)
        {
            var Providervalue = webDriver.FindElement(FirstProvider).GetAttribute("textContent");
            Console.WriteLine(Providervalue);
            if (!Providervalue.ToLower().Contains(ProviderName.ToLower()))
            {
                throw new Exception("Provider not returned in results");
            }
            return new SearchProviderNewPage(webDriver);
        }

        public DfESignInPage ClickLoginLink()
        {
            FormCompletionHelper.ClickElement(LoginLink);
            PageInteractionHelper.WaitForPageToLoad();
            return new DfESignInPage(webDriver);
        }


        public ViewYourCoursesPage ClickViewCoursesButton()
        {
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(ViewCoursesButton, 60);
            FormCompletionHelper.ClickElement(ViewCoursesButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new ViewYourCoursesPage(webDriver);
        }

    }
}