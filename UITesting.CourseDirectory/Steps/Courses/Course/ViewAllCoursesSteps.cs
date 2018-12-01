using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Courses
{
    [Binding]
    public class ViewAllCoursesSteps:BaseClass 
    {
        [Given(@"I have logged into course directory as a provider")]
        public void GivenIHaveLoggedIntoCourseDirectoryAsAProvider()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
        }
        
        [Given(@"I have clicked the courses menu and selected View All courses")]
        public void GivenIHaveClickedTheCoursesMenuAndSelectedViewAllCourses()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ClickCoursesMenu();
            CoursesPage.ClickViewAllCourses();
        }
        
        [Then(@"I should be able to view a list of all courses")]
        public void ThenIShouldBeAbleToViewAListOfAllCourses()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ValidateAllCourses();
        }
    }
}
