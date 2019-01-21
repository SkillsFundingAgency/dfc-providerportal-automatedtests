using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class SearchProviderPage : BasePage
    {
        private static String PAGE_TITLE = "Search Provider";
        private By SearchField = By.Id("SearchTerm");
        private By SearchButton = By.Id("searchProvider");
        private By ViewCoursesButton = By.Id("btnShowCourses");



        public SearchProviderPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
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
            System.Threading.Thread.Sleep(2000);
            FormCompletionHelper.ClickElement(ViewCoursesButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new ViewYourCoursesPage(webDriver);
        }

    }
}