using System;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.TestSupport
{
    public abstract class BasePage
    {
        protected IWebDriver webDriver;
	    private readonly By pageHeading = By.CssSelector("h1");

		public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(webDriver, this);
        }

        protected abstract Boolean SelfVerify();

        protected String GetPageHeading()
        {
			return webDriver.FindElement(pageHeading).GetAttribute("innerText");

           

        }
	}
}