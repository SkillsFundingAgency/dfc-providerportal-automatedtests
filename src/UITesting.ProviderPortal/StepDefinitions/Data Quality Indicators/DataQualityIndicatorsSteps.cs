using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Data_Quality_Indicators;
using UITesting.ProviderPortal.Pages.Course_Management;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.StepDefinitions.Data_Quality_Indicators
{
    [Binding]
    public class DataQualityIndicatorsSteps : TestSupport.BaseTest
    {
        [Given(@"I click on the courses need their start date updated link")]
        public void GivenIAmOnBulkUploadPage()
        {
            DQIDashbordPage dQIDashbordPage = new DQIDashbordPage(webDriver);
            dQIDashbordPage.NavigateToDQI();
        }

          
        [Then(@"I am taken to the DQI page")]
        public void DQIFixAndPublishPage()
        {
            DQIFixPublishPage dQIFixAndPublish = new DQIFixPublishPage(webDriver);
        }


        [When(@"I click on the first course run requiring start date update")]
        //public void FixCourseRunStartDate()
        //{
        //    DQIFixPublishPage dQIFixPublishPage = new DQIFixPublishPage(webDriver);
        //    dQIFixPublishPage.FixCourseRun();
        //}
        public void FixStartDate()
        {
            IList<IWebElement> links = webDriver.FindElements(By.LinkText("Fix"));
            IList<IWebElement> listOflinks = new List<IWebElement>();

            for (int i = 0; i < links.Count; i++)
            {
                links = webDriver.FindElements(By.LinkText("Fix"));
                if (i == 0)
                    links[i].Click();
            }
        }

        [Then(@"I am take to Edit Course page")]
        public void DQIEdit()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
        }

        [When(@"I update the start date")]
        [Then(@"I update the start date")]
        public void DQIUpdateStartDate()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.EnterStartDate("01", "Day");
            editCoursePage2.EnterStartDate("01", "Month");
            editCoursePage2.EnterStartDate("2021", "Year");
        }


        [Then(@"the Save button is displayed")]
        public void DQISave()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.verifySaveButton();
        }

        [When(@"I click cancel DQI Edit")]
        public void CancleDQIEdit()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.ClickCancelDQI();
        }

        [When(@"I click on the Provider name in the header")]
        public void WhenIClickOnTheProviderNameInTheHeader()
        {
            DQIDashbordPage dQIDashbordPage = new DQIDashbordPage(webDriver);
            dQIDashbordPage.NavigateToProviderDetails();
        }


    }
}
