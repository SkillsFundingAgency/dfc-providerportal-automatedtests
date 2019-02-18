using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class EditCostSteps : BaseTest
    {
        [Given(@"I have logged to course directory")]
        public void GivenIHaveLoggedToCourseDirectory()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }
        
        [Given(@"I have searched for a UKPRN ""(.*)"" and clicked search")]
        public void GivenIHaveSearchedForAUKPRNAndClickedSearch(string ukPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(ukPRN);
            searchProviderPage.ClickSearchButton();
            
        }
        
        [Given(@"I have clicked View Courses button")]
        public void GivenIHaveClickedViewCoursesButton()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }
        
        [Given(@"I have clicked the Main Qualification Chevron")]
        public void GivenIHaveClickedTheMainQualificationChevron()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ClickQual();
        }
        
        [Given(@"I have clicked one of the courses available Chevron")]
        public void GivenIHaveClickedOneOfTheCoursesAvailableChevron()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ClickCourseName();
        }
        
        [Given(@"I have selected a course cost to update")]
        public void GivenIHaveSelectedACourseCostToUpdate()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCost();
        }
        
        [Given(@"I have updated the cost as ""(.*)""")]
        public void GivenIHaveUpdatedTheCostAs(string UpdCost)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.EnterNewCostValue(UpdCost);
        }
        
       /* [Given(@"I have updated the cost as ""(.*)""")]
        public void GivenIHaveUpdatedTheCostAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }*/
        
       /* [Given(@"I have updated the cost as ""(.*)""")]
        public void GivenIHaveUpdatedTheCostAs(int p0)
        {
            ScenarioContext.Current.Pending();
        }*/
        
        [Then(@"I should be able to view the course run details\.")]
        public void ThenIShouldBeAbleToViewTheCourseRunDetails_()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I'm able to view Save, Discard and Preview")]
        public void ThenIMAbleToViewSaveDiscardAndPreview()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateButtons();
        }
        
        [Then(@"I press save")]
        public void ThenIPressSave()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SaveCourseName();
        }
        
        [Then(@"the cost should be updated with (.*)")]
        public void ThenTheCostShouldBeUpdatedWith(string NewCost)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
          //  editYourCoursePage.ValidateSavedData(NewCost);
        }
        
        [Then(@"there should be an error message ""(.*)""")]
        public void ThenThereShouldBeAnErrorMessage(string errMsg)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateLengthMessage(errMsg);
        }
        
       /* [Then(@"the cost should be updated with decimal places as ""(.*)""")]
        public void ThenTheCostShouldBeUpdatedWithDecimalPlacesAs(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }*/
    }
}
