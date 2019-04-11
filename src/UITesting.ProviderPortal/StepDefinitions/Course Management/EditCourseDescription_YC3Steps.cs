using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class EditCourseDescription_YC3Steps : BaseTest
    {
        [Given(@"I have accessed the Edit Course screen")]
        public void GivenIHaveAccessedTheEditCourseScreen()
        {
            //ScenarioContext.Current.Pending();
            
        }        
        [Given(@"I have edited course description with valid values ""(.*)""")]
        public void GivenIHaveEditedCourseDescriptionWithValidValues(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterCourseDescription(strData);
        }        
        [Given(@"I have left the course description as blank")]
        public void GivenIHaveLeftTheCourseDescriptionAsBlank()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterCourseDescription(" ");
        }        
        [Given(@"I have entered the following data  in Entry Requirements""(.*)""")]
        public void GivenIHaveEnteredTheFollowingDataInEntryRequirements(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterEntryRequirements(strData);
        }        
        [Given(@"I have entered the following data in What You'll learn ""(.*)""")]
        public void GivenIHaveEnteredTheFollowingDataInWhatYouLlLearn(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterWhatWillYouLearn(strData);
        }        
        [Given(@"I have entered the following data in Hou YOu'll Learn ""(.*)""")]
        public void GivenIHaveEnteredTheFollowingDataInHouYOuLlLearn(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterHowYouWillLearn(strData);
        }        
        [Given(@"I have entered the following data in What you'll need to bring ""(.*)""")]
        public void GivenIHaveEnteredTheFollowingDataInWhatYouLlNeedToBring(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterWhatYouWillNeedToBring(strData);
        }        
        [Given(@"I have entered the following data in How You'll be assessed ""(.*)""")]
        public void GivenIHaveEnteredTheFollowingDataInHowYouLlBeAssessed(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterHowYouWillBeAssessed(strData);
        }        
        [Given(@"I have entered the following data in Where Next ""(.*)""")]
        public void GivenIHaveEnteredTheFollowingDataInWhereNext(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterWhereNext(strData);
        }        
        [Given(@"I have added an invalid character in Course description ""(.*)""")]
        public void GivenIHaveAddedAnInvalidCharacterInCourseDescription(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterCourseDescription(strData);
        }        
        [Given(@"I have selected the Advanced Learner option")]
        public void GivenIHaveSelectedTheAdvancedLearnerOption()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.SelectAdvancedLearnerOption();
        }        
        [Given(@"I have selected the Adult Education option")]
        public void GivenIHaveSelectedTheAdultEducationOption()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.SelectAdultEducationOption();
        }        
        [Given(@"I have deseleceted the Adult Education Course")]
        public void GivenIHaveDeselecetedTheAdultEducationCourse()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ClickAdultEducationOption();
            
        }        
        [When(@"I select Edit Course Description")]
        public void WhenISelectEditCourseDescription()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
           // ViewYourCoursesPage.OpenAllQualificationsYC3();
            ViewYourCoursesPage.ClickEditCourseDescriptionLink();
        }        
        [When(@"I Click the Save button")]
        public void WhenIClickTheSaveButton()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ClickSave();
        }        
        [When(@"I Click Cancel")]
        public void WhenIClickCancel()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ClickCancel();
        }        
        [Then(@"Edit Course screen should be displayed")]
        public void ThenEditCourseScreenShouldBeDisplayed()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
        }        
        [Then(@"Adult Education and Advanced Learner check boxes should be present")]
        public void ThenAdultEducationAndAdvancedLearnerCheckBoxesShouldBePresent()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.CheckFundingOptions();
        }        
        [Then(@"Save button and Cancel link should be present")]
        public void ThenSaveButtonAndCancelLinkShouldBePresent()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ValidateButtons();        
        }        
        [Then(@"the course description should be saved")]
        public void ThenTheCourseDescriptionShouldBeSaved()
        {
            //ScenarioContext.Current.Pending();
        }        
        [Then(@"I should be able to see the saved data")]
        public void ThenIShouldBeAbleToSeeTheSavedData()
        {
           // ScenarioContext.Current.Pending();
        }        
        [Then(@"folloiwng course for error message should be displayed ""(.*)""")]
        public void ThenFolloiwngCourseForErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ValidateCourseForError(errMsg);
        }        
        [Then(@"following course for error message should be displayed ""(.*)""")]
        public void ThenFollowingCourseForErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ValidateCourseForError(errMsg);
        }        
        [Then(@"following Entry Requirement error message should be displayed ""(.*)""")]
        public void ThenFollowingEntryRequirementErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ValidateEntryRequirementsError(errMsg);
        }        
        [Then(@"following What you’ll learn error message should be displayed ""(.*)""")]
        public void ThenFollowingWhatYouLlLearnErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.WhatYouWillLearnError(errMsg);
        }        
        [Then(@"following How you’ll learn error message should be displayed ""(.*)""")]
        public void ThenFollowingHowYouLlLearnErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.HowYouWillLearnError(errMsg);
        }        
        [Then(@"following What you’ll need to bring error message should be displayed ""(.*)""")]
        public void ThenFollowingWhatYouLlNeedToBringErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.WhatYouWillNeedToBringError(errMsg);
        }        
        [Then(@"following How you’ll be assessed error message should be displayed ""(.*)""")]
        public void ThenFollowingHowYouLlBeAssessedErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.HowYouWillBeAssessedError(errMsg);
        }        
        [Then(@"following Where next error message should be displayed ""(.*)""")]
        public void ThenFollowingWhereNextErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.WhereNextError(errMsg);
        }        
        [Then(@"the Advanced Learner option should be selected")]
        public void ThenTheAdvancedLearnerOptionShouldBeSelected()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.ClickEditCourseDescriptionLink();
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.CheckAdvancedLearnerOption();
        }        
        [Then(@"the Adult Education option should be selected")]
        public void ThenTheAdultEducationOptionShouldBeSelected()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.ClickEditCourseDescriptionLink();
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.CheckAdultEducationOption();
        }        
        [Then(@"the Adult Education should not be deselected")]
        public void ThenTheAdultEducationShouldNotBeDeselected()
        {
            //EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            //editCourseDescription_YC3Page.ClickAdultEducationOption();
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.ClickEditCourseDescriptionLink();
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.CheckAdultEducationOption();

        }
        [Then(@"there should be a error summary with heading ""(.*)""")]
        public void ThenThereShouldBeAErrorSummaryWithHeading(string strErrSummHeader)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ValidateErrSummHeader(strErrSummHeader);
        }

        [Then(@"the error summary should also list the error message ""(.*)""")]
        public void ThenTheErrorSummaryShouldAlsoListTheErrorMessage(string strError)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ValidateHeaderErrMessage(strError);
        }

    }
}
