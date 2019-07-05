using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class AddApprenticeshipPage : BasePage
    {
        private static String PAGE_TITLE = "Add apprenticeship training details";

        private By ApprenticeshipInfo = By.Id("tinymce");
        private By ApprenticeshipInfoError = By.Id("infoRequired");
        private By AddlCharactersApprenticeshipInfoErrorHeader = By.Id("error-hash-link-infoMax-1");
        private By BlankApprenticeshipInfoErrorHeader = By.Id("error-hash-link-infoRequired-1");

        private By Website = By.Id("Website");
        //private By WebsiteError = By.XPath(".//*[@id='WebsiteContainer']/span[1]");
        //private By WebsiteError=By.Id("//*[@id='error-hash-link-Website-0']");
        private By WebsiteError = By.XPath("//a[@href='#gov-label-Website']");
        


        private By Email = By.Id("Email");
        private By EmailErrorHeader = By.Id("error-hash-link-Email-0");
        private By EmailError = By.XPath(".//*[@id='ContactUsContainer']/span[1]");

        private By Telephone = By.Id("Telephone");
        private By TelephoneError = By.XPath(".//*[@id='TelephoneContainer']/span");
        private By TelephoneErrorHeader = By.Id("error-hash-link-Telephone-0");

        private By ContactUS = By.Id("ContactUsIUrl");
        private By ContactUSError = By.XPath("//*[@id='ContactUsContainer']/span[1]");
        private By ContinueBtn = By.Id("continue");


        public AddApprenticeshipPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public AddApprenticeshipPage EnterInfo(String info)
        {
           // ((IJavaScriptExecutor)this.webDriver).ExecuteScript("tinyMCE.activeEditor.setContent('<h1>Native API text</h1> TinyMCE')");
            ((IJavaScriptExecutor)this.webDriver).ExecuteScript("tinyMCE.activeEditor.setContent('" + info +"')");
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage AppInfoErrorDisplayed(string errMsg,string ErrCat)
        {
            PageInteractionHelper.WaitForElementToBePresent(ApprenticeshipInfoError);
            PageInteractionHelper.IsElementDisplayed(ApprenticeshipInfoError);
            if (ErrCat=="AddlChar")
            {
                PageInteractionHelper.VerifyText(AddlCharactersApprenticeshipInfoErrorHeader, errMsg);
            }
            else if(ErrCat =="Blank")
            {
                PageInteractionHelper.VerifyText(BlankApprenticeshipInfoErrorHeader, errMsg);
            }
            
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage EnterWebsite(String website)
        {
            FormCompletionHelper.EnterText(Website, website);
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage WebsiteErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(WebsiteError);
            PageInteractionHelper.IsElementDisplayed(WebsiteError);
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage EnterEmail(String email)
        {
            FormCompletionHelper.EnterText(Email, email);
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage EmailErrorDisplayed(string errMsg)
        {
            PageInteractionHelper.WaitForElementToBePresent(EmailError);
            PageInteractionHelper.IsElementDisplayed(EmailError);
            PageInteractionHelper.VerifyText(EmailErrorHeader, errMsg);
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage EnterPhone(String phone)
        {
            FormCompletionHelper.EnterText(Telephone, phone);
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage PhoneErrorDisplayed(string errMsg)
        {
            PageInteractionHelper.WaitForElementToBePresent(TelephoneError);
            PageInteractionHelper.IsElementDisplayed(TelephoneError);
            PageInteractionHelper.VerifyText(TelephoneErrorHeader, errMsg);
            
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage EnterContactUs(String contactus)
        {
            FormCompletionHelper.EnterText(ContactUS, contactus);
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage ContactUSErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(ContactUSError);
            PageInteractionHelper.IsElementDisplayed(ContactUSError);
            return new AddApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage ContinueError()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new AddApprenticeshipPage(webDriver);
        }

        public AppDeliveryMethodPage Continue()
        {
            FormCompletionHelper.ClickElement(ContinueBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new AppDeliveryMethodPage(webDriver);
        }

    }
}