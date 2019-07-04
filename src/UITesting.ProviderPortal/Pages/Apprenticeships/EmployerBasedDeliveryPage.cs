using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class EmployerBasedDeliveryPage : BasePage
    {
        private static String PAGE_TITLE = "Select the regions where you provide this training";
        private By EastMidlandsRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[1]/summary");
        private By EastEnglandRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[2]/summary");
        private By LondonRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[3]/summary");
        private By NorthEastRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[4]/summary");
        private By NorthWestRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[5]/summary");
        private By southEastRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[6]/summary");
        private By SouthWestRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[7]/summary");
        private By WestMidlandsegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[8]/summary");
        private By YorkshireRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[9]/summary");
        private By SelectAll = By.XPath(".//*[@id='SelectAll']");
        private By FirstSubRegion = By.XPath(".//*[@id='RegionName-1']");
        private By ContinueBtn = By.Id("next");


        public EmployerBasedDeliveryPage(IWebDriver webDriver) : base(webDriver)
        {
           SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public EmployerBasedDeliveryPage SelectRegion(string region)
        {

            switch (region.ToLower())
            {
                case "east midlands":
                    FormCompletionHelper.ClickElement(EastMidlandsRegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                case "east of england":
                    FormCompletionHelper.ClickElement(EastEnglandRegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                case "london":
                    FormCompletionHelper.ClickElement(LondonRegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                case "north west":
                    FormCompletionHelper.ClickElement(NorthWestRegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                case "north east":
                    FormCompletionHelper.ClickElement(NorthEastRegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                case "south east":
                    FormCompletionHelper.ClickElement(southEastRegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                case "south west":
                    FormCompletionHelper.ClickElement(SouthWestRegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                case "west midlands":
                    FormCompletionHelper.ClickElement(WestMidlandsegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                case "yorkshire":
                    FormCompletionHelper.ClickElement(YorkshireRegion);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new EmployerBasedDeliveryPage(webDriver);

                default:
                    throw new Exception("Region is not listed");
            }
        }

       public EmployerBasedDeliveryPage SelectFirstSubRegion()
        {
            PageInteractionHelper.WaitForPageToLoad();
            var element = this.webDriver.FindElement(FirstSubRegion);
            ((IJavaScriptExecutor)this.webDriver).ExecuteScript("arguments[0].click();", element);
            //FormCompletionHelper.ClickElement(FirstSubRegion);
            PageInteractionHelper.WaitForPageToLoad();
            return new EmployerBasedDeliveryPage(webDriver);
        }

        public EmployerBasedDeliveryPage SelectAllSubRegion()
        {
            PageInteractionHelper.WaitForPageToLoad();
            PageInteractionHelper.WaitForElementToBeDisplayed(SelectAll);
            PageInteractionHelper.WaitForElementToBePresent(SelectAll);
            var element = this.webDriver.FindElement(SelectAll);
            ((IJavaScriptExecutor)this.webDriver).ExecuteScript("arguments[0].click();", element);
            //FormCompletionHelper.ClickElement(SelectAll);
            PageInteractionHelper.WaitForPageToLoad();
            return new EmployerBasedDeliveryPage(webDriver);
        }

        public ConfirmDetailsPage ClickContinue()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new ConfirmDetailsPage(webDriver);
        }


    }
}