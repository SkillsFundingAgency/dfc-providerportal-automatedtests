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
        /*Model Class Variables*/

        Models.Apprenticeships Apprenticeships = new Models.Apprenticeships();
        public ApprenticeshipsPage(IWebDriver webDriver):base(webDriver)
        {
            
        }
        internal void ClickApprenticeshipsMenu()
        {
            webDriver.FindElement(By.XPath(Apprenticeships.APPRENTICESHIPS_MENU)).Click();
        }
        internal void ViewAllLocations()
        {
            
            webDriver.FindElement(By.XPath(Apprenticeships.APPRENTICESHIPS_LOCATIONS)).Click();
        }
        internal void ValidateAllLocations()
        {
            PageInteractionHelper.VerifyPageHeading(webDriver.FindElement(By.XPath(Apprenticeships.ALL_APPRENTICESHIPS_TITLE_TEXT)).Text, APPR_PAGE_TITLE);
            //ValidateLocationTable();
        }
        
        internal void SelectAddNewLocation()
        {
            webDriver.FindElement(By.XPath(Apprenticeships.CREATE_APPRENTICESHIPS_LOCATION)).Click();
        }
    }
}
