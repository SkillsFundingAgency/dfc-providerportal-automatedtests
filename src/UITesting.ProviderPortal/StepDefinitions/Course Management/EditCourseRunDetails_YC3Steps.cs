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
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered the following course name ""(.*)""")]
        public void GivenIHaveEnteredTheFollowingCourseName(string strCourseName)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterCourseName(strCourseName);
        }

        [Given(@"I have entered the following course name ""(.*)"" when copying a course")]
        public void GivenIHaveEnteredTheFollowingCourseNameCopy(string strCourseName)
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
            copyCoursePage.EnterCourseName(strCourseName);
        }

        [Given(@"I have selected ""(.*)"" as delivery mode")]
        public void GivenIHaveSelectedAsDeliveryMode(string strDelMode)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SelectDeliveryMode(strDelMode);
        }

        [Given(@"I have selected ""(.*)"" as delivery mode when copying a course")]
        public void GivenIHaveSelectedAsDeliveryModeCopy(string strDelMode)
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
            copyCoursePage.SelectDeliveryMode(strDelMode);
        }

        [Given(@"I have selected Start Date ""(.*)""")]
        public void GivenIHaveSelectedStartDate(string strDefStartDate)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SelectDefinedStartDate(strDefStartDate);
        }

        [Given(@"I have selected Start Date ""(.*)"" when copying a course")]
        public void GivenIHaveSelectedStartDateCopy(string strDefStartDate)
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
            copyCoursePage.SelectDefinedStartDate(strDefStartDate);
        }


        [Given(@"I have entered ""(.*)"" in Day, ""(.*)"" in Month and ""(.*)"" in Year")]
        public void GivenIHaveEnteredInDayInMonthAndInYear(string strDay, string strMonth, string strYear)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterStartDate(strDay, strMonth, strYear);
        }


        [Given(@"I have entered ""(.*)"" in Day, ""(.*)"" in Month and ""(.*)"" in Year when copying a course")]
        public void GivenIHaveEnteredInDayInMonthAndInYearCopy(string strDay, string strMonth, string strYear)
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
            copyCoursePage.EnterStartDate(strDay, strMonth, strYear);
        }

        /*[Given(@"I have entered ""(.*)"" in Day, ""(.*)"" in Month and ""(.*)"" in Year")]
        public void GivenIHaveEnteredInDayInMonthAndInYear(string p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }*/

        [Given(@"I have entered selected a venue from the dropdown")]
        public void GivenIHaveEnteredSelectedAVenueFromTheDropdown()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SelectVenue();
        }

        [Given(@"I have selected entered a value in cost ""(.*)""")]
        public void GivenIHaveSelectedEnteredAValueInCost(string strCost)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterCost(strCost);
        }

        [Given(@"I have left cost description as blank")]
        public void GivenIHaveLeftCostDescriptionAsBlank()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterCostDescription(" ");
        }

        [Given(@"I have entered a value in cost description ""(.*)""")]
        public void GivenIHaveEnteredAValueInCostDescription(string strCostDesc)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterCostDescription(strCostDesc);
        }

        [Given(@"I have left cost as blank")]
        public void GivenIHaveLeftCostAsBlank()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterCost(" ");
        }

        [Given(@"I have left cost and cost description as blank")]
        public void GivenIHaveLeftCostAndCostDescriptionAsBlank()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterCost(" ");
            editCourseRunDetailsPage.EnterCostDescription(" ");
        }

        [Given(@"I have entered a value in Duration ""(.*)""")]
        public void GivenIHaveEnteredAValueInDuration(string strDuration)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterDuration(strDuration);
        }

        [Given(@"I have selected ""(.*)"" in the duration unit")]
        public void GivenIHaveSelectedInTheDurationUnit(string strDurationUnit)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SelectDurationUnit(strDurationUnit);
        }

        [Given(@"I have entered a blank value in Duration ""(.*)""")]
        public void GivenIHaveEnteredABlankValueInDuration(string strDuration)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterDuration(strDuration);
        }

        [Given(@"I have selected ""(.*)"" in attendance pattern")]
        public void GivenIHaveSelectedInAttendancePattern(string strAttPatt)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SelectAttendancePattern(strAttPatt);
        }

        [Given(@"I have selected ""(.*)"" in Attendance")]
        public void GivenIHaveSelectedInAttendance(string strAtt)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SelectAttendance(strAtt);
        }

        [Given(@"I have entered following URL ""(.*)""")]
        public void GivenIHaveEnteredFollowingURL(string strURL)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.EnterURL(strURL);
        }

        [Given(@"I have selected ""(.*)"" as attendance pattern")]
        public void GivenIHaveSelectedAsAttendancePattern(string strAttPatt)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SelectAttendancePattern(strAttPatt);
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
            //ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            //viewYourCoursesPage.ClickEditCourseDetailsLink();

            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCourse();

            CourseSummaryPage courseSummaryPage = new CourseSummaryPage(webDriver);
            courseSummaryPage.ClickEditCourseRun();


        }

        [When(@"I  Save the data")]
        public void WhenISaveTheData()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.SaveData();
        }

        [When(@"I click the link to the changed course run")]
        public void WhenIClickTheLinkToTheChangedCourseRun()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ClickEditedCourseDetailsLink();
        }

       /*[When(@"I Save the data")]
        public void WhenISaveTheData()
        {
            ScenarioContext.Current.Pending();
        }*/
        
        [When(@"I select Cancel")]
        public void WhenISelectCancel()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.ClickCancel();
        }
        
        [Then(@"Edit Course details screen should be displayed")]
        public void ThenEditCourseDetailsScreenShouldBeDisplayed()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
        }

        [Then(@"the course run should be saved and the changed course run link should be visible")]
        public void ThenTheCourseRunShouldBeSavedAndTheChangedCourseRunLinkShouldBeVisible()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ValidateEditedCourseDeatilsLink();
        }

        [Then(@"I should be able to view the changed data")]
        public void ThenIShouldBeAbleToViewTheChangedData()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }

        [Then(@"the following course name message should be displayed ""(.*)""")]
        public void ThenTheFollowingCourseNameMessageShouldBeDisplayed(string strErrMsg)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.ValidateErrorMessage(strErrMsg, "Course Name");
        }

        [Then(@"the date should be saved and the changed course run link should be visible")]
        public void ThenTheDateShouldBeSavedAndTheChangedCourseRunLinkShouldBeVisible()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }

        [Then(@"the following error date message should be displayed ""(.*)""")]
        public void ThenTheFollowingErrorDateMessageShouldBeDisplayed(string strErrMsg)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.ValidateErrorMessage(strErrMsg, "Start Date");
        }

        /* [Then(@"the following error date message should be displayed ""(.*)""")]
         public void ThenTheFollowingErrorDateMessageShouldBeDisplayed(string strErrMsg)
         {
             EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
             editCourseRunDetailsPage.ValidateErrorMessage(strErrMsg, "Start Date");
         }*/
        [Then(@"I should be able to view the changed data with the new venue")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheNewVenue()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }
        [Then(@"I should be able to view the changed data with the cost")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheCost()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }

        [Then(@"I should be able to view the changed data with the cost description")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheCostDescription()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }

        [Then(@"the following cost message should be displayed ""(.*)""")]
        public void ThenTheFollowingCostMessageShouldBeDisplayed(string strErrMsg)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.ValidateErrorMessage(strErrMsg, "Cost");
        }

        [Then(@"I should be able to view the changed data with the duration")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheDuration()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }

        [Then(@"the following duration message should be displayed ""(.*)""")]
        public void ThenTheFollowingDurationMessageShouldBeDisplayed(string strErrMsg)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.ValidateErrorMessage(strErrMsg, "Duration Length");
        }

        [Then(@"I should be able to view the changed data with the attendance pattern and attendance")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheAttendancePatternAndAttendance()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }

        [Then(@"I should be able to view the changed data with the Url")]
        public void ThenIShouldBeAbleToViewTheChangedDataWithTheUrl()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }

        [Then(@"the following URL message should be displayed ""(.*)""")]
        public void ThenTheFollowingURLMessageShouldBeDisplayed(string strErrMsg)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.ValidateErrorMessage(strErrMsg, "URL");
        }

        [Then(@"changes should not be saved")]
        public void ThenChangesShouldNotBeSaved()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.OpenAllQualificationsYC3();
            viewYourCoursesPage.OpenAllCourseRunsYC3();
        }
        [Then(@"there should be a error summary with header ""(.*)""")]
        public void ThenThereShouldBeAErrorSummaryWithHeader(string strHeaderTitle)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.ValidateHeaderTitle(strHeaderTitle);
        }

        [Then(@"the error summary should have the error ""(.*)""")]
        public void ThenTheErrorSummaryShouldHaveTheError(string strHeaderError)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetailsPage = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetailsPage.ValidateHeaderError(strHeaderError);
        }

    }
}
