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
        [Given(@"I have clicked the delete link for Venue ""(.*)""")]
        public void GivenIHaveClickedTheDeleteLinkForVenue(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            if (deleteVenuePage.CheckVenuePresent(strVenueName)==false)
            {
                AddVenuePage addVenuePage = new AddVenuePage(webDriver);
                addVenuePage.EnterVenueName(strVenueName);
                addVenuePage.EnterPostCode("CV1 2WT");
                addVenuePage.ClickFindAddress();
                AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
                addVenueSelectAddressPage.selectAddress(;
            }

        }
        
        [Given(@"I have clicked the delete link")]
        public void GivenIHaveClickedTheDeleteLink()
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ClickDeleteLink();
        }
        
        [Given(@"I have clicked the cancel link")]
        public void GivenIHaveClickedTheCancelLink()
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ClickCancelLink();
        }
        
        [When(@"I have clicked the confirm delete button")]
        public void WhenIHaveClickedTheConfirmDeleteButton()
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ClickConfirmDelete();
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
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ValidateConfirmDeleteandCancelLink();
        }
        
        [Then(@"Venue ""(.*)"" should not be deleted")]
        public void ThenVenueShouldNotBeDeleted(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.CheckVenuePresent(strVenueName);
        }

        [Then(@"the venue should be deleted ""(.*)""")]
        public void ThenTheVenueShouldBeDeleted(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.CheckVenueNotPresent(strVenueName);
        }

       /* [Then(@"the venue should be deleted")]
        public void ThenTheVenueShouldBeDeleted()
        {
            
        }*/
        
        [Then(@"a message should be displayed ""(.*)""")]
        public void ThenAMessageShouldBeDisplayed(string strMsg)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ValidateMessage(strMsg);
        }
        [Then(@"a delete message should be displayed ""(.*)""")]
        public void ThenADeleteMessageShouldBeDisplayed(string strMsg)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ValidateDeleteMessage(strMsg);
        }
        [Then(@"a delete message should be displayed ""(.*)""")]
        

        [Then(@"the venue ""(.*)"" should not be deleted")]
        public void ThenTheVenueShouldNotBeDeleted(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.CheckVenuePresent(strVenueName);
        }


       /* [Then(@"the venue should not be deleted")]
        public void ThenTheVenueShouldNotBeDeleted()
        {
            ScenarioContext.Current.Pending();
        }*/
    }
}
