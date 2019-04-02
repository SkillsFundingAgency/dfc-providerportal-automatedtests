using System;
using System.Threading;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.Pages.Bulk_Upload
{
    public class BulkUploadFixPublishPage : BasePage
    {
        private static String PAGE_TITLE = "Fix errors and publish";
        private By PublishBtn = By.Id("publish");
        private By FirstFixCourseLink = By.XPath(".//*[@id='course-fix-157f5d3a-ee75-44ba-9922-15fe8afdb602']");
        private By FirstFixCourseRunLink = By.XPath(".//*[@id='course-run-fix-b7c614aa-f6b3-40b0-a41c-33f00a0da298']");
        private By FirstFixCourseInstance = By.XPath(".//*[@class='error-link'][0]");
        private By FirstFixCourseRunInstance = By.XPath(".//*[@class='error-link fix'][0]");

        public BulkUploadFixPublishPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public BulkUploadFixPublishPage Publish()
        {
            FormCompletionHelper.ClickElement(PublishBtn);
            return new BulkUploadFixPublishPage(webDriver);
        }

        public EditCoursePage FixCourse()
        {
            FormCompletionHelper.ClickElement(FirstFixCourseLink);
            return new EditCoursePage(webDriver);
        }

        public EditCoursePage FixCourseSave()
        {
            FormCompletionHelper.ClickElement(FirstFixCourseInstance);
            return new EditCoursePage(webDriver);
        }

        public EditCoursePage2 FixCourseRun()
        {
            FormCompletionHelper.ClickElement(FirstFixCourseRunLink);
            return new EditCoursePage2 (webDriver);
        }

        public EditCoursePage2 FixCourseRunSave()
        {
            FormCompletionHelper.ClickElement(FirstFixCourseRunInstance);
            return new EditCoursePage2(webDriver);
        }

    }
}