using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class ViewCourseDescriptionSteps : BaseTest
    {


        [Then(@"I open the course details accordian for diploma")]
        public void ThenIOpenTheCourseDetailsAccordianForDiploma()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.ClickOpenAccordianDiploma();
         
        }



        [Given(@"I have clicked on '(.*)'")]
        public void GivenIHaveClickedOn(string p0)
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            
        }

        [When(@"I click close view course description pop-up button")]
        public void WhenIClickCloseViewCourseDescriptionPop_UpButton()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.ClickCloseCourseDescriptionPopup();
        }


        [Given(@"I click on the view course description link")]
        public void GivenIClickOnTheViewCourseDescriptionLink()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.ClickShowCourseDescriptionPopup();
        }


        [Then(@"course description pop-up opens")]
        public void ThenCourseDescriptionPop_UpOpens()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.VerifyDescriptionPopupOpens();


        }

        [Then(@"qualification title is shown")]
        public void ThenQualificationTitleIsShown()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.VerifyCourseDescriptionShown();


        }

        [Then(@"Who is the course for is shown")]
        public void ThenWhoIsTheCourseForIsShown()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.VerifyWhoCourseFor();
        }

        [Then(@"Entry requirements are shown")]
        public void ThenEntryRequirementsAreShown()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.VerifyEntryRequirements();

        }

        [Then(@"What you’ll learn is shown")]
        public void ThenWhatYouLlLearnIsShown()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.VerifyWhatWillLearn();
        }

        [Then(@"What you'll need to bring is shown")]
        public void ThenWhatYouLlNeedToBringIsShown()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.VerifyEquipmentNeeded();
        }
        
        [Then(@"How you'll be assessed is shown")]
        public void ThenHowYouLlBeAssessedIsShown()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            ViewYourCoursesPage.VerifyHowAssessed();

        }

        [Then(@"Where next\? is shown")]
        public void ThenWhereNextIsShown()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);

        }

        [Then(@"course description pop-up is no longer visible")]
        public void ThenCourseDescriptionPop_UpIsNoLongerVisible()
        {
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);

        }
    }
}
