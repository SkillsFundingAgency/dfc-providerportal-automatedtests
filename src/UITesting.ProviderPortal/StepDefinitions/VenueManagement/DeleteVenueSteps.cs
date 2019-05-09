using System;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class DeleteVenueSteps : BaseTest
    {
        [Given(@"I have searched for ""(.*)""")]
        public void GivenIHaveSearchedFor(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            if (deleteVenuePage.CheckVenuePresent(strVenueName) == false)
            {
                ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
                viewAllLiveVenuesPage.ClickAddVenueButton();
                AddVenuePage addVenuePage = new AddVenuePage(webDriver);
                addVenuePage.ClickEnterAddressManuallyLink();
                AddVenueManualAddressPage addVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
                addVenueManualAddressPage.AddVenueName(strVenueName);
                addVenueManualAddressPage.AddAddressLine1("Line 1 Del Venue");
                addVenueManualAddressPage.AddTownCity("Del Venue City");
                addVenueManualAddressPage.AddPostCode("CV1 2WT");
                addVenueManualAddressPage.ClickContinue();
                AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
                addVenueConfirmAddressPage.ClickContinue();
            }
            deleteVenuePage.CheckVenuePresent(strVenueName);
        }
        
        [Given(@"clicked the delete link for ""(.*)""")]
        public void GivenClickedTheDeleteLinkFor(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ClickDeleteLink(strVenueName);
        }
        
        [Given(@"I have clicked the cancel link for ""(.*)""")]
        public void GivenIHaveClickedTheCancelLinkFor(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have clicked the confirm delete button")]
        public void WhenIHaveClickedTheConfirmDeleteButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see a Edit and Delete Link")]
        public void ThenIShouldBeAbleToSeeAEditAndDeleteLink()
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ValidateEditandDeleteLink();
        }
        
        [Then(@"I should be able to see a confirm delete button and a cancel link")]
        public void ThenIShouldBeAbleToSeeAConfirmDeleteButtonAndACancelLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Venue ""(.*)"" should not be deleted")]
        public void ThenVenueShouldNotBeDeleted(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the venue should be deleted ""(.*)""")]
        public void ThenTheVenueShouldBeDeleted(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a delete message should be displayed ""(.*)""")]
        public void ThenADeleteMessageShouldBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the venue ""(.*)"" should not be deleted")]
        public void ThenTheVenueShouldNotBeDeleted(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a message should be displayed ""(.*)""")]
        public void ThenAMessageShouldBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
