using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class SearchProviderPage : BasePage
    {
        //private static String PAGE_TITLE = "Search Provider";
        private static String PAGE_TITLE = "Find a course or training provider";
        private By SearchField = By.Id("SearchTerm");
        private By SearchButton = By.Id("searchProvider");
        private By ViewCoursesButton = By.Id("btnQualificationList");
        private By LoginLink = By.LinkText("Login");



        public SearchProviderPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(SearchButton, 60);
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public SearchProviderPage EnterUKPRN(String UKPRN)
        {
            FormCompletionHelper.EnterText(SearchField, UKPRN);
            return new SearchProviderPage(webDriver);
        }

        public SearchProviderPage ClickSearchButton()
        {
            FormCompletionHelper.ClickElement(SearchButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new SearchProviderPage(webDriver);
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