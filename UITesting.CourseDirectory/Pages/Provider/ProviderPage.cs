using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.CourseDirectory.Pages
{
    public class ProviderPage: BasePage 
    {
        public ProviderPage(IWebDriver webDriver):base(webDriver)
        {

        }
        internal void AccessProviderDetails()
        {
            webDriver.FindElement(By.XPath("//a[@href='/Provider/Edit']")).Click();

        }
        internal void UpdateProvider(string strFieldName, string strValue)
        {
            webDriver.FindElement(By.Id(strFieldName)).Clear();
            webDriver.FindElement(By.Id(strFieldName)).SendKeys(strValue);
            webDriver.FindElement(By.XPath("/html/body/div[3]/div/form/div/div[1]/div[28]/div/input")).Click();
        }
    }
}
