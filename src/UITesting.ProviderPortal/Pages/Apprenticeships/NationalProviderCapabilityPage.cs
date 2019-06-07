using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class NationalProviderCapabilityPage : BasePage
    {
        private static String PAGE_TITLE = "Can you deliver this training at employers’ locations anywhere in England?";
        private By Yes = By.Id("Yes");
        private By No = By.Id("No");
        private By ErrorMsg = By.XPath(".//*[@id='ApprenticeshipLocationChoiceSelectionForm']/div/fieldset/span");
        private By ContinueBtn = By.Id("next");

        public NationalProviderCapabilityPage(IWebDriver webDriver) : base(webDriver)
        {
           SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public NationalProviderCapabilityPage clickYes()
        {
            FormCompletionHelper.ClickElement(Yes);
            PageInteractionHelper.WaitForPageToLoad();
            return new NationalProviderCapabilityPage(webDriver);
        }

        public NationalProviderCapabilityPage clickNo()
        {
            FormCompletionHelper.ClickElement(No);
            PageInteractionHelper.WaitForPageToLoad();
            return new NationalProviderCapabilityPage(webDriver);
        }

        public NationalProviderCapabilityPage ErrorDisplayed(string errorMsg)
        {
            PageInteractionHelper.WaitForElementToBePresent(ErrorMsg);
            PageInteractionHelper.IsElementDisplayed(ErrorMsg);
            return new NationalProviderCapabilityPage(webDriver);
        }

        public NationalProviderCapabilityPage ContinueError()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new NationalProviderCapabilityPage(webDriver);
        }

        public ConfirmDetailsPage ContinueYes()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new ConfirmDetailsPage(webDriver);
        }

        public EmployerBasedDeliveryPage ContinueNo()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new EmployerBasedDeliveryPage(webDriver);
        }

    }
}