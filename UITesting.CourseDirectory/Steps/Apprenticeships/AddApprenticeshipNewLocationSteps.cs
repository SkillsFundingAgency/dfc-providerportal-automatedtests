using System;
using TechTalk.SpecFlow;

namespace UITesting.CourseDirectory.Steps.Apprenticeships
{
    [Binding]
    public class AddApprenticeshipNewLocationSteps : BaseClass 
    {
        [Given(@"I have accessed and logged into course directory")]
        public void GivenIHaveAccessedAndLoggedIntoCourseDirectory()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
        }
        
        [Given(@"I have clicked on Apprenticeships Menu and selected Add new Location")]
        public void GivenIHaveClickedOnApprenticeshipsMenuAndSelectedAddNewLocation()
        {
            Pages.Apprenticeships.ApprenticeshipsPage ApprenticeshipsPage = new Pages.Apprenticeships.ApprenticeshipsPage(webDriver);
            ApprenticeshipsPage.ClickApprenticeshipsMenu();
            ApprenticeshipsPage.SelectAddNewLocation();
        }
        
        [Then(@"the Add new Location screen should be displayed\.")]
        public void ThenTheAddNewLocationScreenShouldBeDisplayed_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
