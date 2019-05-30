using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class AppDeliveryMethodPage : BasePage
    {
        private static String PAGE_TITLE = "Where will this apprenticeship training be delivered?";
        private By YourLocationRadio = By.Id("YourLocation");
        private By EmployerRadio = By.Id("EmployersAddress");
        private By BothRadio = By.Id("Both");
        private By ErrorMsg = By.XPath(".//*[@id='ApprenticeshipDeliveryForm']/div/fieldset/span");
        private By ContinueBtn = By.Id("next");


        public AppDeliveryMethodPage(IWebDriver webDriver) : base(webDriver)
        {
           SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public AppDeliveryMethodPage clickYourLocation()
        {
            FormCompletionHelper.ClickElement(YourLocationRadio);
            PageInteractionHelper.WaitForPageToLoad();
            return new AppDeliveryMethodPage(webDriver);
        }

        public AppDeliveryMethodPage clickEmployer()
        {
            FormCompletionHelper.ClickElement(EmployerRadio);
            PageInteractionHelper.WaitForPageToLoad();
            return new AppDeliveryMethodPage(webDriver);
        }

        public AppDeliveryMethodPage clickBoth()
        {
            FormCompletionHelper.ClickElement(BothRadio);
            PageInteractionHelper.WaitForPageToLoad();
            return new AppDeliveryMethodPage(webDriver);
        }

        public AppDeliveryMethodPage AppInfoErrorDisplayed(string errMsg)
        {
            PageInteractionHelper.WaitForElementToBePresent(ErrorMsg);
            PageInteractionHelper.IsElementDisplayed(ErrorMsg);
            PageInteractionHelper.VerifyText(errMsg, errMsg);
            return new AppDeliveryMethodPage(webDriver);
        }

        public AppDeliveryMethodPage ContinueError()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new AppDeliveryMethodPage(webDriver);
        }

        public ClassroomDeliveryOptionPage ContinueYourLocation()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new ClassroomDeliveryOptionPage(webDriver);
        }

        public NationalProviderCapabilityPage ContinueEmployer()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new NationalProviderCapabilityPage(webDriver);
        }

        public ClassroomAndEmployerDeliveryOptionPage ContinueBoth()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new ClassroomAndEmployerDeliveryOptionPage(webDriver);
        }

    }
}