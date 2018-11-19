using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Courses
{
    [Binding]
    public class AddNewCourseWithLARSNumberSteps: BaseClass 
    {
        [Given(@"I have accessed course directory as a provider")]
        public void GivenIHaveAccessedCourseDirectoryAsAProvider()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
        }
        
        [Given(@"I have accessed add new course via course menu and entered a LARS Number")]
        public void GivenIHaveAccessedAddNewCourseViaCourseMenuAndEnteredALARSNumber()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ClickCoursesMenu();
            CoursesPage.ClickAddNewCourse();
           
        }
        
        [Then(@"details of the course should be displayed in the fields")]
        public void ThenDetailsOfTheCourseShouldBeDisplayedInTheFields()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.SelectLARSNumber();
            CoursesPage.AddNewCourseData("Yes");
        }
        
        [Then(@"the new course should be added when I click Save")]
        public void ThenTheNewCourseShouldBeAddedWhenIClickSave()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ValidateAddNewOppurtunity();
        }
    }
}
