using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Venue_Management;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class CourseSummaryPage : BasePage
    {

        private static String PAGE_TITLE = "";
        private By edit = By.XPath(".//*[@id='main-content']/div/div/main/div/div[1]/h3[1]/a");
        private By copy = By.XPath(".//*[@id='main-content']/div/div/main/div/div[2]/a[1]");
        private By delete = By.XPath(".//*[@id='archive-2f40e314-5b77-424c-9a0a-eb63ab2a7f9a']");

        public CourseSummaryPage(IWebDriver webDriver) : base(webDriver)
        {
           // SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public EditCoursePage2 ClickEditCourseRun()
        {
            FormCompletionHelper.ClickElement(edit);
            PageInteractionHelper.WaitForPageToLoad();
            return new EditCoursePage2(webDriver);
        }


    }
}