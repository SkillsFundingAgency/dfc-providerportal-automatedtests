using System;
using TechTalk.SpecFlow;
using UITesting.Framework.Helpers;

namespace UITesting.CourseDirectory.Steps
{
    [Binding]
    public class ViewApprenticeshipLocationsSteps : BaseClass 
    {
        [Given(@"I have logged into course directory")]
        public void GivenIHaveLoggedIntoCourseDirectory()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
            
        }
        
        [When(@"I press click the Apprenticeship menu and select View all locations")]
        public void WhenIPressClickTheApprenticeshipMenuAndSelectViewAllLocations()
        {

            Pages.Apprenticeships.ApprenticeshipsPage ApprenticeshipsPage = new Pages.Apprenticeships.ApprenticeshipsPage(webDriver);
            ApprenticeshipsPage.ClickApprenticeshipsMenu();
            ApprenticeshipsPage.ViewAllLocations();
            
        }
        
        [Then(@"I should be able to view the locations in a table format")]
        public void ThenIShouldBeAbleToViewTheLocationsInATableFormat()
        {
            Pages.Apprenticeships.ApprenticeshipsPage ApprenticeshipsPage = new Pages.Apprenticeships.ApprenticeshipsPage(webDriver);
            ApprenticeshipsPage.ValidateAllLocations();
        }
    }
}
