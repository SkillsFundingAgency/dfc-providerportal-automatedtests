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
        public void ThenTheErrorMessageShouldBeDisplayed(string errorMsg)
        {
            NationalProviderCapabilityPage nationalProviderCapabilityPage = new NationalProviderCapabilityPage(webDriver);
            nationalProviderCapabilityPage.ErrorDisplayed(errorMsg);
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


        [Then(@"I close the (.*) region")]
        [When(@"I expand the (.*) region")]
        public void WhenIExpandTheEastMidlandsRegions(string region)
        {
            EmployerBasedDeliveryPage employerBasedDeliveryPage = new EmployerBasedDeliveryPage(webDriver);
            employerBasedDeliveryPage.SelectRegion(region);
        }

        [When(@"I select the first sub-region")]
        public void WhenISelectTheFirstSub_Region()
        {
            EmployerBasedDeliveryPage employerBasedDeliveryPage = new EmployerBasedDeliveryPage(webDriver);
            employerBasedDeliveryPage.SelectFirstSubRegion();
        }

        [When(@"I select the all sub-regions")]
        public void WhenISelectTheAllSubRegions()
        {
            EmployerBasedDeliveryPage employerBasedDeliveryPage = new EmployerBasedDeliveryPage(webDriver);
            employerBasedDeliveryPage.SelectAllSubRegion();
        }

        [When(@"I click Continue on Add employer based delivery")]
        public void WhenIClickContinueOnAddEmployerBasedDelivery()
        {
            EmployerBasedDeliveryPage employerBasedDeliveryPage = new EmployerBasedDeliveryPage(webDriver);
            employerBasedDeliveryPage.ClickContinue();
        }

        #region classroom and employer based delivery

        [When(@"I select (.*) option")]
        public void WhenISelectDayRelease(string option)
        {
            ClassroomAndEmployerDeliveryOptionPage classroomAndEmployerDeliveryOptionPage = new ClassroomAndEmployerDeliveryOptionPage(webDriver);
            classroomAndEmployerDeliveryOptionPage.SelectOption(option);
        }

        [When(@"I select a location")]
        public void WhenISelectALocation()
        {
            ClassroomAndEmployerDeliveryOptionPage classroomAndEmployerDeliveryOptionPage = new ClassroomAndEmployerDeliveryOptionPage(webDriver);
            classroomAndEmployerDeliveryOptionPage.SelectFirstLocation();
        }

        [When(@"I enter (.*) miles in radius field")]
        public void WhenIEnterMilesInRadiusField(string radius)
        {
            ClassroomAndEmployerDeliveryOptionPage classroomAndEmployerDeliveryOptionPage = new ClassroomAndEmployerDeliveryOptionPage(webDriver);
            classroomAndEmployerDeliveryOptionPage.EnterRadius(radius);
        }

        [When(@"I click Add another")]
        public void WhenIClickAddAnother()
        {
            ClassroomAndEmployerDeliveryOptionPage classroomAndEmployerDeliveryOptionPage = new ClassroomAndEmployerDeliveryOptionPage(webDriver);
            classroomAndEmployerDeliveryOptionPage.ClickAddAnother();
        }

        [When(@"I click Save and Continue")]
        public void WhenIClickSave()
        {
            ClassroomAndEmployerDeliveryOptionPage classroomAndEmployerDeliveryOptionPage = new ClassroomAndEmployerDeliveryOptionPage(webDriver);
            classroomAndEmployerDeliveryOptionPage.ClickSave();
        }

        [When(@"I add (.*) locations for an apprenticeship")]
        public void WhenIAddLocationsForAnApprenticeship(int numOfReps)
        {

            int i = 0;
            ClassroomAndEmployerDeliveryOptionPage classroomAndEmployerDeliveryOptionPage = new ClassroomAndEmployerDeliveryOptionPage(webDriver);

            do
            {
                classroomAndEmployerDeliveryOptionPage.SelectOption("Day Release");
                classroomAndEmployerDeliveryOptionPage.SelectFirstLocation();
                classroomAndEmployerDeliveryOptionPage.EnterRadius("10");
                classroomAndEmployerDeliveryOptionPage.ClickAddAnother();
                System.Console.WriteLine("repitition " + i);

                i++;

            } while (i < numOfReps);

           System.Threading.Thread.Sleep(999999999);                                                       
        }


        #endregion classroom and employer based delivery


        [When(@"I click publish apprenticeship")]
        public void WhenIClickPublishApprenticeship()
        {
            ConfirmDetailsPage confirmDetailsPage = new ConfirmDetailsPage(webDriver);
            confirmDetailsPage.ClickPublish();
        }

        [Then(@"I am on apprenticeship published page")]
        public void ThenIAmOnApprenticeshipPublishedPage()
        {
            AppPublishedPage appPublishedPage = new AppPublishedPage(webDriver);
        }



    }

}
