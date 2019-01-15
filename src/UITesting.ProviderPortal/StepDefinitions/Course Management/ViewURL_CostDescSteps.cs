using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class ViewURL_CostDescSteps : BaseTest 
    {
        [Given(@"I have accessed course directory")]
        public void GivenIHaveAccessedCourseDirectory()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }
        
        [Given(@"I have entered ""(.*)"" and clicked search provider")]
        public void GivenIHaveEnteredAndClickedSearchProvider(string UKPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(UKPRN);
            searchProviderPage.ClickSearchButton();
            searchProviderPage.ClickViewCoursesButton();
        }
        
        [Given(@"I have clicked view URL Link")]
        public void GivenIHaveClickedViewURLLink()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ClickViewURL();
        }
        
        [Given(@"I have clicked the Course Cost description")]
        public void GivenIHaveClickedTheCourseCostDescription()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ClickCourseCostDescriptionLink();
        }
        
        [When(@"I click close url")]
        public void WhenIClickCloseUrl()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.CloseURL();
        }
        
        [When(@"I click close cost description")]
        public void WhenIClickCloseCostDescription()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ClickCloseCostDescription();
        }
        
        [Then(@"I should be able to view the Course URL")]
        public void ThenIShouldBeAbleToViewTheCourseURL()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ViewCourseURL();
        }
        
        [Then(@"the URL text should not be editable")]
        public void ThenTheURLTextShouldNotBeEditable()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ConfirmURLReadOnly();
        }
        
        [Then(@"the URL text should be hidden")]
        public void ThenTheURLTextShouldBeHidden()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.HideURLText();
        }
        
        [Then(@"I should be able to view the course cost description")]
        public void ThenIShouldBeAbleToViewTheCourseCostDescription()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ViewCourseCostDetail();
        }
        
        [Then(@"the course cost description should not be editable")]
        public void ThenTheCourseCostDescriptionShouldNotBeEditable()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ConfirmCourseCostDescReadOnly();
        }
        
        [Then(@"the course cost description text should be hidden")]
        public void ThenTheCourseCostDescriptionTextShouldBeHidden()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.HideCostDescription();
        }
    }
}
