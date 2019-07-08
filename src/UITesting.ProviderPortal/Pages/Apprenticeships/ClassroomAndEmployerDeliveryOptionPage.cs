using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class ClassroomAndEmployerDeliveryOptionPage : BasePage
    {
        private static String PAGE_TITLE = "Select delivery options";
        private By DayRelease = By.Id("DayRelease");
        private By BlockRelease = By.Id("BlockRelease");
        private By location = By.Id("LocationId");
        private By Radius = By.Id("Radius");
        private By AddAnother = By.Id("next2");
        private By SaveContinue = By.Id("continue");

        public ClassroomAndEmployerDeliveryOptionPage(IWebDriver webDriver) : base(webDriver)
        {
           SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public ClassroomAndEmployerDeliveryOptionPage SelectOption(string option)
        {
            switch(option)
            {
                case "Day Release":
                    FormCompletionHelper.ClickElement(DayRelease);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new ClassroomAndEmployerDeliveryOptionPage(webDriver);
                case "Block Release":
                    FormCompletionHelper.ClickElement(BlockRelease);
                    PageInteractionHelper.WaitForPageToLoad();
                    return new ClassroomAndEmployerDeliveryOptionPage(webDriver);
                default:
                    throw new Exception("Option not found");
            }
        }

        public ClassroomAndEmployerDeliveryOptionPage SelectFirstLocation()
        {
            FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(location),1);
            PageInteractionHelper.WaitForPageToLoad();
            return new ClassroomAndEmployerDeliveryOptionPage(webDriver);
        }

        public ClassroomAndEmployerDeliveryOptionPage EnterRadius(string radius)
        {
            FormCompletionHelper.EnterText(webDriver.FindElement(Radius),radius);
            PageInteractionHelper.WaitForPageToLoad();
            return new ClassroomAndEmployerDeliveryOptionPage(webDriver);
        }

        public ClassroomAndEmployerDeliveryOptionPage ClickAddAnother()
        {
            FormCompletionHelper.ClickElement(AddAnother);
            PageInteractionHelper.WaitForPageToLoad();
            return new ClassroomAndEmployerDeliveryOptionPage(webDriver);
        }

        public ConfirmDetailsPage ClickSave()
        {
            FormCompletionHelper.ClickElement(SaveContinue);
            PageInteractionHelper.WaitForPageToLoad();
            return new ConfirmDetailsPage(webDriver);
        }
    }
}