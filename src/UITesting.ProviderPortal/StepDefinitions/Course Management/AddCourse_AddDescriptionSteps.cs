using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.TestSupport;
using TechTalk.SpecFlow;


namespace UITesting.ProviderPortal.StepDefinitions
{
    [Binding]
    public class AddCourse_AddDescriptionSteps : BaseTest
    {
        [Given(@"I am on the add a course form")]
        public void GivenIAmOnTheAddACourseForm()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl() + "//Courses//AddCourseSection1";
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
        }

        [Then(@"I have specified who the course is for (.*)")]
        [When(@"I have specified who the course is for (.*)")]
        [Given(@"I have specified who the course is for (.*)")]
        public void GivenIHaveSpecifiedWhoTheCourseIsFor(string p0)
        {
            if (p0 == "blank")
            {
                p0 = "";
            }
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
            AddCoursePage.EnterEquipmentNeeded(p0);
        }

        [Given(@"I have entered how the student will be assessed (.*)")]
        public void GivenIHaveEnteredHowTheStudentWillBeAssessed(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.HowAssessed(p0);
        }


        [Given(@"I have enter the next steps following completion of the course (.*)")]
        public void NextStepsFollowingCompletionOfTheCourseLevelOfThisCourse(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.NextSteps(p0);
        }


        [When(@"I click Next Button")]
        public void WhenIClickNextButton()
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.ClickNext();
        }

        [When(@"I click Next Button Failure")]
        public void WhenIClickNextButtonFail()
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.ClickNextFail();
        }

        [Then(@"Page 1 error message for field (.*) states (.*)")]
        public void ConfirmErrorMessage(string field, string errorMsg)
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
            addCoursePage.ConfirmErrorMessage(field, errorMsg);
        }


        [Then(@"Page 1 info message for field (.*) states (.*)")]
        public void ConfirmInfoMessage(string field, string errorMsg)
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
            addCoursePage.ConfirmInfoMessage(field, errorMsg);
        }


        [Then(@"I progess to next page")]
        public void ThenIProgessToNextPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"there should be a error summary on the top with header ""(.*)""")]
        public void ThenThereShouldBeAErrorSummaryOnTheTopWithHeader(string strHeadMsg)
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
            addCoursePage.ValidateHeaderMessage(strHeadMsg);
        }

        [Then(@"the same error message displayed on top ""(.*)""")]
        public void ThenTheSameErrorMessageDisplayedOnTop(string strSummErrMsg)
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
            addCoursePage.ValidateSummaryErrorMessage(strSummErrMsg);
        }


    }
}
