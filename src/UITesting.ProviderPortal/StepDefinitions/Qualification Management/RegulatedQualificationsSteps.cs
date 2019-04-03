using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.ProviderPortal.Pages.Qualification_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Qualification_Management
{
    [Binding]
    public class RegulatedQualificationsSteps : BaseTest 
    {
        [Given(@"I have accessed the Regulated Qualifications page")]
        public void GivenIHaveAccessedTheRegulatedQualificationsPage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl() +"/RegulatedQualification";
        }
        
        [When(@"I Navigate to Regulated Qualifications page")]
        public void WhenINavigateToRegulatedQualificationsPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the Regulated Option")]
        public void WhenISelectTheRegulatedOption()
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
            regulatedQualificationPage.SelectRegulatedOption();
        }
        
        [When(@"I click Next")]
        public void WhenIClickNext()
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
            regulatedQualificationPage.ClickNext();
        }
        
        [When(@"I select the Non Regulated Option")]
        public void WhenISelectTheNonRegulatedOption()
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
            regulatedQualificationPage.SelectNonRegulatedOption();
        }
        
        [When(@"no option is selected")]
        public void WhenNoOptionIsSelected()
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
            regulatedQualificationPage.CheckNoOptionSelected();
        }
        
        [Then(@"I need to view Regulated ""(.*)"", ""(.*)"" Option and a Next Button")]
        public void ThenINeedToViewRegulatedOptionAndANextButton(string strRegOption, string strNonRegOption)
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
            regulatedQualificationPage.CheckOption(strRegOption);
            regulatedQualificationPage.CheckOption(strNonRegOption);
            regulatedQualificationPage.CheckNextButton();
        }
        
        [Then(@"Lars Search page should be displayed")]
        public void ThenLarsSearchPageShouldBeDisplayed()
        {
            SearchforQualificationPage searchforQualificationPage = new SearchforQualificationPage(webDriver);
        }
        
        [Then(@"Unregulated Courses page should be displayed")]
        public void ThenUnregulatedCoursesPageShouldBeDisplayed()
        {
            NonRegulatedProvisionPage nonRegulatedProvisionPage = new NonRegulatedProvisionPage(webDriver);
        }
        
       
        [Then(@"an Error message should be displayed ""(.*)""")]
        public void ThenAnErrorMessageShouldBeDisplayed(string ErrMsg)
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
            regulatedQualificationPage.ValidateErrorMessage(ErrMsg);
        }

    }
}
