using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.ProviderPortal.Pages.Qualification_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Qualification_Management
{
    [Binding]
    public class NonRegSSASteps : BaseTest 
    {
        [Given(@"I have accessed the UnKnown Z Code Page")]
        public void GivenIHaveAccessedTheUnKnownZCodePage()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
        }
        
        [When(@"I click the Back Link")]
        public void WhenIClickTheBackLink()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ClickBackLink();
        }
        
        [When(@"I Select First Level and Second Level")]
        public void WhenISelectFirstLevelAndSecondLevel()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ClickFirstLevel();
            unKnownZCodePage.ClickSecondLevel();

        }
        
        [When(@"I click the Add this Provision link")]
        public void WhenIClickTheAddThisProvisionLink()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ClickAddThisProvision();
        }
        
        [When(@"select page (.*) from pagination")]
        public void WhenSelectPageFromPagination(string PgNum)
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.SelectPage(PgNum);
        }
        
        [Then(@"I should be able to view the First Level and Second Level dropdowns")]
        public void ThenIShouldBeAbleToViewTheFirstLevelAndSecondLevelDropdowns()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.CheckFirstLevelDropDown();
            unKnownZCodePage.CheckSecondLevelDropDown();
        }
        
        [Then(@"the Back Link should be visible")]
        public void ThenTheBackLinkShouldBeVisible()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.CheckBackLink();
        }
        
        [Then(@"Level filter and Category filter dropdown should be visible")]
        public void ThenLevelFilterAndCategoryFilterDropdownShouldBeVisible()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ValidateLevelFilter();
            unKnownZCodePage.ValidateCategoryFilter();
        }
        
        [Then(@"a link to add this provision should be visible")]
        public void ThenALinkToAddThisProvisionShouldBeVisible()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ValidateAddThisProvisionLink();
        }
    }
}
