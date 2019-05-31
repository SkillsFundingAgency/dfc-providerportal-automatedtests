using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Bulk_Upload;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Apprenticeships;


namespace UITesting.ProviderPortal.StepDefinitions.Apprenticeships
{
    [Binding]
    public class ApprenticeshipSteps : TestSupport.BaseTest
    {
        [Given(@"I have accessed the Apprenticeship Search page")]
        public void GivenIAmOnApprenticeshipSearch()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl() + "/apprenticeships";
        }

        [When(@"I use apprenticeship search to search for (.*)")]
        public void WhenIUseApprenticeshipSearchToSearchForTest(string searchTerm)
        {
            SearchApprenticeshipPage apprenticeshipSearchPage = new SearchApprenticeshipPage(webDriver);
            apprenticeshipSearchPage.EnterSearchTerm(searchTerm);
        }

        [Then(@"the No Results error message is displayed")]
        public void ThenTheNoResultsErrorMessageIsDisplayed()
        {
            SearchApprenticeshipPage apprenticeshipSearchPage = new SearchApprenticeshipPage(webDriver);
            apprenticeshipSearchPage.NoResultsMsg();
        }

        [Then(@"the Results are displayed")]
        public void ThenTheResultsAreDisplayed()
        {
            SearchApprenticeshipPage apprenticeshipSearchPage = new SearchApprenticeshipPage(webDriver);
            apprenticeshipSearchPage.ResultsReturned();
        }

        [Then(@"Each result displays the apprenticeship details")]
        public void DisplaysTheApprenticeshipDetails()
        {
            SearchApprenticeshipPage apprenticeshipSearchPage = new SearchApprenticeshipPage(webDriver);
            apprenticeshipSearchPage.ConfirmApprenticeshipDetail();
        }

        [Then(@"the Framework label is present")]
        public void ThenTheFrameworkLabelIsPresent()
        {
            SearchApprenticeshipPage apprenticeshipSearchPage = new SearchApprenticeshipPage(webDriver);
            apprenticeshipSearchPage.FrameworkLabel();
        }

        [Then(@"the user select the apprenticeship")]
        public void SelectTheApprenticeship()
        {
            SearchApprenticeshipPage apprenticeshipSearchPage = new SearchApprenticeshipPage(webDriver);
            apprenticeshipSearchPage.SelectApprenticeship();
        }

        [When(@"I press continue on the National provider capability page")]
        public void WhenIPressContinueOnTheNationalProviderCapabilityPage()
        {
            NationalProviderCapabilityPage nationalProviderCapabilityPage = new NationalProviderCapabilityPage(webDriver);
            nationalProviderCapabilityPage.ContinueError();
        }

        [Then(@"the error message should be displayed (.*)")]
        public void ThenTheErrorMessageShouldBeDisplayed()
        {
            NationalProviderCapabilityPage nationalProviderCapabilityPage = new NationalProviderCapabilityPage(webDriver);
            nationalProviderCapabilityPage.ErrorDisplayed();
        }

        [When(@"i  select yes to National provider")]
        public void WhenISelectYesToNationalProvider()
        {
            NationalProviderCapabilityPage nationalProviderCapabilityPage = new NationalProviderCapabilityPage(webDriver);
            nationalProviderCapabilityPage.clickYes();
        }

        [When(@"i  select no to National provider")]
        public void WhenISelectNoToNationalProvider()
        {
            NationalProviderCapabilityPage nationalProviderCapabilityPage = new NationalProviderCapabilityPage(webDriver);
            nationalProviderCapabilityPage.clickNo();
        }

        [When(@"I press continue on the National provider capability page yes")]
        public void WhenIPressContinueOnTheNationalProviderCapabilityPageYes()
        {
            NationalProviderCapabilityPage nationalProviderCapabilityPage = new NationalProviderCapabilityPage(webDriver);
            nationalProviderCapabilityPage.ContinueYes();
        }

        [When(@"I press continue on the National provider capability page no")]
        public void WhenIPressContinueOnTheNationalProviderCapabilityPageNo()
        {
            NationalProviderCapabilityPage nationalProviderCapabilityPage = new NationalProviderCapabilityPage(webDriver);
            nationalProviderCapabilityPage.ContinueNo();
        }

        [Then(@"I am on the confirm details page")]
        public void ThenIAmOnTheConfirmDetailsPage()
        {
            ConfirmDetailsPage confirmDetailsPage = new ConfirmDetailsPage(webDriver);
        }

        [Then(@"I am on the employer based delivery page")]
        public void ThenIAmOnTheEmployerBasedDeliveryPage()
        {
            EmployerBasedDeliveryPage employerBasedDeliveryPage = new EmployerBasedDeliveryPage(webDriver);
        }


    }

}
