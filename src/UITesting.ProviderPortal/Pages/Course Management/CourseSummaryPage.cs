using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class CourseSummaryPage : BasePage
    {

        private static String PAGE_TITLE = "";
        private By edit = By.XPath(".//*[@id='main-content']/main/div/div[1]/h3[1]/a");         
        private By copy = By.XPath(".//*[@id='main-content']/main/div/div[2]/a[1]");
        private By delete = By.LinkText("Delete this course");
        private By deleteBtn = By.XPath("//*[@id='course-confirm- archive-c6481b98-505b-4379-ac95-54435502c929']");
        private By makeChanges = By.XPath(".//*[@id='main-content']/main/div/div[2]/a[5]");

        public CourseSummaryPage(IWebDriver webDriver) : base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
            //SelfVerify();
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

        public EditCoursePage ClickEditCourse()
        {
            FormCompletionHelper.ClickElement(makeChanges);
            PageInteractionHelper.WaitForPageToLoad();
            return new EditCoursePage(webDriver);
        }

        public CopyCoursePage ClickCopyCourse()
        {
            FormCompletionHelper.ClickElement(copy);
            PageInteractionHelper.WaitForPageToLoad();
            return new CopyCoursePage(webDriver);
        }

        public CourseSummaryPage ClickDeleteCourse()
        {
            FormCompletionHelper.ClickElement(delete);
            PageInteractionHelper.WaitForPageToLoad();
            return new CourseSummaryPage(webDriver);
        }

        public CourseSummaryPage ClickDeleteConfirm()
        {
            FormCompletionHelper.ClickElement(webDriver.FindElement(By.ClassName("govuk-button")));
            PageInteractionHelper.WaitForPageToLoad();
            return new CourseSummaryPage(webDriver);
        }
    }
}