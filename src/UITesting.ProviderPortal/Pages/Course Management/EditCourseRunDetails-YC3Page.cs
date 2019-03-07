using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    
    public class EditCourseRunDetails_YC3Page : BasePage 
    {
        private static String PAGE_TITLE = "Edit course details";

        private static By CourseNameText=By.Id("CourseName");
        private static By Classroom_DelMode = By.Id("ClassroomBased");
        private static By Online_DelMode = By.Id("Online");
        private static By WorkBased_DelMode = By.Id("WorkBased");
        private static By DefStartDate = By.Id("SpecifiedStartDate");
        private static By Day = By.Id("Day");
        private static By Month = By.Id("Month");       

        private static By Year = By.Id("Year");
        private static By Venue = By.Id("VenueId");
        private static By URL = By.Id("Url");
        private static By Cost = By.Id("Cost");
        private static By CostDesc = By.Id("CostDescription");
        private static By DurLength = By.Id("DurationLength");      

        private static By DurUnit = By.Id("DurationUnit");
        private static By Fulltime = By.Id("FullTime");
        private static By Parttime = By.Id("PartTime");
        private static By Flexible = By.Id("Flexible");
        private static By Daytime = By.Id("Daytime");
        private static By Evening = By.Id("Evening");
        private static By Weekend = By.Id("Weekend");
        private static By DayBlock = By.Id("DayorBlockRelease");

        private static By Save = By.Id("save");
        private static By Cancel = By.LinkText("Cancel");

        private static By CourseNameErrMsg = By.XPath("//*[@id='courseNameContainer']/span[2]");
        private static By InvalidDateMsg = By.XPath("//*[@id='startDateFormGroup']/span");
        private static By InvalidURLMsg = By.XPath("//*[@id='sectionUrl']/div/span[2]");
        private static By CostErrMsg = By.XPath("//*[@id='costContainer']/span[3]");
        private static By DurationErrMsg = By.Id("//*[@id='sectionDuration']/div/span[2]");


        public EditCourseRunDetails_YC3Page(IWebDriver webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
        internal void EnterCourseName(string strCourseName)
        {
            FormCompletionHelper.EnterText(CourseNameText,strCourseName);
        }
        internal void SelectDeliveryMode(string strDelMode)
        {
            FormCompletionHelper.SelectRadioOptionByForValue
        }
    }
}
