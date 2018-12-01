using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.CourseDirectory.Models
{
    public class Courses
    {


        
        /*Web Element Variables*/
        public string COURSE_MENU = "/html/body/div[2]/div[2]/div[3]/div/ul/li[4]/a";
        public string ALL_COURSES = "//a[@href='/Course/List']";
        public string ALL_COURSES_TITLE_TEXT = "/html/body/div[3]/h2";
        public string ADD_NEW_COURSE = "/html/body/div[2]/div[2]/div[3]/div/ul/li[4]/ul/li[4]/a";
        public string COURSE_TITLE_TEXT = "//*[@id='CourseTitle']";
        public string COURSE_ID_TEXT = "//*[@id='ProviderOwnCourseRef']";
        public string COURSE_SUMMARY_TEXT = "//*[@id='CourseSummary']";
        public string COURSE_QUAL_TYPE_ID = "//*[@id='QualificationTypeId']";
        public string COURSE_QUAL_LEVEL = "//*[@id='QualificationLevelId']";
        public string COURSE_URL = "//*[@id='Url']";
        public string COURSE_ENTRY_REQS = "//*[@id='EntryRequirements']";
        public string CREATE_COURSE = "/html/body/div[3]/form/div/div[19]/div/input";
        public string ADD_COURSE_SUCCESS_MSG = "/html/body/div[3]/div";
        public string NO_LARS_RADIO= "//*[@id='radLARNo']";
        public string YES_LARS_RADIO = "//*[@id='radLARYes']";
        public string LARS_CONTINUE_BUTTON = "//*[contains(@class, 'btn-success')]";
        public string ADD_NEW_COURSE_PAGE_TITLE_TEXT = "/html/body/div[3]/h2";
        public string LARS_NUMBER_TEXT = "//*[@id='divAddCourse2']/div[2]/span/input[2]";
        public string LARS_SCREEN = "/html/body/div[7]/div/div/div[1]/div";


        public string Course_Title = "Selenium Fundamentals";
        public string Course_Id = RandomDataGenerator.GenerateRandomNumber(5);
        public string Course_Summary = "Basic Selenium";
        //public string Course_URL = RandomDataGenerator.GenerateRandomWebsiteString();
        public string Course_URL = "www.gov.uk";
        public string Course_Entry = "A-Level";
        public int Course_LARS_No = 60094321;
    }
}
