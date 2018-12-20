using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class AddCoursePage : BasePage
    {

        //needs editing - this is the Add Venue Page copied....

        private static String PAGE_TITLE = "Complete your qualification details";
        private By venueName = By.Id("name");
        private By UKPRN = By.Id("UKPrn");
        private By venuePostcode = By.Id("Postcode");
        private By FindAddressButton = By.XPath(".//*[@id='main-content']/div/div/form/div[2]/div/div[2]/button");
        private By PostcodeValidationMessage = By.CssSelector("#Postcode-error");
        private By ClickEnterAddressManually = By.XPath("//a[@href='/Venues/AddCourseManualAddress']");



        public AddCoursePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }



  

    }
}