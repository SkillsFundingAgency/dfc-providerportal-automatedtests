using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class AddCourseSteps : BaseTest
    {

        [Given(@"I have navigated to the Add Course Section 2 page")]
        public void NavigateToAddCoursePage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl() + "//Courses//AddCourseSection2";
        }

        [When(@"I enter the following in the course name field Course (.*)")]
        public void EntereCourseNameField(string coursename)
        {
            if (coursename == "blank") 
            {
                coursename = "";
            }
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCourseName(coursename);
        }


        [Then(@"course name error validation is not displayed")]
        public void ThenCourseNameIsNotDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseNameErrorNotDisplayed();
        }

        [Then(@"course name error validation is displayed")]
        public void ThenCourseNameErrorDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseNameErrorDisplayed();
        }

        [When(@"I enter the following in the URL field (.*)")]
        public void WhenIEnterTheURL(string url)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCourseURL(url);
        }

        [Then(@"course URL error validation is displayed")]
        public void ThenCourseURLErrorValidationIsDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseURLErrorDisplayed();
        }


        [Then(@"error message for field (.*) states (.*)")]
        public void ConfirmErrorMessage(string field, string errorMsg)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.ConfirmErrorMessage(field, errorMsg);
        }


        [When(@"I enter the following in the cost field (.*)")]
        public void EnterTheFollowingInTheCostField(string cost)
        {
            if (cost == "blank")
            {
                cost = "";
            }

            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCourseCost(cost);
        }

        [Then(@"course Cost error validation is displayed")]
        public void CourseCostErrorValidationIsDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseCostErrorDisplayed();
        }


        [When(@"I enter the following in the course id field (.*)")]
        public void EnterCourseID(string courseId)
        {
            if (courseId == "blank")
            {
                courseId = "";
            }

            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCourseId(courseId);
        }


        [Then(@"course id error validation is displayed")]
        public void ThenCourseIDErrorDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseIDErrorDisplayed();
        }

        [When(@"I enter the following in the cost description field (.*)")]
        public void EnterCostDescription(string costdescription)
        {
            if (costdescription == "blank")
            {
                costdescription = "";
            }

            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCostDescription(costdescription);
        }

        [Then(@"cost description error validation is displayed")]
        public void CostDescriptionErrorValidationIsDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CostDescriptionErrorDisplayed();
        }

        [Then(@"info message for field (.*) states (.*)")]
        public void InfoMessageForFieldCostDescription(string field, string infoMsg)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.ConfirmInfoMessage(field, infoMsg);
        }

        [When(@"I Select attendance mode (.*)")]
        public void WhenISelectAttendanceMode(string attendance)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectAttendance(attendance);
        }

        [When(@"I Select study mode (.*)")]
        public void WhenISelectStudyMode(string studymode)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectStudyMode(studymode);
        }

        [When(@"I print Qualification details")]
        public void WhenIPrintQualificationDetails()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.GetQualifiactionDetails();
        }

        [When(@"I tick the Advanced Learner Loans option")]
        public void TickTheAdvancedLearnerLoansOption()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectAdvancedLearnerLoan();
        }

        [When(@"I select start date (.*)")]
        public void WhenISelectStartDate(string StartDate)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectStartDateType(StartDate);
        }

        [When(@"I select delivery mode (.*)")]
        public void WhenISelectDeliveryMode(string deliveryMode)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectDeliveryMode(deliveryMode);
        }

        [When(@"I enter (.*) in the (.*) field")]
        public void WhenIEnterDay(string value, string field)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterStartDate(value, field);
        }

        [When(@"I select duration length (.*)")]
        public void WhenISelectDurationLength(string length)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterDuration(length);
        }

        [When(@"I select duration unit (.*)")]
        public void WhenISelectDurationUnit(string unit)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectDurationUnit(unit);
        }

        [When(@"I click Publish")]
        public void WhenIClickPublish()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.PublishCourse();
        }

        [When(@"I click Publish leading to error")]
        public void WhenIClickPublishLeadingToError()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.PublishCourseError();
        }


        [When(@"I click Page1 link")]
        public void WhenIClickPage1Link()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.ClickPage1();
        }


        [When(@"I select the first venue in the venues list")]
        public void SelectTheFirstVenueInTheVenuesList()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectFirstVenue();
        }

        [When(@"I select the second venue in the venues list")]
        public void SelectTheSecondVenueInTheVenuesList()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectSecondVenue();
        }

        [Then(@"the error summary header should say ""(.*)""")]
        public void ThenTheErrorSummaryHeaderShouldSay(string strHeaderMessage)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.ValidateHeaderMessage(strHeaderMessage);
        }

        [Then(@"the error message is displayed on the header ""(.*)""")]
        public void ThenTheErrorMessageShouldBeDisplayedOnTheHeader(string strHeaderErrorSumm)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.ValidateHeaderErrorSummary(strHeaderErrorSumm);
        }

    }
}