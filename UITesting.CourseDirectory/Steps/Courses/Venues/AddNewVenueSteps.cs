using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Courses.Venues
{
    [Binding]
    public class AddNewVenueSteps: BaseClass
    {
        Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
        Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
        Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
        [Given(@"I have logged onto Course Directory as a provider")]
        public void GivenIHaveLoggedOntoCourseDirectoryAsAProvider()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            LoginPage.LoginAsProvider();
        }
        
        [Given(@"I have accessed the Add Venue screen via course menu")]
        public void GivenIHaveAccessedTheAddVenueScreenViaCourseMenu()
        {
            CoursesPage.ClickCoursesMenu();
            CoursesPage.ClickAddNewVenue();
        }
        
        [Given(@"I have entered the required details to add a new venue and clicked create")]
        public void GivenIHaveEnteredTheRequiredDetailsToAddANewVenueAndClickedCreate()
        {
            CoursesPage.AddNewVenueData();
        }
        
        [Then(@"the new venue should be saved and visible on the All venues screen")]
        public void ThenTheNewVenueShouldBeSavedAndVisibleOnTheAllVenuesScreen()
        {
            CoursesPage.ValidateAllVenues();
        }
    }
}
