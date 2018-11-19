using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Courses
{
    [Binding]
    public class AddNewCourseWithNoLARSNumberSteps : BaseClass 
    {
        [Given(@"I logged into course directory as a provider")]
        public void GivenILoggedIntoCourseDirectoryAsAProvider()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
        }
        [Given(@"I have accessed add new course via course menu")]
        public void GivenIHaveAccessedAddNewCourseViaCourseMenu()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ClickCoursesMenu();
            CoursesPage.ClickAddNewCourse();
            
        }
        
        [When(@"I enter the required details")]
        public void WhenIEnterTheRequiredDetails()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.SelectNoLARSNumber();
            CoursesPage.AddNewCourseData("No");
            CoursesPage.ValidateAddNewOppurtunity();
            
        }
        
        [Then(@"the new course should be added")]
        public void ThenTheNewCourseShouldBeAdded()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
        }
    }
}
