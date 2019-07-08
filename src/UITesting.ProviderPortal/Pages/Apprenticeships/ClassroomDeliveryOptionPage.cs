using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class ClassroomDeliveryOptionPage : BasePage
    {
        //private static String PAGE_TITLE = "Classroom Delivery Options";
        private static String PAGE_TITLE = "Select delivery options";
        private By saveContinue = By.Id("continue");
        private By saveAnother = By.Id("next2");
        private By VenueLocation = By.Id("LocationId");
        private By DayRelease = By.Id("DayRelease");
        private By BlockRelease = By.Name("BlockRelease");
        private By LocationErrMessage = By.XPath("//*[@id='error-hash-link-LocationId-0']");
        private By DeliveryModeErrMessage = By.XPath("//*[@id='error-hash-link-deliveryoptions-0']");



        public ClassroomDeliveryOptionPage(IWebDriver webDriver) : base(webDriver)
        {
           SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void SelectVenue(string strSelect)
        {
            if(strSelect=="")
            {
                FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(VenueLocation), 1);
            }
            else if(strSelect =="Please select")
            {
                FormCompletionHelper.SelectFromDropDownByText(webDriver.FindElement(VenueLocation), strSelect);
            }
            
        }

        internal void SelectDayRelease()
        {
            FormCompletionHelper.SelectCheckBox2(DayRelease);
        }

        internal void SelectBlockRelease()
        {
            FormCompletionHelper.SelectCheckBox2(BlockRelease);
        }

        internal void ClickSaveandContinue()
        {
            FormCompletionHelper.ClickElement(saveContinue);
        }

        internal void ClickSaveandAddAnother()
        {
            FormCompletionHelper.ClickElement(saveAnother);
        }

        internal void VerifyLocationErrMessage(string errMsg)
        {
            FormCompletionHelper.VerifyText(LocationErrMessage, errMsg);
        }

        internal void VerifyDeliveryOptionErrMessage(string errMsg)
        {
            FormCompletionHelper.VerifyText(DeliveryModeErrMessage, errMsg);
        }
    }
}