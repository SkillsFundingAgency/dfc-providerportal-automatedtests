
using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Courses
{
    [Binding]
    public class AddNewVenueSteps: BaseClass 
    {
        [Given(@"I logged into course directory as a provider")]
        public void GivenILoggedIntoCourseDirectoryAsAProvider()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
        }
        
        [Given(@"I have accessed add a new venue screen via courses menu")]
        public void GivenIHaveAccessedAddANewVenueScreenViaCoursesMenu()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.ClickCoursesMenu();
            CoursesPage.ClickAddNewVenue();

        }
        
        [Given(@"I have entered the required values and clicked Create")]
        public void GivenIHaveEnteredTheRequiredValuesAndClickedCreate()
        {
            Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
            CoursesPage.AddNewVenueData();
        }
        
        [Then(@"the new venue should be created")]
        public void ThenTheNewVenueShouldBeCreated()
        {
            Pages.Courses.CoursesPage coursesPage = new Pages.Courses.CoursesPage(webDriver);
            coursesPage.ValidateAllVenues();
            
            
        }
        
        [Then(@"the venue should be listed in the All venues screen")]
        public void ThenTheVenueShouldBeListedInTheAllVenuesScreen()
        {
            Pages.Courses.CoursesPage coursesPage = new Pages.Courses.CoursesPage(webDriver);
            //coursesPage.ValidateTableData(); 
        }
    }
}
