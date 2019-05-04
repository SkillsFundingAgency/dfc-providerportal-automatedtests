using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Qualification_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Qualification_Management
{
    [Binding]
    public class SearchForQualificationSteps : TestSupport.BaseTest
    {
        [Given(@"I have accessed the Course Directory as a provider")]
        public void GivenIHaveAccessedTheCourseDirectoryAsAProvider()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetQualUrl();
        }

        [Given(@"I have accessed the Qualifications page")]
        public void GivenIHaveAccessedTheQualificationsPage()
        {
            if (webDriver.Url.Contains("/Qualifications"))
            {
                SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            }
            else
            {
                webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetQualUrl();
                SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            }
        }

        [Given(@"there is a field to enter the LARS/QAN number\.")]
        public void GivenThereIsAFieldToEnterTheLARSQANNumber_()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckSearchTermField();
        }

        [Given(@"I have entered LARS/QAN Number ""(.*)""")]
        public void GivenIHaveEnteredLARSQANNumber(string LARS_QAN_No)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber(LARS_QAN_No);
        }

        [Given(@"that I have entered an invalid search term ""(.*)""")]
        public void GivenThatIHaveEnteredAnInvalidSearchTerm(string Inv_Search_Term)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber(Inv_Search_Term);
        }

        [Given(@"I have entered a Qualification Name ""(.*)""")]
        public void GivenIHaveEnteredAQualificationName(string QualName)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber(QualName);
        }

        [Given(@"I have entered a Qualification Name (.*)")]
        public void GivenIHaveEnteredAQualificationName2(string QualName)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber(QualName);
        }

        [Given(@"I have retrieved results for a search term")]
        public void GivenIHaveRetrievedResultsForASearchTerm()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I select one level for qualification level")]
        public void GivenISelectOneLevelForQualificationLevel()
        {
           // ScenarioContext.Current.Pending();
        }

        [Given(@"I have selected one awarding body")]
        public void GivenIHaveSelectedOneAwardingBody()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I have selected filters in Qualification Level and/or Awarding body")]
        public void GivenIHaveSelectedFiltersInQualificationLevelAndOrAwardingBody()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.ClickFirstFilter();
        }

        [When(@"I click reset")]
        public void WhenIClickReset()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.ClearAllFilters();
        }

        [Then(@"I want to see the Qualifications listed for that LARS/QAN Number")]
        public void ThenIWantToSeeTheQualificationsListedForThatLARSQANNumber()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I want to see LARS/QAN number ""(.*)"", Level ""(.*)"" and awarding body ""(.*)"" for each qualification")]
        public void ThenIWantToSeeLARSQANNumberLevelAndAwardingBodyForEachQualification(string LARSQAN_Lbl, string LevelLbl, string AwardBodyLbl)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.ValidateLabels(LARSQAN_Lbl, LevelLbl, AwardBodyLbl);
            
        }

        [Then(@"I want to see a Link to add this qualification\.")]
        public void ThenIWantToSeeALinkToAddThisQualification_()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckAddQualificationLink();
        }

        [Given(@"I click the link to Add Qualification")]
        public void GivenIClickTheLinkToAddQualification()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.AddQualificationLink();
        }


        [Then(@"I want to see Qualification Level Filter ""(.*)""")]
        public void ThenIWantToSeeQualificationLevelFilter(string QualLevelFilter)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.LookForQualificationLevelFilter(QualLevelFilter);
        }

        [Then(@"I want to see Awarding Organisation Filter on the screen ""(.*)""")]
        public void ThenIWantToSeeAwardingOrganisationFilterOnTheScreen(string AwardBodyFilter)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.LookForAwardingBodyFilter(AwardBodyFilter);
        }

        [Then(@"I want to see a validation message ""(.*)""")]
        public void ThenIWantToSeeAValidationMessage(string validation_msg)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckValidationMessage(validation_msg);
        }

        [Then(@"I want to see the number of results returned for the name ""(.*)""")]
        public void ThenIWantToSeeTheNumberOfResultsReturnedForTheName(string resultsMsg)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckResultsMessage(resultsMsg);
        }

        [Then(@"I want to see Level and Awarding body on the screen\.")]
        public void ThenIWantToSeeLevelAndAwardingBodyOnTheScreen_()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to select another level for qualification level")]
        public void ThenIShouldBeAbleToSelectAnotherLevelForQualificationLevel()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to select another awarding body")]
        public void ThenIShouldBeAbleToSelectAnotherAwardingBody()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all filters should be cleared\.")]
        public void ThenAllFiltersShouldBeCleared_()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.FiltersCleared();
        }
    }
}
