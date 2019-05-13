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
           // deleteVenuePage.CheckVenuePresent(strVenueName);
        }
        
        [Given(@"clicked the delete link for ""(.*)""")]
        public void GivenClickedTheDeleteLinkFor(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ClickDeleteLink(strVenueName);
        }
        
        [Given(@"I have clicked the cancel link for ""(.*)""")]
        public void GivenIHaveClickedTheCancelLinkFor(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ClickCancelLink(strVenueName);
        }

        [When(@"I have clicked the confirm delete button for ""(.*)""")]
        public void WhenIHaveClickedTheConfirmDeleteButtonFor(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.DeleteVenue(strVenueName);
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
        
        [Then(@"a delete message should be displayed ""(.*)""")]
        public void ThenADeleteMessageShouldBeDisplayed(string ErrMsg)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ValidateDeleteMessage(ErrMsg);
        }
        
        [Then(@"the venue ""(.*)"" should not be deleted")]
        public void ThenTheVenueShouldNotBeDeleted(string strVenueName)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.CheckVenuePresent(strVenueName);
        }
        
        [Then(@"a message should be displayed ""(.*)""")]
        public void ThenAMessageShouldBeDisplayed(string ErrMsg)
        {
            DeleteVenuePage deleteVenuePage = new DeleteVenuePage(webDriver);
            deleteVenuePage.ValidateMessage(ErrMsg);
        }
        [Given(@"there is a course associated with the venue ""(.*)""")]
        public void GivenThereIsACourseAssociatedWithTheVenue(string strVenueName)
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl() + "/ProviderCourses/Index";
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ClickSelect();
            CourseSummaryPage courseSummaryPage = new CourseSummaryPage(webDriver);
            courseSummaryPage.ClickEditCourseRun();
            EditCourseRunDetails_YC3Page editCourseRunDetails_YC3Page = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetails_YC3Page.SelectDeliveryMode("Classroom");
            editCourseRunDetails_YC3Page.SelectFlexibleStartDate();
            editCourseRunDetails_YC3Page.SelectVenueByName(strVenueName);
            editCourseRunDetails_YC3Page.EnterCost("2000.00");
            editCourseRunDetails_YC3Page.EnterDuration("6");
            editCourseRunDetails_YC3Page.SelectAttendancePattern("Full-Time");
            editCourseRunDetails_YC3Page.SelectAttendance("Daytime");
            editCourseRunDetails_YC3Page.SaveData();
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrlVenues();
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
        }


    }
}
