using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Features.Apprenticeships
{
    [Binding]
    public class AddApprenticeshipNewLocationSteps: BaseClass 
    {
        Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
        Pages.Apprenticeships.ApprenticeshipsPage ApprenticeshipsPage = new Pages.Apprenticeships.ApprenticeshipsPage(webDriver);

        [Given(@"I have accessed and logged into course directory")]
        public void GivenIHaveAccessedAndLoggedIntoCourseDirectory()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            LoginPage.LoginAsProvider();
        }

        [Given(@"I have clicked on Apprenticeships Menu and selected Add new Location")]
        public void GivenIHaveClickedOnApprenticeshipsMenuAndSelectedAddNewLocation()
        {
            ApprenticeshipsPage.ClickApprenticeshipsMenu();
            ApprenticeshipsPage.SelectAddNewLocation();
        }
    
        
        [Then(@"the Add new Location screen should be displayed\.")]
        public void ThenTheAddNewLocationScreenShouldBeDisplayed_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I have entered the required details and clicked Create")]
        public void ThenIHaveEnteredTheRequiredDetailsAndClickedCreate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a new location should be created")]
        public void ThenANewLocationShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the location should be listed in the View All Locations page")]
        public void ThenTheLocationShouldBeListedInTheViewAllLocationsPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
