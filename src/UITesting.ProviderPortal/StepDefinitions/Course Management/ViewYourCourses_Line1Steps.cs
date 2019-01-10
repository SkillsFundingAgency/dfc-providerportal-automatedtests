using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class ViewYourCourses_Line1Steps :BaseTest 
    {
        [Given(@"I have accessed my courses")]
        public void GivenIHaveAccessedMyCourses()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetYourCoursesUrl(); 
        }
        
        [Then(@"I want to view the course details")]
        public void ThenIWantToViewTheCourseDetails()
        {
            //ScenarioContext.Current.Pending();
            ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }
        
        [Then(@"a link to view the course description link")]
        public void ThenALinkToViewTheCourseDescriptionLink()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.CheckViewCourseDescription();
        }
    }
}
