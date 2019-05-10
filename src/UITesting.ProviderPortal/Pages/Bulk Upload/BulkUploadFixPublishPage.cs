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
        private By FirstFixCourseLink = By.XPath(".//*[@id='course-fix-691e52ab-063c-42cb-a227-2119fbc727c7']");
        private By FirstFixCourseRunLink = By.XPath(".//*[@id='course-run-fix-da673d5a-bb0d-43a9-9cde-770680595312']");
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