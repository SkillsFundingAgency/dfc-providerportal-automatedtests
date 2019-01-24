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
    public class DFC_6667AddCourse_WorkBasedOptionSteps : BaseTest
    {
        [When(@"I click on the Work Based Option Radio Button")]
        public void WhenIClickOnTheWorkBasedOptionRadioButton()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.clickWorkBasedRadioButton();
        }

        [Then(@"the flexible start date option is selected")]
        public void ThenTheFlexibleStartDateOptionIsSelected()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.verifyFlexibleStartDateSelected();
        }

        [Then(@"the venue selection options are not shown")]
        public void ThenTheVenueSelectionOptionsAreNotShown()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.verifyVenueSelectionNotShown();
        }

        [Then(@"full time or part time options are hidden")]
        public void ThenFullTimeOrPartTimeOptionsAreHidden()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.verifyFullPartTimeButtonsNotShown();
        }

        [Then(@"Day Night or Weekend attendance options are hidden")]
        public void ThenDayNightOrWeekendAttendanceOptionsAreHidden()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.verifyAttendancePatternButtonsnotShown();
        }


    }
}
