using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;


namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class AddCourseSummaryPage : BasePage
    {

        private static String PAGE_TITLE = "Check and publish to the Course directory";
        private By acceptAndPublishBtn = By.Id("publish");

        public AddCourseSummaryPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public ViewYourCoursesPage ClickNext()
        {
            FormCompletionHelper.ClickElement(acceptAndPublishBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new ViewYourCoursesPage(webDriver);
        }

    }
}