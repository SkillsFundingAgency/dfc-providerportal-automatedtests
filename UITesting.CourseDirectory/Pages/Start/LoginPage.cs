using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.CourseDirectory.Pages
{
    public class LoginPage : BasePage 
    {
        public static String PROVIDER_TITLE = "Mark Paddock - Test Provider";
        public LoginPage(IWebDriver webDriver): base(webDriver)
        {
            
        }

        internal void LoginAsProvider()
        {
           
            webDriver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/a[1]")).Click();
            webDriver.FindElement(By.Id("Email")).SendKeys(ConfigurationManager.AppSettings["ProviderUserName"]);
            webDriver.FindElement(By.Id("Password")).SendKeys(ConfigurationManager.AppSettings["ProviderPassword"]);
            webDriver.FindElement(By.XPath("//*[@id='loginForm']/form/div[1]/div[3]/div/input")).Click();
            
        }
        
    }
}
