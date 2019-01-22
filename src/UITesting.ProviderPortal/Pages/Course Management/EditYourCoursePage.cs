using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using OpenQA.Selenium;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class EditYourCoursePage: BasePage
    {
        private static String PAGE_TITLE = "Your courses";

        /* DFC-4827-variables-Usman*/        

        private static By QualChevron = By.XPath("//*[@id='main-content']/div/div/div[*]/div/div/h2");
        private static By CourseChevron = By.XPath("//*[@id='main-content']/div/div/div[*]/div[1]/div/div/h3");
        private static By SaveButton = By.Id("save-button");
        private static By DiscardLink = By.LinkText("Discard");
        private static By PreviewLink = By.LinkText("Preview");
        private static By CourseRunNameText = By.Id("courseRun_CourseName");        
        private static By CourseNameErrMessage = By.Id("courseRun_CourseName-error");

        /*End DFC-4827-variables*/


        public EditYourCoursePage(IWebDriver webDriver):base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void SearchQual(string qualName)
        {
            //PageInteractionHelper.OpenAccordians(QualChevron);
            PageInteractionHelper.VerifyAccordianText(QualChevron, qualName);
            
        }

        internal void SearchCourseName(string courseName)
        {
            //PageInteractionHelper.OpenAccordians(CourseChevron);
            PageInteractionHelper.VerifyAccordianText(CourseChevron, courseName);
        }

        internal void SelectCourseRunName(string oldCourseRunName)
        {
            
            //PageInteractionHelper.VerifyText(CourseRunNameText, oldCourseRunName);
            PageInteractionHelper.VerifyCourseRunValue(CourseRunNameText, oldCourseRunName);
        }

        internal void ChangeCourseName(string oldCourseRunName, string newCourseRunName)
        {
            //FormCompletionHelper.EnterText(CourseRunNameText, oldCourseRunName,  newCourseRunName);
        }

        internal void SaveCourseName()
        {
            FormCompletionHelper.ClickElement(SaveButton);
        }

        internal void ValidateButtons()
        {
            PageInteractionHelper.VerifyElementPresent(SaveButton);
            PageInteractionHelper.VerifyElementPresent(DiscardLink);
            PageInteractionHelper.VerifyElementPresent(PreviewLink);
        }

        internal void ValidateSavedData(string newCourseName)
        {
            throw new NotImplementedException();
        }

        internal void ValidateErrorMessage(string errMessage)
        {
            PageInteractionHelper.VerifyText(CourseNameErrMessage, errMessage);
        }

        internal void ValidateSpacesData(string newCourseName)
        {
            throw new NotImplementedException();
        }
    }
}
