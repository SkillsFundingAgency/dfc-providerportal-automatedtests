using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.ProviderPortal.Pages.Data_Quality_Indicators;
using UITesting.ProviderPortal.Pages;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class SearchonYourCoursesSteps : BaseTest 
    {
        [Given(@"I have entered a search  term as ""(.*)""")]
        public void GivenIHaveEnteredASearchTermAs(string strSearch)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.EnterSearchTerm(strSearch);
        }
        

        [Given(@"I have entered a part search term as ""(.*)""")]
        public void GivenIHaveEnteredAPartSearchTermAs(string strSearch)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.EnterSearchTerm(strSearch);
        }
        [Given(@"I have entered a full search term as ""(.*)""")]
        public void GivenIHaveEnteredAFullSearchTermAs(string strSearch)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.EnterSearchTerm(strSearch);
        }


        /* [Given(@"I have entered a search term as ""(.*)""")]
         public void GivenIHaveEnteredASearchTermAs(string p0)
         {
             ScenarioContext.Current.Pending();
         }*/

        [Given(@"I have entered a LARS number in search ""(.*)""")]
        public void GivenIHaveEnteredALARSNumberInSearch(string strLars)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.EnterSearchTerm(strLars);
        }
        
        [Given(@"I have entered a non existant course ""(.*)""")]
        public void GivenIHaveEnteredANonExistantCourse(string strSearch)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.EnterSearchTerm(strSearch);
        }
        
        [Then(@"I should be able to view a Search box to enter my search criteria")]
        public void ThenIShouldBeAbleToViewASearchBoxToEnterMySearchCriteria()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ValidateSearchText();
        }
        
        [Then(@"the results with biology should be returned")]
        public void ThenTheResultsWithBiologyShouldBeReturned()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the results containing Mat should be returned")]
        public void ThenTheResultsContainingMatShouldBeReturned()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the results with the LARS number should be returned")]
        public void ThenTheResultsWithTheLARSNumberShouldBeReturned()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following message should be displayed ""(.*)""")]
        public void ThenTheFollowingMessageShouldBeDisplayed(string errMsg)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ValidateSearchErrorMessage(errMsg);
        }


    }
}
