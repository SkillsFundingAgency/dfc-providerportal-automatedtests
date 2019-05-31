using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Provider_Management;


namespace UITesting.ProviderPortal.StepDefinitions
{
    [Binding]
    public class SearchProviderSteps : TestSupport.BaseTest
    {
        [Given(@"I have navigated to the Search Provider Page")]
        public void GivenIAmOnSearchAProviderPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl();
        }


        [When(@"I enter (.*) and click search provider")]
        public void WhenIEnterAndClickSearchProvider(string UKPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(UKPRN);
            searchProviderPage.ClickSearchButton();
        }

        [When(@"I click to view my courses")]
        public void WhenIClickToViewMyCourses()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }

        [Then(@"(.*) providers is displayed in the search results")]
        public void ThenProvidersIsDisplayedInTheSearchResults(int results)
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"the UKPRN for the provider is (.*)")]
        public void ThenTheUKPRNForTheProviderIs(string UKPRN)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"No results message is displayed in the search results")]
        public void ThenNoResultsMessageIsDisplayedInTheSearchResults()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Name for the provider is (.*)")]
        public void ThenTheNameForTheProviderIs(string provider)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the view link")]
        public void WhenIClickTheViewLink()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"provider details page is displayed")]
        public void ThenProviderDetailsPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
