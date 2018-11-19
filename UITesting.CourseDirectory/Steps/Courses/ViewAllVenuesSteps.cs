using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Courses
{
    [Binding]
    public class ViewAllVenuesSteps : BaseClass 
    {
        [Given(@"I have looged into course directory")]
        public void GivenIHaveLoggedIntoCourseDirectory()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
        }
        
        [Given(@"I have clicked the courses menu and selected View All venues")]
        public void GivenIHaveClickedTheCoursesMenuAndSelectedViewAllVenues()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ClickCoursesMenu();
            CoursesPage.ClickViewAllVenues();
        }
        
        [Then(@"I should be able to view all venues for courses")]
        public void ThenIShouldBeAbleToViewAllVenuesForCourses()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ValidateAllVenues();
        }
    }
}
