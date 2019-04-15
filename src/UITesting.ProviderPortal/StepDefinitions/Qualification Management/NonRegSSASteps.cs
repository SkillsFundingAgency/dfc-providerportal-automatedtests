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
        
       /* [Then(@"Level filter and Category filter dropdown should be visible")]
        public void ThenLevelFilterAndCategoryFilterDropdownShouldBeVisible()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ValidateLevelFilter();
            unKnownZCodePage.ValidateCategoryFilter();
        }*/
        [Then(@"Level filter and Category filter selections should be visible")]
        public void ThenLevelFilterAndCategoryFilterSelectionsShouldBeVisible()
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
        [When(@"I have selected the first checkbox in Level filter Level")]
        public void WhenIHaveSelectedTheFirstCheckboxInLevelFilterLevel()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.SelectFilterLevel();
        }

        [When(@"I have selected the first checkbox in Category Filter")]
        public void WhenIHaveSelectedTheFirstCheckboxInCategoryFilter()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.SelectCategoryLevel();
        }

        [Then(@"a reset link should be visible")]
        public void ThenAResetLinkShouldBeVisible()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ViewResetLink();
        }

        [When(@"I Click the reset link")]
        public void WhenIClickTheResetLink()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ClickResetLink();
        }

        [Then(@"all the checkboxes in Level and category filter should be visible")]
        public void ThenAllTheCheckboxesInLevelAndCategoryFilterShouldBeVisible()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the selected checkboxes should be deselected\.")]
        public void ThenTheSelectedCheckboxesShouldBeDeselected_()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.CheckBoxDeselect();
        }

    }
}
