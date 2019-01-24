using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class EditCourseNameSteps :BaseTest
    {
        [Given(@"I have logged to course directory as a provider")]
        public void GivenIHaveLoggedToCourseDirectoryAsAProvider()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }        
        [Given(@"I have searched for UKPRN ""(.*)"" and clicked search")]
        public void GivenIHaveSearchedForUKPRNAndClickedSearch(string ukPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(ukPRN);
            searchProviderPage.ClickSearchButton();
        }        
        [Given(@"I have clicked View Courses button to see a list of courses")]
        public void GivenIHaveClickedViewCoursesButtonToSeeAListOfCourses()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }        
        [Given(@"I have clicked the Main Qualification")]
        public void GivenIHaveClickedTheMainQualification()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ClickQual();
        }        
        [Given(@"I have clicked one of the courses available")]
        public void GivenIHaveClickedOneOfTheCoursesAvailable()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ClickCourseName();
        }        
        [Given(@"I have selected a course run to update")]
        public void GivenIHaveSelectedACourseRunToUpdate()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCourseRunName();
        }        
        [Given(@"I have changed the course name to ""(.*)""")]
        public void GivenIHaveChangedTheCourseNameTo(string newCourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ChangeCourseName(newCourseName);
        }        
        [When(@"I Click Save")]
        public void WhenIClickSave()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SaveCourseName();
        }        
        [Then(@"I should be able to view the course runs\.")]
        public void ThenIShouldBeAbleToViewTheCourseRuns_()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Save , Discard and preview buttons should be visible")]
        public void ThenSaveDiscardAndPreviewButtonsShouldBeVisible()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateButtons();
        }
        
        [Then(@"the new course name should be saved as ""(.*)""")]
        public void ThenTheNewCourseNameShouldBeSavedAs(string newCourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateSavedData(newCourseName);
        }
        
        [Then(@"the Error message should be displayed ""(.*)""")]
        public void ThenTheErrorMessageShouldBeDisplayed(string errMessage)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateErrorMessage(errMessage);
        }
        
        [Then(@"the course name should be saved without leading or trailing spaces as ""(.*)""")]
        public void ThenTheCourseNameShouldBeSavedWithoutLeadingOrTrailingSpacesAs(string newCourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateSpacesData(newCourseName);
        }

        [Given(@"I have changed the course venue to (.*)")]
        public void EditVenueName(string venueName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ChangeVenueName(venueName);
        }

        [Then(@"the new course venue should be saved as (.*)")]
        public void NewCourseVenueShouldBeSaved(string venueName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateSavedVenue(venueName);
        }

    }
}
