using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages;

namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class SearchProviderPage : BasePage
    {
        private static String PAGE_TITLE = "Search Provider";
        private By SearchField = By.Id("SearchTerm");
        private By SearchButton = By.Id("searchProvider");
        private By ViewCoursesButton = By.Id("btnShowCourses");
        private By LoginLink = By.LinkText("Login");


        public SearchProviderPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
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
            return new SearchProviderPage(webDriver);
        }

        public ViewYourCoursesPage ClickViewCoursesButton()
        {
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(ViewCoursesButton, 10);
            FormCompletionHelper.ClickElement(ViewCoursesButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new ViewYourCoursesPage(webDriver);
        }

        public DfESignInPage ClickLoginLink()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(LoginLink);
            return new DfESignInPage(webDriver);
        }


    }
}