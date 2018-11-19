using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.CourseDirectory.Pages.Courses
{
    public class CoursesPage:BasePage
    {
        public static String ALLVENUE_PAGE_TITLE = "View all Venues";
        public static String ADDVENUE_PAGE_TITLE = "Add New Venue";
        public static String ALLCOURSES_PAGE_TITLE = "View all Courses";
        public static String ADDCOURSE_PAGE_TITLE = "Add New Course";
        public static String ADDNEWOPP_PAGE_TITLE = "Add New Opportunity";
        Models.Courses Courses = new Models.Courses();

        public CoursesPage(IWebDriver webDriver):base(webDriver)
        {

        }
        /* Common Functions*/

        internal void ClickCoursesMenu()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div/ul/li[4]/a")).Click();
            
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
            webDriver.FindElement(By.XPath("//a[@href='/Venue/List']")).Click();
        }
        internal void ValidateAllVenues()
        {
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/h2")).Text, ALLVENUE_PAGE_TITLE);
         }
        internal void ClickAddNewVenue()
        {
            webDriver.FindElement(By.XPath("//a[@href='/Venue/Create']")).Click();
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath("/html/body/div[3]/h2")).Text, ADDVENUE_PAGE_TITLE);
        }
        internal void AddNewVenueData()
        {
            Models.Venue Venue = new Models.Venue();
            FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath ("//*[@id='ProviderOwnVenueRef']")),Venue.ProviderId);
            FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='VenueName']")), Venue.VenueName);
            FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='Address_Postcode']")), Venue.PostCode);
            webDriver.FindElement(By.XPath("//*[@id='aFindAddress']")).Click();
            FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(By.XPath("//*[@id='ddlChooseAddress']")), 2);
            webDriver.FindElement(By.XPath("/html/body/div[3]/form/div/div[16]/div/input")).Click();
            ValidatePageSuccess(webDriver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/div")).Text);
        }

        /*Courses Related Functions*/
         internal void ClickViewAllCourses()
         {
            webDriver.FindElement(By.XPath("//a[@href='/Course/List']")).Click();
         }
        internal void ValidateAllCourses()
        {
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath("/html/body/div[3]/h2")).Text,  ALLCOURSES_PAGE_TITLE);
        }
        internal void ClickAddNewCourse()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div/ul/li[4]/ul/li[4]/a")).Click();
            
        }
        internal void SelectNoLARSNumber()
        {

            webDriver.FindElement(By.XPath("/ html / body / div[7] / div / div / div[1] / div")).Click();
            webDriver.FindElement(By.XPath("//*[@id='radLARNo']")).Click();
            webDriver.FindElement(By.XPath("//*[contains(@class, 'btn-success')]")).Click();
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath("/html/body/div[3]/h2")).Text, ADDCOURSE_PAGE_TITLE);
        }
        internal void SelectLARSNumber()
        {

            webDriver.FindElement(By.XPath("/ html / body / div[7] / div / div / div[1] / div")).Click();
            webDriver.FindElement(By.XPath("//*[@id='radLARYes']")).Click();
            FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='divAddCourse2']/div[2]/span/input[2]")), Courses.Course_LARS_No);
            webDriver.FindElement(By.XPath("//*[@id='divAddCourse2']/div[2]/span/input[2]")).SendKeys(Keys.Down);
            webDriver.FindElement(By.XPath("//*[@id='divAddCourse2']/div[2]/span/input[2]")).SendKeys(Keys.Enter);
            webDriver.FindElement(By.XPath("//*[contains(@class, 'btn-success')]")).Click();
        }
        internal void AddNewCourseData(string strLars)
        {            
            if (strLars == "No")
            {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='CourseTitle']")), Courses.Course_Title);
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='ProviderOwnCourseRef']")), Courses.Course_Id);
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='CourseSummary']")), Courses.Course_Summary);
                FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(By.XPath("//*[@id='QualificationTypeId']")), 5);
                FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(By.XPath("//*[@id='QualificationLevelId']")), 5);
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='Url']")), Courses.Course_URL);
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='EntryRequirements']")), Courses.Course_Entry);
            }
            else
            {
                ValidateNewCourseData();
            }
            webDriver.FindElement(By.XPath("/html/body/div[3]/form/div/div[19]/div/input")).Click();
            ValidatePageSuccess(webDriver.FindElement(By.XPath("/html/body/div[3]/div")).Text);
        }
        private void ValidateNewCourseData()
        {
           if (string.IsNullOrEmpty(webDriver.FindElement(By.XPath("//*[@id='CourseTitle']")).Text))
           {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='CourseTitle']")), Courses.Course_Title);
           }
           if (string.IsNullOrEmpty(webDriver.FindElement(By.XPath("//*[@id='CourseSummary']")).Text))
           {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='CourseSummary']")), Courses.Course_Summary);
           }
           if((webDriver.FindElement(By.XPath("//*[@id='QualificationTypeId']")).Text != "Please Select")) 
           {
                FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(By.XPath("//*[@id='QualificationTypeId']")), 5);
           }
           if(string.IsNullOrEmpty(webDriver.FindElement(By.XPath("//*[@id='Url']")).Text))
           {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='Url']")), Courses.Course_URL);
           }
           if(string.IsNullOrEmpty(webDriver.FindElement(By.XPath("//*[@id='EntryRequirements']")).Text))
           {
                FormCompletionHelper.EnterText(webDriver.FindElement(By.XPath("//*[@id='EntryRequirements']")), Courses.Course_Entry);
           } 
        }
        
        /*Oppurtunity Functions*/

        internal void ValidateAddNewOppurtunity()
        {
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath("/html/body/div[3]/h2")).Text, ADDNEWOPP_PAGE_TITLE);
        }
          
    }
}
