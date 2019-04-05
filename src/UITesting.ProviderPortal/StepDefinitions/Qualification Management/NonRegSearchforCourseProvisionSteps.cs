using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.ProviderPortal.Pages.Qualification_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Qualification_Management
{
    [Binding]
    public class NonRegSearchforCourseProvisionSteps : BaseTest
    {
        [Given(@"I have accessed the Unregulated courses page")]
        public void GivenIHaveAccessedTheUnregulatedCoursesPage()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
        }
        [When(@"I Navigate to Regulated Qualifications page")]
        public void WhenINavigateToRegulatedQualificationsPage()
        {
            webDriver.Url= Configurator.GetConfiguratorInstance().GetBaseUrl() + "/RegulatedQualification";
        }

        [Given(@"I click the Back Link on the unregulated courses page")]
        public void GivenIClickTheBackLinkOnTheUnregulatedCoursesPage()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.ClickUnRegBackLink();
        }
        
        [Given(@"I have entered a valid Z code ""(.*)""")]
        public void GivenIHaveEnteredAValidZCode(string strZCode)
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.EnterZCode(strZCode);
        }
        
        [Given(@"I click the search button")]
        public void GivenIClickTheSearchButton()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.clickSearch();
        }
        
        [Given(@"I have entered a blank Z code ""(.*)""")]
        public void GivenIHaveEnteredABlankZCode(string strZCode)
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.EnterZCode(strZCode);
        }
        
        [Given(@"I have entered a z code ""(.*)""")]
        public void GivenIHaveEnteredAZCode(string strZCode)
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.EnterZCode(strZCode);
        }
        
       /* [Given(@"I have entered a z code ""(.*)""")]
        public void GivenIHaveEnteredAZCode(string p0)
        {
            ScenarioContext.Current.Pending();
        }*/
        
        [Given(@"I have clicked  I dont know z code link")]
        public void GivenIHaveClickedIDontKnowZCodeLink()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.clickDontKnowZCode();
        }
        
        [When(@"I have selected Non Regulated Option and Clicked Next")]
        public void WhenIHaveSelectedNonRegulatedOptionAndClickedNext()
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
            regulatedQualificationPage.SelectNonRegulatedOption();
            regulatedQualificationPage.ClickNext();
        }
        
        [When(@"i click Cancel Link")]
        public void WhenIClickCancelLink()
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
            unRegulatedCoursesResultsPage.clickCancelLink();
        }
        
        [When(@"i click Back Link on the Un regulated courses results page")]
        public void WhenIClickBackLinkOnTheUnRegulatedCoursesResultsPage()
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
            unRegulatedCoursesResultsPage.ClickBackLink();
        }
        
        [Then(@"the Unregulated courses page should be displayed")]
        public void ThenTheUnregulatedCoursesPageShouldBeDisplayed()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
        }
        
        [Then(@"a Back Link should be visible")]
        public void ThenABackLinkShouldBeVisible()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.ValidateBackLink();
        }
        
        [Then(@"a text box to enter a Z code should be visble")]
        public void ThenATextBoxToEnterAZCodeShouldBeVisble()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.ValidateZSearchCodeText();
        }
        
        [Then(@"a I don't know the Z code link should be visible")]
        public void ThenAIDonTKnowTheZCodeLinkShouldBeVisible()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.ValidateUnknownZCodeLink();
        }
        
        [Then(@"the Regulated Qualifications page should be displayed")]
        public void ThenTheRegulatedQualificationsPageShouldBeDisplayed()
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
        }
        
        [Then(@"I should be able to view the Non regulated course results page")]
        public void ThenIShouldBeAbleToViewTheNonRegulatedCourseResultsPage()
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
        }
        
        [Then(@"I should be able to view the Choose button and the Cancel Link")]
        public void ThenIShouldBeAbleToViewTheChooseButtonAndTheCancelLink()
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
            unRegulatedCoursesResultsPage.ValidateChooseButton();
            unRegulatedCoursesResultsPage.ValidateCancelLink();
        }
        
        [Then(@"an blank z code error message should be displayed ""(.*)""")]
        public void ThenAnBlankZCodeErrorMessageShouldBeDisplayed(string errMsg)
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
            unRegulatedCoursesResultsPage.ValidateErrorMessage(errMsg);
        }
        
        [Then(@"an error message should be displayed ""(.*)""")]
        public void ThenAnErrorMessageShouldBeDisplayed(string ErrMsg)
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
            unRegulatedCoursesResultsPage.ValidateErrorMessage(ErrMsg);
        }
        
        [Then(@"an unavailable Z Code error message should be displayed ""(.*)""")]
        public void ThenAnUnavailableZCodeErrorMessageShouldBeDisplayed(string errMsg)
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
            unRegulatedCoursesResultsPage.ValidateDoesNotexistErrorMessage(errMsg);
        }
        
        [Then(@"I should be able to view the Un regulated courses results page")]
        public void ThenIShouldBeAbleToViewTheUnRegulatedCoursesResultsPage()
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);

        }
        
        [Then(@"I click the choose button")]
        public void ThenIClickTheChooseButton()
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
            unRegulatedCoursesResultsPage.ClickChooseButton();
        }
        [Then(@"add course page should be displayed")]
        public void ThenAddCoursePageShouldBeDisplayed()
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
        }

        [Then(@"add course run should be displayed")]
        public void ThenAddCourseRunShouldBeDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
        }

        /*[Then(@"add course page (.*) should be displayed")]
        public void ThenAddCoursePageShouldBeDisplayed(int p0)
        {
            ScenarioContext.Current.Pending();
        }*/
        
        [Then(@"the course should be listed in the Your courses page")]
       public void ThenTheCourseShouldBeListedInTheYourCoursesPage()
        {
            AddCourseSummaryPage addCourseSummaryPage = new AddCourseSummaryPage(webDriver);
            addCourseSummaryPage.ClickNext();
        }
        
        [Then(@"Unregulated course page should be displayed")]
        public void ThenUnregulatedCoursePageShouldBeDisplayed()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
        }
        
        [Then(@"the Z code text box should be empty")]
        public void ThenTheZCodeTextBoxShouldBeEmpty()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.validateZCodeTextBlank();
        }
        
        [Then(@"I should be able to view the Non regulated course details")]
        public void ThenIShouldBeAbleToViewTheNonRegulatedCourseDetails()
        {
            UnRegulatedCoursesResultsPage unRegulatedCoursesResultsPage = new UnRegulatedCoursesResultsPage(webDriver);
        }
        
        [Then(@"Unknown Z code page should be displayed")]
        public void ThenUnknownZCodePageShouldBeDisplayed()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
        }
    }
}
