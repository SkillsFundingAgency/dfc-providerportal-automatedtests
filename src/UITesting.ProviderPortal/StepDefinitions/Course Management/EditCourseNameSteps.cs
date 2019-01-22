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
        public void GivenIHaveSearchedForUKPRNAndClickedSearch(string UkPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(UkPRN);
            searchProviderPage.ClickSearchButton();          
        }
        
        [Given(@"I have clicked View Courses button")]
        public void GivenIHaveClickedViewCoursesButton()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }
        
        [Given(@"I have searched for a Qualification ""(.*)""")]
        public void GivenIHaveSearchedForAQualification(string QualName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SearchQual(QualName);
        }
        
        [Given(@"I have searched for a course name ""(.*)""")]
        public void GivenIHaveSearchedForACourseName(string CourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SearchCourseName(CourseName);
        }
        
        [Given(@"I have searched for a course runs with a course name ""(.*)""")]
        public void GivenIHaveSearchedForACourseRunsWithACourseName(string OldCourseRunName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCourseRunName(OldCourseRunName);
        }
        
        [Given(@"I have changed the course name to ""(.*)""")]
        public void GivenIHaveChangedTheCourseNameTo(string NewCourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ChangeCourseName(NewCourseName);
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
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"Save , Discard and preview buttons should be visible")]
        public void ThenSaveDiscardAndPreviewButtonsShouldBeVisible()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateButtons();
        }
        
        [Then(@"the new course name should be saved")]
        public void ThenTheNewCourseNameShouldBeSaved()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateSavedData();
        }
        
        [Then(@"the Error message should be displayed ""(.*)""")]
        public void ThenTheErrorMessageShouldBeDisplayed(string errMessage)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateErrorMessage(errMessage);
        }
        
        [Then(@"the course name should be saved without leading or trailing spaces")]
        public void ThenTheCourseNameShouldBeSavedWithoutLeadingOrTrailingSpaces()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateSpacesData();
        }
    }
}
