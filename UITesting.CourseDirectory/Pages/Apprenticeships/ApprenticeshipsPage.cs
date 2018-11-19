using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.CourseDirectory.Pages.Apprenticeships
{
    public class ApprenticeshipsPage:BasePage
    {
        public static String APPR_PAGE_TITLE = "View all Locations";
        public ApprenticeshipsPage(IWebDriver webDriver):base(webDriver)
        {
            
        }
        internal void ClickApprenticeshipsMenu()
        {
            webDriver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[3]/div/ul/li[3]/a")).Click();
        }
        internal void ViewAllLocations()
        {
            
            webDriver.FindElement(By.XPath("//a[@href='/Location/List']")).Click();
        }
        internal void ValidateAllLocations()
        {
            PageInteractionHelper.VerifyPageHeading(webDriver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[1]/h2")).Text, APPR_PAGE_TITLE);
            //ValidateLocationTable();
        }
        
        internal void SelectAddNewLocation()
        {
            webDriver.FindElement(By.XPath("//a[@href='/Location/Create']")).Click();
        }
    }
}
