using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Courses
{
    [Binding]
    public class ViewAllOppurtunitiesSteps: BaseClass 
    {
        [Given(@"I have accessed the course directory as a provider")]
        public void GivenIHaveAccessedTheCourseDirectoryAsAProvider()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
        }
        
        [Given(@"I have clicked the courses menu and selected View All oppurtunities")]
        public void GivenIHaveClickedTheCoursesMenuAndSelectedViewAllOppurtunities()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ClickCoursesMenu();
            CoursesPage.ClickViewAllOpportunities();
        }
        
        [Then(@"I should be able to view a list of all oppurtunities")]
        public void ThenIShouldBeAbleToViewAListOfAllOppurtunities()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ValidateAllOpportunities();
        }

        
    }
}
