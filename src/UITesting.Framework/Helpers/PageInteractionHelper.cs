using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UITesting.Framework.Helpers

{
    public class PageInteractionHelper
    {
        protected static IWebDriver webDriver;

        public static void SetDriver(IWebDriver webDriver)
        {
            PageInteractionHelper.webDriver = webDriver;
        }

        public static Boolean VerifyPageHeading(String actual, String expected)
        {
            if(actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Page verification failed:"
                + "\n Expected: " + expected + " page"
                + "\n Found: " + actual + " page");
        }

        public static Boolean VerifyPageTitle(String actual, String expected)
        {
            if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Page verification failed:"
                + "\n Expected: " + expected + " page"
                + "\n Found: " + actual + " page");
        }

        public static Boolean VerifyTableData(By locator, String strVenueName)
        {
            IList<IWebElement> cols = webDriver.FindElements(locator);

            foreach (var col in cols)
            {
                if (col.Text ==strVenueName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            throw new Exception("Venue not found");
        }

        
        public static Boolean VerifyPageHeading(By locator, String expected)
        {
			//km String actual = webDriver.FindElement(locator).Text;
			String actual = webDriver.FindElement(locator).GetAttribute("innerText");

			if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Page verification failed:"
                + "\n Expected: " + expected + " page"
                + "\n Found: " + actual + " page");
        }

        public static Boolean VerifyPageHeading(String actual, String expected1, String expected2)
        {
            if(actual.Contains(expected1) || actual.Contains(expected2))
            {
                return true;
            }

            throw new Exception("Page verification failed: "
                + "\n Expected: " + expected1 + " or " + expected2 + " pages"
                + "\n Found: " + actual + " page");
        }

        public static Boolean VerifyText(String actual, String expected)
        {
            if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Text verification failed: "
                + "\n Expected: " + expected
                + "\n Found: "+ actual);
        }

        public static Boolean VerifyText(By locator, String expected)
        {
            String actual = webDriver.FindElement(locator).Text;
            if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Text verification failed: "
                + "\n Expected: " + expected
                + "\n Found: " + actual);
        }

        public static Boolean VerifyElementPresent(By locator)
        {
            String actual = webDriver.FindElement(locator).Text;
            if (actual!= null)
            {
                return true;
            }

            throw new Exception("The Element does not exist on the page");
        }


        public static Boolean VerifyElementNotPresent(By locator)
        {
            String actual = webDriver.FindElement(locator).Text;
            if (actual == null || actual=="")
            {
                return true;
            }

            throw new Exception("The Element exists on the page");
        }

        public static Boolean VerifyEditFieldText(By locator, String expected)
        {
            String actual = webDriver.FindElement(locator).GetAttribute("value");
            if (actual.Contains(expected))
            {
                return true;
            }

            throw new Exception("Text verification failed: "
                + "\n Expected: " + expected
                + "\n Found: " + actual);
        }

        public static Boolean VerifyTextNotPresent(By locator, String txtNotPresnet)
        {
            String actual = webDriver.FindElement(locator).Text;
            if (actual.Contains(txtNotPresnet))
            {
                throw new Exception("Text verification failed: "
                                    + "\n The following text should not be displayed in this scenario " + txtNotPresnet); 
            }
            return false;
        }

        public static void VerifyDropdownDefaultValue(By locator, String expected)
        {
            IWebElement dropdown = webDriver.FindElement(locator);
            SelectElement selectedValue = new SelectElement(dropdown);
            string labelText = selectedValue.SelectedOption.GetAttribute("label");
            if (labelText != expected)
            {
                throw new Exception("Default Value of dropdown not as expected, expecting: " +expected +", displayed: "+labelText);
            }
        }

        public static void WaitForPageToLoad(int implicitWaitTime = 10)
        {
            Thread.Sleep(500);
            var waitForDocumentReady = new WebDriverWait(webDriver, TimeSpan.FromSeconds(implicitWaitTime));
            waitForDocumentReady.Until((wdriver) => (webDriver as IJavaScriptExecutor).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void WaitForElementToBePresent(By locator)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        public static void WaitForElementToBeDisplayed(By locator)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            
        }
        
        public static void  IsElementReadOnly(By locator)
        {
            
            if (webDriver.FindElement(locator).GetAttribute("readonly")=="false")
            {
                throw new Exception("The field is not read only");
            }
            
        }
        public static Boolean IsElementPresent(By locator)
        {
            TurnOffImplicitWaits();
            try
            {
                webDriver.FindElement(locator);
                return true;
                

            }
            catch (NoSuchElementException)
            {
                return false;
            }
            finally
            {
                TurnOnImplicitWaits();
            }
        }
         
        public static Boolean IsElementDisplayed(By locator)
        {
            TurnOffImplicitWaits();
            try
            {
                return webDriver.FindElement(locator).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                TurnOnImplicitWaits();
            }
        }
       

        public static void FocusTheElement(By locator)
        {
            IWebElement webElement = webDriver.FindElement(locator);
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", webElement);
            WaitForElementToBeDisplayed(locator);
        }

        public static void TurnOffImplicitWaits()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        }

        public static void TurnOnImplicitWaits()
        {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public static void TurnOnSleep()
        {
            Thread.Sleep(10000);
        }

        public static void OpenAccordians(By accordianIconXPath)
        {
            //first store all the accordian-open icon xpaths into an IList[x]
            IList<IWebElement> mainAccordianLinks = webDriver.FindElements(accordianIconXPath);
            //cycle through and expand until last accordian-open icon
            int i = 0;
            foreach (IWebElement webElement in mainAccordianLinks)
            {
                try
                {
                    mainAccordianLinks[i].Click(); 
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                i++;
            }
            //Thread.Sleep(5000);
        }  
        public static Boolean VerifyAccordianText(By locator, string accordianText)
        {
            IList<IWebElement> AccordianLinkText = webDriver.FindElements(locator);
            int i = 0;
            foreach(IWebElement webElement in AccordianLinkText)
            {
                if(AccordianLinkText[i].Text.Contains(accordianText))
                    {
                    AccordianLinkText[i].Click();
                    return true;
                    }
                 i++;
            }
            throw new Exception("Text verification failed: "
                + accordianText + "\n Not Found: ");
        }
        public static Boolean VerifyCourseRunValue(By locator, string CourseRunValue)
        {
            /* Verifies the value of a field in a course run*/

            IList<IWebElement> AccordianLinkText = webDriver.FindElements(locator);
            int i = 0;
            foreach (IWebElement webElement in AccordianLinkText)
            {
                if (AccordianLinkText[i].GetAttribute("value").Contains(CourseRunValue))
                {
                    return true;
                }
                i++;
            }
            throw new Exception("Text verification failed: "
                + CourseRunValue + "\n Not Found: ");
        }

        public static void IsObjectSelected(By locator)
        {
            String attributeValue = webDriver.FindElement(locator).GetAttribute("selected");
            if (attributeValue == "false")
            {
                throw new Exception("Object not selected as expected - " + attributeValue);
            }
        }


    }
}
