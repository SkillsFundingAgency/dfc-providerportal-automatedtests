using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Venue_Management;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class AddCourseSummaryPage : BasePage
    {

        private static String PAGE_TITLE = "Check your answers before publishing your course";
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
            //return new AddCourseSummaryPage(webDriver);
            return new ViewYourCoursesPage(webDriver);
        }


    }
}