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
        private static String PAGE_TITLE = "Your published courses";

        /* DFC-4827-variables-Usman*/        

        private static By QualChevron = By.XPath("//*[@id='main-content']/div/div/div[*]/div/div/h2");
        private static By CourseChevron = By.XPath("//*[@id='main-content']/div/div/div[*]/div[1]/div/div/h3");
        private static By SaveButton = By.Id("save-button");
        private static By DiscardLink = By.LinkText("Discard");
        private static By PreviewLink = By.LinkText("Preview");
        // private static By Course = By.Id("accordion-heading-1");
        private static By Course = By.ClassName("govuk-accordion__open-all");
        //private static By CourseRunEditLink = By.XPath(".//*[@id='28120057-e6c7-4c77-8944-d923ace9a49b']/div[3]/a[1]");
        private static By CourseRunEditLink = By.LinkText("Edit");
        private static By CourseRunNameText = By.XPath(".//*[@id='28120057-e6c7-4c77-8944-d923ace9a49b']/div[1]/span");   
        private static By CourseNameErrMessage = By.Id("courseRun_CourseName-error");
        private static By CourseRunVenueField = By.XPath(".//*[@id='28120057-e6c7-4c77-8944-d923ace9a49b']/div[2]/span");
        private static By CourseRunURLField = By.XPath(".//*[@id='28120057-e6c7-4c77-8944-d923ace9a49b']/div[2]/span");

        private static By CourseRunSelect10032433 = By.XPath(".//*[@id='results']/div[2]/div/div[3]/a");
        private static By CourseRunSelect10037096 = By.XPath(".//*[@id='results']/div[2]/div/div[4]/a");
        private By successMsg = By.XPath(".//*[@id='main-content']/div/div/div[1]/h1");
        private By SearchText = By.Id("Search");

        /*End DFC-4827-variables*/

        /*DFC-4832-variables-Usman*/
        private static By CostText = By.Id("cost");
        private static By InvLengthMessage = By.Id("invalidCostLengthMessage");


        public EditYourCoursePage(IWebDriver webDriver):base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(SearchText, 60);
            if (!PageInteractionHelper.IsElementPresent(successMsg))
            {
                SelfVerify();
            }
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public void ClickQual()
        {
            PageInteractionHelper.OpenAccordians(QualChevron);           
            
        }
        public void ClickCourseName()
        {
            PageInteractionHelper.OpenAccordians(CourseChevron);           
        }

        public void SelectCourse()
        {
            PageInteractionHelper.WaitForPageToLoad();
            if (FormCompletionHelper.IsElementPresent(CourseRunSelect10032433))
            {
                FormCompletionHelper.ClickElement(CourseRunSelect10032433);
            }
            else
            {
                FormCompletionHelper.ClickElement(CourseRunSelect10037096);
            }
            PageInteractionHelper.WaitForPageToLoad();
        }

        internal void EditCourseRun()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(CourseRunEditLink);
            PageInteractionHelper.WaitForPageToLoad();
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

        internal void SelectCost()
        {
            FormCompletionHelper.ClickElement(CostText);
        }

        internal void EnterNewCostValue(string updCost)
        {
            FormCompletionHelper.EnterText(CostText, updCost);
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

        internal void VerifyUpdate(string updatedfield, string updatedValue)
        {
            switch (updatedfield)
            {
                case "course name":
                    PageInteractionHelper.VerifyText(CourseRunNameText, updatedValue);
                    break;

                case "venue name":
                    PageInteractionHelper.VerifyText(CourseRunVenueField, updatedValue);
                    break;

                case "URL":
                    PageInteractionHelper.VerifyText(CourseRunURLField, updatedValue);
                    break;
                default:
                    throw new Exception("Field does not exist");
            }        

        }

        internal void ValidateSavedVenue(string venueName)
        {
            FormCompletionHelper.VerifyDropdownDefaultValue(CourseRunVenueField, venueName);
//            PageInteractionHelper.VerifyCourseRunValue(CourseRunVenueField, venueName);
        }

        internal void ValidateLengthMessage(string errMessage)
        {
            PageInteractionHelper.VerifyText(InvLengthMessage, errMessage);
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
