using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using OpenQA.Selenium.Interactions;

namespace UITesting.CourseDirectory.Pages.Courses
{
    public class CoursesPage:BasePage
    {
        /* Title Variables */
        public static String ALLVENUE_PAGE_TITLE = "View all Venues";
        public static String ADDVENUE_PAGE_TITLE = "Add New Venue";
        public static String ALLCOURSES_PAGE_TITLE = "View all Courses";
        public static String ADDCOURSE_PAGE_TITLE = "Add New Course";
        public static String ADDNEWOPP_PAGE_TITLE = "Add New Opportunity";
        public static String ALLOPPS_PAGE_TITLE = "View all Opportunities";
              
        /*Models Class Variables*/
        Models.Courses Courses = new Models.Courses();
        Models.Venue Venue = new Models.Venue();
        public CoursesPage(IWebDriver webDriver):base(webDriver)
        {
            
        }
                
        /* Common Functions*/

        internal void ClickCoursesMenu()
        {
            webDriver.FindElement(By.XPath(Courses.COURSE_MENU)).Click();            
        }
       
        internal void FindVenueName(string Venue_Name)
        {
            webDriver.FindElement(By.XPath(Venue.FILTER_VENUE_NAME)).SendKeys(Venue_Name);
            PageInteractionHelper.VerifyText(By.XPath(Venue.VENUE_TABLE_NAME_COL), Venue_Name);            
        }
        internal void ValidatePageSuccess(string strMessage)
        {            
            PageInteractionHelper.VerifyText(strMessage, MESSAGE);            
        }
       /*internal void ValidateTableData()
        {
        IWebElement VenueTable = webDriver.FindElement(By.XPath("//*[@id='DataTables_Table_0']"));
        List<IWebElement> tablerows = new List<IWebElement>(VenueTable.FindElements(By.TagName("tr")));

        foreach (IWebElement row in tablerows)
        {
           PageInteractionHelper.VerifyText(row.Text, Venue.ProviderId);

        }            
        }*/

        /* Venues related functions*/

        internal void ClickViewAllVenues()
        {
            webDriver.FindElement(By.XPath(Venue.ALL_VENUES_MENU)).Click();
        }
        internal void ValidateAllVenues()
        {
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath(Venue.VENUE_PAGE_TITLE_TEXT)).Text , ALLVENUE_PAGE_TITLE);
        }
        internal void ClickAddNewVenue()
        {            
            webDriver.FindElement(By.XPath(Venue.ADD_VENUE_MENU)).Click();
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath(Venue.ADD_VENUE_TITLE_TEXT)).Text, ADDVENUE_PAGE_TITLE);
         }
        internal void AddNewVenueData()
        {
            FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Venue.VENUE_ID)), Venue.ProviderId);            
            FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Venue.VENUE_NAME)), Venue.VenueName);
            FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Venue.VENUE_POSTCODE)), Venue.PostCode);
            webDriver.FindElement(By.XPath(Venue.FIND_ADDRESS)).Click();
            PageInteractionHelper.TurnOnSleep();
            FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(By.XPath(Venue.ADDRESS_DROPDOWN)), 2);            
            webDriver.FindElement(By.XPath(Venue.CREATE_VENUE_BUTTON)).Click();            
            ValidatePageSuccess(webDriver.FindElement(By.XPath(Venue.ADD_VENUE_SUCCESS_MSG)).Text);
        }
        internal void ClickEdit()
        {
            webDriver.FindElement(By.XPath(Venue.EDIT_LINK)).Click();
        }
        internal void UpdateVenue()
        {           
            webDriver.FindElement(By.XPath(Venue.SAVE_VENUE)).Click();
            ValidatePageSuccess(webDriver.FindElement(By.XPath(Venue.SAVE_VENUE_MESSAGE)).Text);
        }
        internal void UpdateValue(string Value)
        {
            if (Value=="Email")
            {
                webDriver.FindElement(By.XPath(Venue.VENUE_EMAIL)).Clear();
                webDriver.FindElement(By.XPath(Venue.VENUE_EMAIL)).SendKeys(RandomDataGenerator.GenerateRandomEmail());
            }
        }
        /*Courses Related Functions*/
        internal void ClickViewAllCourses()
         {
            webDriver.FindElement(By.XPath(Courses.ALL_COURSES)).Click();
         }
        internal void ValidateAllCourses()
        {
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath(Courses.ALL_COURSES_TITLE_TEXT)).Text,  ALLCOURSES_PAGE_TITLE);
        }
        internal void ClickAddNewCourse()
        {
            webDriver.FindElement(By.XPath(Courses.ADD_NEW_COURSE)).Click();            
        }
        internal void SelectNoLARSNumber()
        {
            
            // webDriver.FindElement(By.XPath(Courses.LARS_SCREEN)).Click();            
            
            PageInteractionHelper.TurnOnSleep();
            webDriver.FindElement(By.XPath(Courses.NO_LARS_RADIO)).Click();
            webDriver.FindElement(By.XPath(Courses.LARS_CONTINUE_BUTTON)).Click();
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath(Courses.ADD_NEW_COURSE_PAGE_TITLE_TEXT)).Text, ADDCOURSE_PAGE_TITLE);
        }
        internal void SelectLARSNumber()
        {
            // webDriver.FindElement(By.CssSelector(".modal"));
            PageInteractionHelper.TurnOnSleep();
            webDriver.FindElement(By.XPath(Courses.YES_LARS_RADIO)).Click();            
            FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.LARS_NUMBER_TEXT)), Courses.Course_LARS_No);
            PageInteractionHelper.TurnOnSleep();
            webDriver.FindElement(By.XPath(Courses.LARS_NUMBER_TEXT)).SendKeys(Keys.Down);
            webDriver.FindElement(By.XPath(Courses.LARS_NUMBER_TEXT)).SendKeys(Keys.Enter);
            webDriver.FindElement(By.XPath(Courses.LARS_CONTINUE_BUTTON)).Click();
        }
        internal void AddNewCourseData(string strLars)
        {            
            if (strLars == "No")
            {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_TITLE_TEXT)), Courses.Course_Title);
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_ID_TEXT)), Courses.Course_Id);
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_SUMMARY_TEXT)), Courses.Course_Summary);
                FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(By.XPath(Courses.COURSE_QUAL_TYPE_ID)), 5);
                FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(By.XPath(Courses.COURSE_QUAL_LEVEL)), 5);
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_URL)), Courses.Course_URL);
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_ENTRY_REQS)), Courses.Course_Entry);
            }
            else
            {
                AddNewCourseDataWithLARS();
            }
            webDriver.FindElement(By.XPath(Courses.CREATE_COURSE)).Click();
            ValidatePageSuccess(webDriver.FindElement(By.XPath(Courses.ADD_COURSE_SUCCESS_MSG)).Text);

        }
        private void AddNewCourseDataWithLARS()
        {
           if (string.IsNullOrEmpty(webDriver.FindElement(By.XPath(Courses.COURSE_TITLE_TEXT)).Text))
           {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_TITLE_TEXT)), Courses.Course_Title);
           }
           if (string.IsNullOrEmpty(webDriver.FindElement(By.XPath(Courses.COURSE_SUMMARY_TEXT)).Text))
           {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_SUMMARY_TEXT)), Courses.Course_Summary);
           }
           if((webDriver.FindElement(By.XPath(Courses.COURSE_QUAL_TYPE_ID)).Text != "Please Select")) 
           {
                FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(By.XPath(Courses.COURSE_QUAL_TYPE_ID)), 5);
           }
           if(string.IsNullOrEmpty(webDriver.FindElement(By.XPath(Courses.COURSE_URL)).Text))
           {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_URL)), Courses.Course_URL);
           }
           if(string.IsNullOrEmpty(webDriver.FindElement(By.XPath(Courses.COURSE_ENTRY_REQS)).Text))
           {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath(Courses.COURSE_ENTRY_REQS)), Courses.Course_Entry);
           } 
        }
        
        /*Oppurtunity Functions*/

        internal void ValidateAddNewOppurtunity()
        {
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath("/html/body/div[3]/h2")).Text, ADDNEWOPP_PAGE_TITLE);
        }
        internal void ClickViewAllOpportunities()
        {
            webDriver.FindElement(By.XPath("//a[@href='/Opportunity/List']")).Click();
        }
        internal void ValidateAllOpportunities()
        {
            
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath("/html/body/div[3]/h2")).Text, ALLOPPS_PAGE_TITLE);
        }
        internal void AddNewOpportunity()
        {
           // / html / body / div[3] / form / div / div[19] / div / input
        }
    }
}
