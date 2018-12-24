using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace UITesting.ProviderPortal.StepDefinitions
{
    [Binding]
    public class AddCourse_AddDescriptionSteps : BaseTest
    {
        [Given(@"I am on the add a course form")]
        public void GivenIAmOnTheAddACourseForm()
        {
        
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrlCourses() + "/AddCourseSection1";
            Console.WriteLine("url=" + webDriver.Url);
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
        }

        [Given(@"I have specified who the course is for (.*)")]
        public void GivenIHaveSpecifiedWhoTheCourseIsFor(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterWhoCourseFor(p0);
        }

        [Given(@"I have entered the entry requirements (.*)")]
        public void GivenIHaveEnteredTheEntryRequirements(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterEntryRequirements(p0);
            
        }

        [Given(@"I have entered what the student will learn (.*)")]
        public void GivenIHaveEnteredWhatTheStudentWillLearn(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterWhatWillLearn(p0);
        }

        [Given(@"I have entered how the student will learn (.*)")]
        public void GivenIHaveEnteredHowTheStudentWillLearn(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterHowYoullLearn(p0);
        }

        [Given(@"I have entered what equipment will be needed (.*)")]
        public void GivenIHaveEnteredWhatEquipmentWillBeNeeded(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterWhoCourseFor(p0);
        }

        [Given(@"I have entered how the student will be assessed (.*)")]
        public void GivenIHaveEnteredHowTheStudentWillBeAssessed(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterWhoCourseFor(p0);
        }

        [Given(@"I have enter the next step following completion of the course (.*)")]
        public void GivenIHaveEnterTheNextStepFollowingCompletionOfTheCourse(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterWhoCourseFor(p0);
        }

        [Given(@"I have enter the next step following completion of the course (.*)")]
        public void GivenIHaveEnterTheNextStepFollowingCompletionOfTheCourseLevelOfThisCourse(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterWhoCourseFor(p0);
        }
        
        [When(@"I click Next Button")]
        public void WhenIClickNextButton()
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.ClickNext();
        }
        

        [Then(@"I progess to next page")]
        public void ThenIProgessToNextPage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
