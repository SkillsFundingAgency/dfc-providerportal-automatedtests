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

            // create unique venue name and store in scenrio context to re-use later
            strVenueName = strVenueName + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            ScenarioContext.Current["venue name"] = strVenueName;

            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.ClickEnterAddressManuallyLink();
            AddVenueManualAddressPage addVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            addVenueManualAddressPage.AddVenueName(strVenueName);
            addVenueManualAddressPage.AddAddressLine1("Line 1 Del Venue");
            addVenueManualAddressPage.AddTownCity("Del Venue City");
            addVenueManualAddressPage.AddPostCode("CV1 2WT");
            addVenueManualAddressPage.ClickContinue();
            PageInteractionHelper.WaitForPageToLoad();
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
            addVenueConfirmAddressPage.ClickConfirmContinue();
        }

        [Given(@"I have selected ""(.*)"" as venue from the Venue Checkbox List")]
        public void GivenIHaveSelectedAsVenueFromTheVenueCheckboxList(string strVenueName)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectCheckBoxByValue(ScenarioContext.Current["venue name"].ToString());
        }

        [Given(@"I have selected a course")]
        public void GivenIHaveSelectedACourse()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ClickSelect();
        }
        
        [Given(@"I have selected ""(.*)"" as venue from Venue Dropdown")]
        public void GivenIHaveSelectedAsVenueFromVenueDropdown(string strVenueName)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetails_YC3Page = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetails_YC3Page.SelectVenueByName(ScenarioContext.Current["venue name"].ToString());
        }

        [When(@"I select the link to Add New Venue in the Edit Screen")]
        public void WhenISelectTheLinkToAddNewVenueInTheEditScreen()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetails_YC3Page = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetails_YC3Page.ClickAddNewVenueLink();
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
            CourseSummaryPage courseSummaryPage = new CourseSummaryPage(webDriver);
            courseSummaryPage.ClickEditCourseRun();
        }
       
        
        [Then(@"the First Page of Add Course should be displayed")]
        public void ThenTheFirstPageOfAddCourseShouldBeDisplayed()
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
        }
        
        [Then(@"Second Page of Add Course should be displayed")]
        public void ThenSecondPageOfAddCourseShouldBeDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
        }
        
        [Then(@"Add venue screen should be displayed\.")]
        public void ThenAddVenueScreenShouldBeDisplayed_()
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        }
        
        [Then(@"the venue ""(.*)"" should be present in the Venue List")]
        public void ThenTheVenueShouldBePresentInTheVenueList(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Add Course Summary Page should be displayed")]
        public void ThenTheAddCourseSummaryPageShouldBeDisplayed()
        {
            AddCourseSummaryPage addCourseSummaryPage = new AddCourseSummaryPage(webDriver);
        }
        
        [Then(@"I have clicked Accept and Publish")]
        public void ThenIHaveClickedAcceptAndPublish()
        {
            AddCourseSummaryPage addCourseSummaryPage = new AddCourseSummaryPage(webDriver);
            addCourseSummaryPage.ClickNext();
        }
        



        [Then(@"the course should be added")]
        public void ThenTheCourseShouldBeAdded()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }

        [Then(@"the course should be deleted")]
        public void ThenTheCourseShouldBeDeleted()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
        }


        [Then(@"Second Page of Edit Course should be displayed")]
        public void ThenSecondPageOfEditCourseShouldBeDisplayed()
        {
            EditCourseRunDetails_YC3Page editCourseRunDetails_YC3Page = new EditCourseRunDetails_YC3Page(webDriver);

        }

        [Given(@"I Select study mode ""(.*)""")]
        public void GivenISelectStudyMode(string strStudyMode)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetails_YC3Page = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetails_YC3Page.SelectAttendancePattern(strStudyMode);
        }

        [Given(@"I Select attendance mode ""(.*)""")]
        public void GivenISelectAttendanceMode(string strAtt)
        {
            EditCourseRunDetails_YC3Page editCourseRunDetails_YC3Page = new EditCourseRunDetails_YC3Page(webDriver);
            editCourseRunDetails_YC3Page.SelectAttendance(strAtt);
        }

        [Given(@"I have selected a classrom course")]
        public void GivenIHaveSelectedAClassromCourse()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.EnterSearchTerm("Classroom");
            viewYourCoursesPage.ClickSelect();
        }

        [Then(@"Copy Course Page should be displayed")]
        public void ThenCopyCoursePageShouldBeDisplayed()
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
        }

        [When(@"I select the link to Add New Venue inthe copy course screen")]
        public void WhenISelectTheLinkToAddNewVenueIntheCopyCourseScreen()
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
            copyCoursePage.ClickAddNewVenueLink();
        }

        [When(@"I  Save the data in the copy course page")]
        public void WhenISaveTheDataInTheCopyCoursePage()
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
            copyCoursePage.ClickSave();
        }

        [Given(@"I have selected ""(.*)"" as venue from Venue Dropdown in the copy course page")]
        public void GivenIHaveSelectedAsVenueFromVenueDropdownInTheCopyCoursePage(string strVenueName)
        {
            CopyCoursePage copyCoursePage  = new CopyCoursePage(webDriver);
            copyCoursePage.SelectVenueByName(ScenarioContext.Current["venue name"].ToString());
        }

        [When(@"I click delete")]
        public void WhenIClickDelete()
        {
            CourseSummaryPage courseSummaryPage = new CourseSummaryPage(webDriver);
            courseSummaryPage.ClickDeleteConfirm();
        }


    }
}
