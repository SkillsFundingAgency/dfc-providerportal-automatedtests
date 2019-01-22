using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Provider_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class EditCourseNameSteps : BaseTest
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

        [Given(@"I have clicked View Courses button")]
        public void GivenIHaveClickedViewCoursesButton()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }
        
        [Given(@"I have searched for a Qualification ""(.*)""")]
        public void GivenIHaveSearchedForAQualification(string qualName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SearchQual(qualName);
        }

        [Given(@"I have searched for a course name ""(.*)""")]
        public void GivenIHaveSearchedForACourseName(string CourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SearchCourseName(CourseName);
        }

        public void GivenIHaveSearchedForACourseRunsWithACourseName(string OldCourseRunName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCourseRunName(OldCourseRunName);
        }

        [Given(@"I have changed the course name from ""(.*)"" to ""(.*)""")]
        public void GivenIHaveChangedTheCourseNameFromTo(string oldCourseRunName, string newCourseRunName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ChangeCourseName(oldCourseRunName, newCourseRunName);
        }
        
        [When(@"I Click Save")]
        public void WhenIClickSave()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SaveCourseName();
        }
        
        [Then(@"I want to view my courses")]
        public void ThenIWantToViewMyCourses()
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
        public void ThenTheCourseNameShouldBeSavedWithoutLeadingOrTrailingSpaces(string newCourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateSpacesData(newCourseName);
        }
    }
}
