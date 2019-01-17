using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management

{
    [Binding]
    public class DFC_6187ViewYourCourses_Line1Steps : BaseTest 
    {
        [Given(@"I have accessed the course directory as a provider")]
        public void GivenIHaveAccessedTheCourseDirectoryAsAProvider()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }
        
        [Given(@"I have entered (.*) and click search provider")]
        public void GivenIHaveEnteredAndClickSearchProvider(string ukPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(ukPRN);
            searchProviderPage.ClickSearchButton();
            searchProviderPage.ClickViewCoursesButton();
        }
        
        [Then(@"I want to view the course details")]
        public void ThenIWantToViewTheCourseDetails()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);

        }
        
        [Then(@"a link to view the course description link")]
        public void ThenALinkToViewTheCourseDescriptionLink()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ClickMainDiplomaDetail();
            viewYourCoursesPage.CheckViewCourseDescription();
        }
    }
}
