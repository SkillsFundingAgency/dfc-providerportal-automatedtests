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
        [Given(@"The first course displayed has a count of total live course runs")]
        public void GivenTheFirstCourseDisplayedHasACountOfTotalLiveCourseRuns()
        {
            ViewCourseRunsPage ViewCourseRunsPage = new ViewCourseRunsPage(webDriver);
            ViewCourseRunsPage.StoreLiveCourseRunCount();

            ViewCourseRunsPage.NumberOfDisplayedCourseRuns();

        }
        
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
    }
}
