using System;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class AddVenue_Add_Edit_CopyCourseSteps : BaseTest
    {
        [Given(@"I have entered the following in Course description ""(.*)""")]
        public void GivenIHaveEnteredTheFollowingInCourseDescription(string strCourseDesc)
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
            addCoursePage.EnterWhoCourseFor(strCourseDesc);
        }

        [Given(@"I have clicked Next")]
        public void GivenIHaveClickedNext()
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
            addCoursePage.ClickNext();
        }

        [Given(@"I have selected Delivery Mode as ""(.*)""")]
        public void GivenIHaveSelectedDeliveryModeAs(string strDeliveryMode)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectDeliveryMode(strDeliveryMode);
        }

        [Given(@"I have selected start date as ""(.*)""")]
        public void GivenIHaveSelectedStartDateAs(string strStartDate)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectStartDateType(strStartDate);
        }

        [Given(@"I have added a new Venue ""(.*)""")]
        public void GivenIHaveAddedANewVenue(string strVenueName)
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.ClickEnterAddressManuallyLink();
            AddVenueManualAddressPage addVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            addVenueManualAddressPage.AddVenueName(strVenueName);
            addVenueManualAddressPage.AddAddressLine1("Line 1 Del Venue");
            addVenueManualAddressPage.AddTownCity("Del Venue City");
            addVenueManualAddressPage.AddPostCode("CV1 2WT");
            addVenueManualAddressPage.ClickContinue();
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
            addVenueConfirmAddressPage.ClickConfirmContinue();
        }

       /* [Given(@"I have entered a postcode ""(.*)"" and clicked Find Address")]
        public void GivenIHaveEnteredAPostcodeAndClickedFindAddress(string strPostCode)
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.EnterPostCode(strPostCode);
            addVenuePage.ClickFindAddress();
        }

        [Given(@"i have selected an address from the dropdown When I select the address and clicked Continue ""(.*)""")]
        public void GivenIHaveSelectedAnAddressFromTheDropdownWhenISelectTheAddressAndClickedContinue(string strAddress)
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.selectAddress(strAddress);
            addVenueSelectAddressPage.ClickContinueConfirm();
        }
        
        [Given(@"I have clicked continue in confirm Venue screen")]
        public void GivenIHaveClickedContinueInConfirmVenueScreen()
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.ClickContinue();
        }*/
        
        [Given(@"I have selected ""(.*)"" as venue")]
        public void GivenIHaveSelectedAsVenue(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered as cost ""(.*)""")]
        public void GivenIHaveEnteredAsCost(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected ""(.*)"" as attendance")]
        public void GivenIHaveSelectedAsAttendance(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have clicked Review your changes")]
        public void GivenIHaveClickedReviewYourChanges()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have clicked Accept and Publish")]
        public void GivenIHaveClickedAcceptAndPublish()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected a course")]
        public void GivenIHaveSelectedACourse()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the link to Add New Venue")]
        public void WhenISelectTheLinkToAddNewVenue()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.ClickAddNewVenueLink();
        }
        
        [When(@"I clicked the Edit course information")]
        public void WhenIClickedTheEditCourseInformation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I clicked the Copy Course")]
        public void WhenIClickedTheCopyCourse()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Page (.*) of Add Course should be displayed")]
        public void ThenThePageOfAddCourseShouldBeDisplayed(int p0)
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
        }
        
        [Then(@"Page (.*) of Add Course should be displayed")]
        public void ThenPageOfAddCourseShouldBeDisplayed(int p0)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
        }
        
        [Then(@"Add venue screen should be displayed\.")]
        public void ThenAddVenueScreenShouldBeDisplayed_()
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        }
        
        [Then(@"the venue ""(.*)"" should be present in the Venue List")]
        public void ThenTheVenueShouldBePresentInTheVenueList(string strVenueName)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the course should be added")]
        public void ThenTheCourseShouldBeAdded()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
