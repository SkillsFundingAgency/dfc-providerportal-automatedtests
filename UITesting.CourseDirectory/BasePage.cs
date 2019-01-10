using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace UITesting.CourseDirectory
{
    public abstract class BasePage
    {
        protected IWebDriver webDriver;
        //private readonly By pageHeading = By.CssSelector("h1");
        public string MESSAGE = "Your changes were saved successfully.";

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(webDriver, this);
        }
        

      /*protected abstract Boolean SelfVerify();

        protected String GetPageHeading()
        {
            return webDriver.FindElement(pageHeading).GetAttribute("innerText");
        }*/
    }
}
