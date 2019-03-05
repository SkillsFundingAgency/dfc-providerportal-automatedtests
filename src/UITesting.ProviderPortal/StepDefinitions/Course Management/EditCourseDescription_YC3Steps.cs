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
            ScenarioContext.Current.Pending();
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
            editCourseDescription_YC3Page.SelectAdultEducationOption();
        }
        
        [When(@"I select Edit Course Description")]
        public void WhenISelectEditCourseDescription()
        {
            ScenarioContext.Current.Pending();
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
            ScenarioContext.Current.Pending();
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
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see the saved data")]
        public void ThenIShouldBeAbleToSeeTheSavedData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"folloiwng error message should be displayed ""(.*)""")]
        public void ThenFolloiwngErrorMessageShouldBeDisplayed(string errMsg)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ValidateErrorMessage(errMsg);
        }
        
        [Then(@"following error message should be displayed ""(.*)""")]
        public void ThenFollowingErrorMessageShouldBeDisplayed(string errMsg)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Advanced Learner option should be selected")]
        public void ThenTheAdvancedLearnerOptionShouldBeSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Adult Education option should be selected")]
        public void ThenTheAdultEducationOptionShouldBeSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Adult Education should not be deselected")]
        public void ThenTheAdultEducationShouldNotBeDeselected()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
