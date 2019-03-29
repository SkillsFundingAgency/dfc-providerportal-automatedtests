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

        
        [Given(@"the count of live course runs matches number of course runs displayed")]
        public void GivenTheCountOfLiveCourseRunsMatchesNumberOfCourseRunsDisplayed()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }
        
        [Given(@"the course runs are sorted firstly on course name")]
        public void GivenTheCourseRunsAreSortedFirstlyOnCourseName()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }
        
        [Given(@"the course runs are sorted secondly on start date")]
        public void GivenTheCourseRunsAreSortedSecondlyOnStartDate()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }
        
        [Given(@"the course runs are sorted thirdly on venue name")]
        public void GivenTheCourseRunsAreSortedThirdlyOnVenueName()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);

        }



        [Given(@"I have added up the number of runs expected for each qualification level")]
        public void GivenIHaveAddedUpTheNumberOfRunsExpectedForEachQualificationLevel()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            //ViewYourCoursesPage.AddCourseRunsQualLevel();
        }

        [Given(@"I have added up the total runs for each course")]
        public void GivenIHaveAddedUpTheTotalRunsForEachCourse()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            //ViewYourCoursesPage.AddCourseRunsCourseLevel();
        }

        [Then(@"The total number of runs by course matches the total by qualification level")]
        public void ThenTheTotalNumberOfRunsByCourseMatchesTheTotalByQualificationLevel()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.CompareTotals();

        }


        [Given(@"I have openend the main Qual Type accordian")]
        public void GivenIHaveOpenendTheMainQualTypeAccordian()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.OpenMainAccordians();
            
        }

        [Given(@"I have openned the secondary Course accordian")]
        public void GivenIHaveOpennedTheSecondaryCourseAccordian()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.OpenQualificationAccordians();
        }

        [When(@"I add up the number of course runs displayed")]
        public void WhenIAddUpTheNumberOfCourseRunsDisplayed()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            //int numberOfRunsShown = countUpAllCourseRunsShown();
            ViewYourCoursesPage.CountUpAllCourseRunsShown();
        }


        [Given(@"I have accessed my courses")]
        public void GivenIHaveAccessedMyCourses()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrlCourses();
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }


        [When(@"I get the main total of course runs from the main heading")]
        public void WhenIGetTheMainTotalOfCourseRunsFromTheMainHeading()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.StoreLiveCourseRunCount();

        }



        // start of YC three steps

        [Given(@"I am on the YC-three screen")]
        public void GivenIAmOnTheYC_ThreeScreen()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }

        [Given(@"The default Qualification Level is open in YC-three")]
        public void GivenTheDefaultQualificationLevelIsOpenInYC_Three()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }

        [Then(@"the number of courses displayed matches the facet shown for Level in YC-three")]
        public void ThenTheNumberOfCoursesDisplayedMatchesTheFacetShownForLevelInYC_Three()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }

        [When(@"I click on each course listed for the qualification level that is selected in YC-three")]
        public void WhenIClickOnEachCourseListedForTheQualificationLevelThatIsSelectedInYC_Three()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.OpenAllQualificationsYC3();
        }




        [Then(@"the number of course runs displayed matches the facet shown for each Course in YC-three")]
        public void ThenTheNumberOfCourseRunsDisplayedMatchesTheFacetShownForEachCourseInYC_Three()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }

        [When(@"I click on each course run listed for each qualification level that is selected in YC-three")]
        public void WhenIClickOnEachCourseRunListedForEachQualificationLevelThatIsSelectedInYC_Three()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.OpenAllCourseRunsYC3();
        }

        // end of YC three steps


    }
}
