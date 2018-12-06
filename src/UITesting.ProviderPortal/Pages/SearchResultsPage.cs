using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

/*namespace UITesting.ProviderPortal.Pages

{
    public class SearchResultsPage : BasePage
    {
        private static String PAGE_TITLE = "Search results for";

        public SearchResultsPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By dfeLink = By.LinkText("Department for Education");

        public DepartmentForEducationHomePage ClickDfeLink()
        {
            FormCompletionHelper.ClickElement(dfeLink);
            return new DepartmentForEducationHomePage(webDriver);
        }
    }
}*/