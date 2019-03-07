using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class EditCourseRunDetails_YC3Steps : BaseTest
    {
        [Given(@"I have accessed the selected course run data")]
        public void GivenIHaveAccessedTheSelectedCourseRunData()
        {
            

        }
        
        [Given(@"I have entered the following course name ""(.*)""")]
        public void GivenIHaveEnteredTheFollowingCourseName(string strCourseName)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterCourseName(strCourseName);
        }
        
        [Given(@"I have selected ""(.*)"" as delivery mode")]
        public void GivenIHaveSelectedAsDeliveryMode(string strDelMode)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SelectDeliveryMode(strDelMode);
        }
        
        [Given(@"I have entered ""(.*)"" in Day, ""(.*)"" in Month and ""(.*)"" in Year")]
        public void GivenIHaveEnteredInDayInMonthAndInYear(string  strDay, string  strMonth, string  strYear)
        {
            ScenarioContext.Current.Pending();
        }
        
       /* [Given(@"I have entered ""(.*)"" in Day, ""(.*)"" in Month and ""(.*)"" in Year")]
        public void GivenIHaveEnteredInDayInMonthAndInYear(string p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }*/
        
        [Given(@"I have entered selected a venue from the dropdown")]
        public void GivenIHaveEnteredSelectedAVenueFromTheDropdown()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected entered a value in cost ""(.*)""")]
        public void GivenIHaveSelectedEnteredAValueInCost(string  strCoset)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have left cost description as blank")]
        public void GivenIHaveLeftCostDescriptionAsBlank()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a value in cost description ""(.*)""")]
        public void GivenIHaveEnteredAValueInCostDescription(string strCostDesc)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have left cost and cost description as blank")]
        public void GivenIHaveLeftCostAndCostDescriptionAsBlank()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a value in Duration ""(.*)""")]
        public void GivenIHaveEnteredAValueInDuration(string strDuration)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected ""(.*)"" in the duration unit")]
        public void GivenIHaveSelectedInTheDurationUnit(string strMonth)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a blank value in Duration ""(.*)""")]
        public void GivenIHaveEnteredABlankValueInDuration(string strDuration)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected ""(.*)"" in attendance pattern")]
        public void GivenIHaveSelectedInAttendancePattern(string strAttPatt)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected ""(.*)"" in Attendance")]
        public void GivenIHaveSelectedInAttendance(string strAtt)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered following URL ""(.*)""")]
        public void GivenIHaveEnteredFollowingURL(string strURL)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected ""(.*)"" as attendance pattern")]
        public void GivenIHaveSelectedAsAttendancePattern(string strAttPatt)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I selected a Course and a course run")]
        public void WhenISelectedACourseAndACourseRun()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }
        
        [When(@"I have clicked Edit Course Details")]
        public void WhenIHaveClickedEditCourseDetails()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ClickEditCourseDetailsLink();
        }
        
        [When(@"I  Save the data")]
        public void WhenISaveTheData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the link to the changed course run")]
        public void WhenIClickTheLinkToTheChangedCourseRun()
        {
            ScenarioContext.Current.Pending();
        }
        
        /*[When(@"I Save the data")]
        public void WhenISaveTheData()
        {
            ScenarioContext.Current.Pending();
        }*/
        
        [Then(@"Edit Course details screen should be displayed")]
        public void ThenEditCourseDetailsScreenShouldBeDisplayed()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
        }
        
        [Then(@"the course run should be saved and the changed course run link should be visible")]
        public void ThenTheCourseRunShouldBeSavedAndTheChangedCourseRunLinkShouldBeVisible()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to view the changed data")]
        public void ThenIShouldBeAbleToViewTheChangedData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following course name message should be displayed ""(.*)""")]
        public void ThenTheFollowingCourseNameMessageShouldBeDisplayed(string strErrMsg)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the date should be saved and the changed course run link should be visible")]
        public void ThenTheDateShouldBeSavedAndTheChangedCourseRunLinkShouldBeVisible()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following error date message should be displayed ""(.*)""")]
        public void ThenTheFollowingErrorDateMessageShouldBeDisplayed(string strErrMsg)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to view the changed data with the new venue")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheNewVenue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to view the changed data with the cost")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheCost()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to view the changed data with the cost description")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheCostDescription()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following cost message should be displayed ""(.*)""")]
        public void ThenTheFollowingCostMessageShouldBeDisplayed(string strErrMsg)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to view the changed data with the duration")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheDuration()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following duration message should be displayed ""(.*)""")]
        public void ThenTheFollowingDurationMessageShouldBeDisplayed(string strErrMsg)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to view the changed data with the attendance pattern and attendance")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheAttendancePatternAndAttendance()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to view the changed data with the Url")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheUrl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following URL message should be displayed ""(.*)""")]
        public void ThenTheFollowingURLMessageShouldBeDisplayed(string strErrMsg)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"changes should not be saved")]
        public void ThenChangesShouldNotBeSaved()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
