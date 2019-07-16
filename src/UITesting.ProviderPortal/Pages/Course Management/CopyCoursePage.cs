using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class CopyCoursePage : BasePage 
    {
        private static String PAGE_TITLE = "Copy course";
        private static By SaveButton = By.Id("save");
        private static By AddNewVenueLink = By.Id("addNewVenue");
        private static By Venue = By.Id("VenueId");
        private static By CourseNameText = By.Id("CourseName");
        private static By Classroom_DelMode = By.Id("ClassroomBased");
        private static By Online_DelMode = By.Id("Online");
        private static By WorkBased_DelMode = By.Id("WorkBased");
        private static By DefStartDate = By.Id("SpecifiedStartDate");
        private static By Day = By.Id("Day");
        private static By Month = By.Id("Month");
        private static By Year = By.Id("Year");

        public CopyCoursePage(IWebDriver  webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void ClickAddNewVenueLink()
        {
            FormCompletionHelper.ClickElement(AddNewVenueLink);
            PageInteractionHelper.WaitForPageToLoad();
        }

        internal void SelectVenueByName(string strVenueName)
        {
            FormCompletionHelper.SelectFromDropDownByText(webDriver.FindElement(Venue), strVenueName);
        }

        internal void EnterCourseName(string strCourseName)
        {
            FormCompletionHelper.EnterText(CourseNameText, strCourseName);
        }

        internal void SelectDeliveryMode(string strDelMode)
        {
            if (strDelMode == "Classroom")
            {
                FormCompletionHelper.ClickElement(Classroom_DelMode);
            }
            else if (strDelMode == "Online")
            {
                FormCompletionHelper.ClickElement(Online_DelMode);
            }
            else if (strDelMode == "Workbased")
            {
                FormCompletionHelper.ClickElement(WorkBased_DelMode);
            }
        }

        internal void SelectDefinedStartDate(object strDefStartDate)
        {
            FormCompletionHelper.ClickElement(DefStartDate);
        }

        internal void EnterStartDate(string strDay, string strMonth, string strYear)
        {
            FormCompletionHelper.EnterText(Day, strDay);
            FormCompletionHelper.EnterText(Month, strMonth);
            FormCompletionHelper.EnterText(Year, strYear);
        }

        internal void ClickSave()
        {
            FormCompletionHelper.ClickElement(SaveButton);
        }


    }
}
