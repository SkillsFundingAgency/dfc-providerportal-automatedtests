using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class AddCourseSteps : BaseTest
    {

        [Given(@"I have navigated to the Add Course Section 2 page")]
        public void NavigateToYourVenuesPage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl() + "//Courses//AddCourseSection2";
        }

        [When(@"I enter the following in the course name field Course (.*)")]
        public void WhenIEnterTheFollowingInTheCourseNameFieldCourseA(string coursename)
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
        public void WhenIEnterTheFollowingInTheCostField(string cost)
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
        public void ThenCostDescriptionErrorValidationIsDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CostDescriptionErrorDisplayed();
        }

        [Then(@"info message for field (.*) states (.*)")]
        public void ThenInfoMessageForFieldCostDescriptionStatesYouHaveCharacterTooMany(string field, string infoMsg)
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


    }
}