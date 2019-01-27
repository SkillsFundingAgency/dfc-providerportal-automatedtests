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
        private static By CourseRunVenueField = By.Id("courseRun_VenueId");
        


        /*End DFC-4827-variables*/


        public EditYourCoursePage(IWebDriver webDriver):base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void ClickQual()
        {
            PageInteractionHelper.OpenAccordians(QualChevron);           
            
        }
        internal void ClickCourseName()
        {
            PageInteractionHelper.OpenAccordians(CourseChevron);           
        }
        internal void SelectCourseRunName()
        {

            FormCompletionHelper.ClickElement(CourseRunNameText);
        }

        internal void ChangeCourseName(string newCourseRunName)
        {
            FormCompletionHelper.EnterText(CourseRunNameText, newCourseRunName);           
            
        }

        internal void SaveCourseName()
        {
            FormCompletionHelper.ClickElement(SaveButton);
        }

        internal void ValidateButtons()
        {
            PageInteractionHelper.WaitForPageToLoad();
            PageInteractionHelper.VerifyElementPresent(SaveButton);
            PageInteractionHelper.VerifyElementPresent(DiscardLink);
            PageInteractionHelper.VerifyElementPresent(PreviewLink);
        }

        internal void ValidateSavedData(string newCourseName)
        {
            PageInteractionHelper.OpenAccordians(QualChevron);
            PageInteractionHelper.OpenAccordians(CourseChevron);
            PageInteractionHelper.VerifyCourseRunValue(CourseRunNameText, newCourseName);
            
        }

        internal void ValidateSavedVenue(string venueName)
        {
            FormCompletionHelper.VerifyDropdownDefaultValue(CourseRunVenueField, venueName);
//            PageInteractionHelper.VerifyCourseRunValue(CourseRunVenueField, venueName);
        }


        internal void ValidateErrorMessage(string errMessage)
        {
            PageInteractionHelper.VerifyText(CourseNameErrMessage, errMessage);
            
        }

        internal void ValidateSpacesData(string newCourseName)
        {
            PageInteractionHelper.OpenAccordians(QualChevron);
            PageInteractionHelper.OpenAccordians(CourseChevron);
            PageInteractionHelper.VerifyCourseRunValue(CourseRunNameText, newCourseName);
        }

        internal void ChangeVenueName(string venueName)
        {
            FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(CourseRunVenueField), 1);

            switch (venueName)
            {
                case "Farnham Sixth Form College":
                    FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(CourseRunVenueField), 1);
                    break;

                case "Show_Tell":
                    FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(CourseRunVenueField), 4);
                    break;

                default:
                    throw new Exception("Option not available");
            }

        }

    }

}
