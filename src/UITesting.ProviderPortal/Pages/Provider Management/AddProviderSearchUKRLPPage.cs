using OpenQA.Selenium;
using System;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class AddProviderSearchUKRLPPage : TestSupport.BasePage
    {
        private By pageTitle = By.CssSelector("h1.govuk-heading-l ");
        private By pageTitle2 = By.CssSelector("p.govuk-heading-m");
        private By labelCD = By.CssSelector("tr:nth-of-type(1) th.govuk-table__header");
        private By dataReg = By.CssSelector("tr:nth-of-type(1) td.govuk-table__cell");
        private By labelUKPRNStatus = By.CssSelector("tr:nth-of-type(2) th.govuk-table__header");
        private By dataActive = By.CssSelector("tr:nth-of-type(2) td.govuk-table__cell");
        private static String PAGE_TITLE = "Add Provider";
        private By textInputField = By.Id("SearchTerm");
        private By searchIcon = By.Id("searchProvider");
        private By labelUKPRN = By.CssSelector("tr:nth-of-type(3) th.govuk-table__header");
        private By labelName = By.CssSelector("tr:nth-of-type(4) th.govuk-table__header");
        private By labelAddress = By.CssSelector("tr:nth-of-type(5) th.govuk-table__header");
        private By labelWeb = By.CssSelector("tr:nth-of-type(6) th.govuk-table__header");
        private By labelEmail = By.CssSelector("tr:nth-of-type(7) th.govuk-table__header");
        private By labelTelephone = By.CssSelector("tr:nth-of-type(8) th.govuk-table__header");
        private By AddProviderButton = By.CssSelector("a#btnOnboardProvider");
        private By ProviderIsAdded = By.CssSelector("h1.govuk-heading-m");
        private By ValueOnboarded = By.CssSelector(" tr:nth-of-type(1) td.govuk-table__cell");
        //private By SearchErrorMsg = By.Id("SearchTerm-error");
        private By SearchErrorMsg = By.XPath(".//*[@id='ProviderSearchResultContainer']/div/div/h1");


        public AddProviderSearchUKRLPPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
            //throw new NotImplementedException();
        }


        internal void AddProviderLabelText(string verifyLabel)
        {
            PageInteractionHelper.VerifyText(pageTitle, verifyLabel);
        }

        internal void AddProviderLabelText2(string verifyAnotherLabel)
        {
            PageInteractionHelper.VerifyText(pageTitle2, verifyAnotherLabel);
        }

        internal void TextInputField()
        {
            PageInteractionHelper.IsElementPresent(textInputField);
        }

        internal void VerifySearchIcon()
        {
            PageInteractionHelper.IsElementPresent(searchIcon);
        }

        public AddProviderSearchUKRLPPage EnterLessThanEightDigits(string LessThanEightDigits)

        {
            FormCompletionHelper.EnterText(textInputField, LessThanEightDigits);
            return new AddProviderSearchUKRLPPage(webDriver);
        }

        public AddProviderSearchUKRLPPage EnterAlphabetString(string AlphabetString)

        {
            FormCompletionHelper.EnterText(textInputField, AlphabetString);
            return new AddProviderSearchUKRLPPage(webDriver);
        }

        public AddProviderSearchUKRLPPage EnterInputDoesNotStartWithOne(string InputDoesNotStartWithOne)
        {
            FormCompletionHelper.EnterText(textInputField, InputDoesNotStartWithOne);
            return new AddProviderSearchUKRLPPage(webDriver);
         }

        public AddProviderSearchUKRLPPage EnterValidInput(string ValidInput)
        {
            FormCompletionHelper.EnterText(textInputField, ValidInput);
            return new AddProviderSearchUKRLPPage(webDriver);


        }

         public AddProviderSearchUKRLPPage ClickSearch()
         {
             FormCompletionHelper.ClickElement(searchIcon);
             return new AddProviderSearchUKRLPPage(webDriver);
          }

        internal void verifylabelCDStatus(string CDStatus, string Registered)
        {
            PageInteractionHelper.VerifyText(labelCD, CDStatus);
            PageInteractionHelper.VerifyText(dataReg, Registered);
        }

        internal void verifylabelUKPRNStatus(string UKPRNStatus, string Active)
        {
            PageInteractionHelper.VerifyText(labelUKPRNStatus, UKPRNStatus);
            PageInteractionHelper.VerifyText(dataActive, Active);
        }

        internal void verifyUKPRN(string UKPRN)
        {
            PageInteractionHelper.VerifyText(labelUKPRN, UKPRN);
            
        }

        internal void verifyName(string Name)
        {
            PageInteractionHelper.VerifyText(labelName, Name);

        }

        internal void verifyAddress(string Address)
        {
            PageInteractionHelper.VerifyText(labelAddress, Address);

        }

        internal void verifyWeb(string Web)
        {
            PageInteractionHelper.VerifyText(labelWeb, Web);

        }

        internal void verifyEmail(string Email)
        {
            PageInteractionHelper.VerifyText(labelEmail, Email);

        }

        internal void verifyTelephone(string Telephone)
        {
            PageInteractionHelper.VerifyText(labelTelephone, Telephone);

        }

        internal void verifyAddProviderButton(string AddProvider)
        {
            PageInteractionHelper.IsElementPresent(AddProviderButton);

        }

        public AddProviderSearchUKRLPPage ClickAddProviderButton()
        {
            FormCompletionHelper.ClickElement(AddProviderButton);
            return new AddProviderSearchUKRLPPage(webDriver);



        }

        internal void providerAddedMessage(string ProviderAdded)
        {
            PageInteractionHelper.IsElementPresent(ProviderIsAdded);

        }

        internal void verifyOnboardStatus(string Onboarded)
        {
            PageInteractionHelper.VerifyText(ValueOnboarded, Onboarded);

        }

        public AddProviderSearchUKRLPPage CheckErrorMessage(string errorMsg)
        {
            PageInteractionHelper.WaitForElementToBePresent(SearchErrorMsg);
            PageInteractionHelper.IsElementDisplayed(SearchErrorMsg);
            string errortxt = webDriver.FindElement(SearchErrorMsg).GetAttribute("innerText");
            if (errorMsg != errortxt)
            {
                throw new Exception("Incorrect Error message displayed");
            }
            return new AddProviderSearchUKRLPPage(webDriver);
        }


        public AddProviderSearchUKRLPPage CheckErrorMessageNotDisplayed()
        {
            if (!(webDriver.FindElement(labelUKPRN).Displayed))
            {
                throw new Exception("Error message is displayed");
            }
            return new AddProviderSearchUKRLPPage(webDriver);
        }

    }
}