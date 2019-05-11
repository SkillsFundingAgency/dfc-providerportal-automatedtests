using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System.Threading;



namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class AsAUserSteps : BaseTest
    {


        [Given(@"I have navigated to the Add Course Section 2 page screen")]
        public void NavigateToAddCoursePage()
        {
            //webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl() +"/Courses/AddCourseSection1";
        }

        [When(@"I click Online option within Delivery mode")]
        public void WhenIClickOnlineOptionWithinDeliveryMode()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.clickOnline();
            //Thread.Sleep(2000);
        }

        [Then(@"I should see Select Venue option")]
        public void ThenIShouldSeeSelectVenueOption()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.selectVenueIsDisplayed();
        }

        [Then(@"I should see Full Time or Part Time option")]
        public void ThenIShouldSeeFullTimeOrPartTimeOption()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.timeIsDisplayed();
        }

        [Then(@"I should see Attendance option")]
        public void ThenIShouldSeeAttendanceOption()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver); 
            addCoursePage2.modeIsDisplayed();
        }

        [Then(@"I should not see Select Venue Option")]
        public void ThenIShouldNotSeeSelectVenueOption()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
        }

        [Then(@"I should not see Full Time or Part Time option")]
        public void ThenIShouldNotSeeFullTimeOrPartTimeOption()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
        }

        [Then(@"I should not see Attendance option")]
        public void ThenIShouldNotSeeAttendanceOption()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
        }

        [Then(@"Flexible Start Date is already selected")]
        public void ThenFlexibleStartDateIsAlreadySelected()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
        }

       
    }
}

