using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Courses.Venues
{
    [Binding]
    public class EditVenue_VenueFoundSteps : BaseClass 
    {
        Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
        Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
        Pages.Courses.CoursesPage CoursesPage = new Pages.Courses.CoursesPage(webDriver);
        [Given(@"I have logged into course directory using Provider Login")]
        public void GivenIHaveLoggedIntoCourseDirectoryUsingProviderLogin()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            LoginPage.LoginAsProvider();
        }        
        [Given(@"I have accessed all venues via courses menu")]
        public void GivenIHaveAccessedAllVenuesViaCoursesMenu()
        {
            CoursesPage.ClickCoursesMenu();
            CoursesPage.ClickViewAllVenues();
        }
        
        [Given(@"I want to Search for ""(.*)""")]
        public void GivenIWantToSearchFor(string Prov_Name)
        {
            CoursesPage.FindProvider(Prov_Name);
        }
        
        [Given(@"I have found the Venue and clicked Edit")]
        public void GivenIHaveFoundTheVenueAndClickedEdit()
        {
            CoursesPage.ClickEdit();
        }
        
        [Then(@"I want to add an email to the venue and click Save")]
        public void ThenIWantToAddAnEmailToTheVenueAndClickSave()
        {
            CoursesPage.UpdateValue("Email");
            CoursesPage.UpdateVenue();
        }
        
        [Then(@"the venue should be updated with the email\.")]
        public void ThenTheVenueShouldBeUpdatedWithTheEmail_()
        {
            CoursesPage.ValidateAllVenues();
        }
    }
}
