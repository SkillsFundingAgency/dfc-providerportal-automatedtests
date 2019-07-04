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
        private static String PAGE_TITLE = "Fix errors";
        private By PublishBtn = By.Id("publish");
        private By FirstFixCourseLink = By.XPath(".//*[@id='course-fix-feefb502-f343-40ca-92b9-7909dfae0768']");
        private By FirstFixCourseRunLink = By.XPath(".//*[@id='course-run-fix-0d92ed05-d0be-4eda-9789-67418048a00f']");
        private By FirstFixCourseInstance = By.XPath(".//*[@class='error-link'][0]");
        private By FirstFixCourseRunInstance = By.XPath(".//*[@class='error-link fix'][0]");
        private By ExitLink = By.XPath(".//*[@id='PublishCourses']/div[1]/p[2]/a");
        private By BackLink = By.LinkText("Back");
        private By FixRadio = By.Id("OnScreen");
        private By ContinueBtn = By.Id("next");

        public BulkUploadFixPublishPage(IWebDriver webDriver) : base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(BackLink, 60);
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

        public BulkUploadFixPublishPage ClickFix()
        {
            FormCompletionHelper.ClickElement(FixRadio);
            return new BulkUploadFixPublishPage(webDriver);
        }

        public BulkUploadFixPublishPage ClickContinue()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            return new BulkUploadFixPublishPage(webDriver);
        }

    }
}