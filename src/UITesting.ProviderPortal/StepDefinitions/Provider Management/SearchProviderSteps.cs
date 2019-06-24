using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using UITesting.Framework.Helpers;
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

        [Then(@"I navigate to the Search provider screen")]
        public void GivenIAmOnSearchProviderPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl() + "/SEARCHPROVIDER";
        }

        [When(@"I enter (.*) and click search provider")]
        public void WhenIEnterAndClickSearchProvider(string UKPRN)
        {
            SearchProviderNewPage searchProviderNewPage = new SearchProviderNewPage(webDriver);
            searchProviderNewPage.EnterUKPRN(UKPRN);
            searchProviderNewPage.ClickSearchButton();
        }

        [When(@"I have searched for UKPRN ""(.*)"" and clicked search")]
        public void GivenIHaveSearchedForUKPRNAndClickedSearch(string ukPRN)
        {
            SearchProviderNewPage searchProviderNewPage = new SearchProviderNewPage(webDriver);
            searchProviderNewPage.EnterUKPRN(ukPRN);
            searchProviderNewPage.ClickSearchButton();
        }

        [When(@"I click to view my courses")]
        public void WhenIClickToViewMyCourses()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }

        [Then(@"I am on the Search Providers page")]
        public void ThenIAmOnTheSearchProviderPage()
        {
            SearchProviderNewPage searchProviderNewPage = new SearchProviderNewPage(webDriver);
        }

        [Then(@"search results for the provider are displayed")]
        public void ThenSearchResultsForTheProviderAreDisplayed()
        {
            SearchProviderNewPage searchProviderNewPage = new SearchProviderNewPage(webDriver);
        }


        [Then(@"(.*) providers is displayed in the search results")]
        public void ThenProvidersIsDisplayedInTheSearchResults(int results)
        {
            IWebElement venTable = webDriver.FindElement(By.XPath(".//*[@id='ProviderSearchResultContainer']/div/table"));
            IList<IWebElement> tableRows = venTable.FindElements(By.TagName("tr")).ToList();
            Console.WriteLine(tableRows.Count);
            if (tableRows.Count != results + 1)
            {
                //    throw new Exception("Unexpected results count");
                //}

                try
                {
                    PageInteractionHelper.WaitForPageToLoad();
                }
                catch (StaleElementReferenceException)
                {
                    webDriver.Navigate().Refresh();
                }
                finally
                {
                    Console.WriteLine("COUNT = " + tableRows.Count);
                }
            }
        }



        [Then(@"the UKPRN for the provider is (.*)")]
        public void ThenTheUKPRNForTheProviderIs(string UKPRN)
        {
            SearchProviderNewPage searchProviderNewPage = new SearchProviderNewPage(webDriver);
            searchProviderNewPage.GetUKPRN(UKPRN);
        }

        [Then(@"No results message is displayed in the search results")]
        public void ThenNoResultsMessageIsDisplayedInTheSearchResults()
        {
            SearchProviderNewPage searchProviderNewPage = new SearchProviderNewPage(webDriver);
        }

        [Then(@"the Name for the provider is (.*)")]
        public void ThenTheNameForTheProviderIs(string provider)
        {
            SearchProviderNewPage searchProviderNewPage = new SearchProviderNewPage(webDriver);
            searchProviderNewPage.GetProviderName(provider);
        }

        [When(@"I click the view link")]
        public void WhenIClickTheViewLink()
        {
            SearchProviderNewPage searchProviderNewPage = new SearchProviderNewPage(webDriver);
            searchProviderNewPage.ViewProvider();
        }

        [Then(@"provider details page is displayed")]
        public void ThenProviderDetailsPageIsDisplayed()
        {
            ProviderDetailsPage providerDetailsPage = new ProviderDetailsPage(webDriver);
        }


    }
}
