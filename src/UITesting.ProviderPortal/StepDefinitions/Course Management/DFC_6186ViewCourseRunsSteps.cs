using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class DFC_6186ViewCourseRunsSteps : BaseTest
    {
        //Tests do nothing at moment while being fixed and merged.. 17/01
        
        [Given(@"the count of live course runs matches number of course runs displayed")]
        public void GivenTheCountOfLiveCourseRunsMatchesNumberOfCourseRunsDisplayed()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
        }
        
        [Given(@"the course runs are sorted firstly on course name")]
        public void GivenTheCourseRunsAreSortedFirstlyOnCourseName()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
        }
        
        [Given(@"the course runs are sorted secondly on start date")]
        public void GivenTheCourseRunsAreSortedSecondlyOnStartDate()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
        }
        
        [Given(@"the course runs are sorted thirdly on venue name")]
        public void GivenTheCourseRunsAreSortedThirdlyOnVenueName()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);

        }



        [Given(@"I have added up the number of runs expected for each qualification level")]
        public void GivenIHaveAddedUpTheNumberOfRunsExpectedForEachQualificationLevel()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
            //ViewCourseRunsPage.AddCourseRunsQualLevel();
        }

        [Given(@"I have added up the total runs for each course")]
        public void GivenIHaveAddedUpTheTotalRunsForEachCourse()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
            //ViewCourseRunsPage.AddCourseRunsCourseLevel();
        }

        [Then(@"The total number of runs by course matches the total by qualification level")]
        public void ThenTheTotalNumberOfRunsByCourseMatchesTheTotalByQualificationLevel()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
            //ViewCourseRunsPage.CompareTotals();

        }


        [Given(@"I have openend the main Qual Type accordian")]
        public void GivenIHaveOpenendTheMainQualTypeAccordian()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
            
        }

        [Given(@"I have openned the secondary Course accordian")]
        public void GivenIHaveOpennedTheSecondaryCourseAccordian()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
        }

        [When(@"I add up the number of course runs displayed")]
        public void WhenIAddUpTheNumberOfCourseRunsDisplayed()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
        }






    }
}
