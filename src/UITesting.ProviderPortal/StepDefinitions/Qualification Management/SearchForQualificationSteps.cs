using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Qualification_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Qualification_Management
{
    [Binding]
    public class SearchForQualificationSteps :TestSupport.BaseTest
    {
        [Given(@"I have accessed the Course Directory as a provider")]
        public void GivenIHaveAccessedTheCourseDirectoryAsAProvider()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetQualUrl();
        }
        
        [Given(@"I have accessed the Qualifications page")]
        public void GivenIHaveAccessedTheQualificationsPage()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
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

        [Given(@"that I have not entered a LARS/QAN Number")]
        public void GivenThatIHaveNotEnteredALARSQANNumber()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber("");
        }

        [Given(@"I have entered a Qualification Name ""(.*)""")]
        public void GivenIHaveEnteredAQualificationName(string QualName)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber(QualName);
        }

        [Given(@"I have retrieved results for a LARS/QAN Number")]
        public void GivenIHaveRetrievedResultsForALARSQANNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click the \+ sign for Qualification Level")]
        public void GivenIClickTheSignForQualificationLevel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click the \+ sign for Awarding body")]
        public void GivenIClickTheSignForAwardingBody()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I want to see the Qualifications listed for that LARS/QAN Number")]
        public void ThenIWantToSeeTheQualificationsListedForThatLARSQANNumber()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"I want to see LARS/QAN number, Level and awarding body for each qualification")]
        public void ThenIWantToSeeLARSQANNumberLevelAndAwardingBodyForEachQualification()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"I want to see a Link to add this qualification\.")]
        public void ThenIWantToSeeALinkToAddThisQualification_()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckAddQualificationLink();
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

        [Then(@"no results should be returned and page should be empty")]
        public void ThenNoResultsShouldBeReturnedAndPageShouldBeEmpty()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I want to see Level and Awarding body on the screen\.")]
        public void ThenIWantToSeeLevelAndAwardingBodyOnTheScreen_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Entry Level and levels (.*) should be displayed along with a check box to select the level")]
        public void ThenEntryLevelAndLevelsShouldBeDisplayedAlongWithACheckBoxToSelectTheLevel(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the awarding bodies with a check box to select that body should be visible")]
        public void ThenTheAwardingBodiesWithACheckBoxToSelectThatBodyShouldBeVisible()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
