using System;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Apprenticeships;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.Apprenticeships
{
    [Binding]
    public class COUR_387AddClassromDeliveryMethodForApprenticeshipSteps  : BaseTest 
    {
        [Given(@"I have selected a venue from the Location dropdown")]
        public void GivenIHaveSelectedAVenueFromTheLocationDropdown()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.SelectVenue("");
        }
        
        [Given(@"I have selected Day release as delivery mode")]
        public void GivenIHaveSelectedDayReleaseAsDeliveryMode()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.SelectDayRelease();
        }
        
        [Given(@"I have selected Block release as delivery mode")]
        public void GivenIHaveSelectedBlockReleaseAsDeliveryMode()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.SelectBlockRelease();
        }
        
        [Given(@"I have selected Day Release and Block release as delivery mode")]
        public void GivenIHaveSelectedDayReleaseAndBlockReleaseAsDeliveryMode()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.SelectDayRelease();
            classroomDeliveryOptionPage.SelectBlockRelease();
        }
        
        [When(@"I click SaveandContinue")]
        public void WhenIClickSaveandContinue()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.ClickSaveandContinue();
        }
        
        [When(@"I click SaveandAddAnother")]
        public void WhenIClickSaveandAddAnother()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.ClickSaveandAddAnother();
        }
        
        [Then(@"the Apprenticeship Summary Screen should be displayed")]
        public void ThenTheApprenticeshipSummaryScreenShouldBeDisplayed()
        {
            ConfirmDetailsPage confirmDetailsPage = new ConfirmDetailsPage(webDriver);
        }
        
        [Then(@"the Apprenticeship delivery Screen should be displayed")]
        public void ThenTheApprenticeshipDeliveryScreenShouldBeDisplayed()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
        }
        [Given(@"I have not selected a venue")]
        public void GivenIHaveNotSelectedAVenue()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.SelectVenue("Please select");
        }

        [Then(@"Location error message should be displayed ""(.*)""")]
        public void ThenLocationErrorMessageShouldBeDisplayed(string errMsg)
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.VerifyLocationErrMessage(errMsg);
        }

        [Then(@"Delivery Mode error message should be displayed ""(.*)""")]
        public void ThenDeliveryModeErrorMessageShouldBeDisplayed(string errMsg)
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
            classroomDeliveryOptionPage.VerifyDeliveryOptionErrMessage(errMsg);
        }

    }
}
