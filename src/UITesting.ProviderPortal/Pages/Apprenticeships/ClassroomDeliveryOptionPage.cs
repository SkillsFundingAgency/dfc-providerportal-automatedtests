﻿using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class ClassroomDeliveryOptionPage : BasePage
    {
        private static String PAGE_TITLE = "Classroom Delivery Options";


        public ClassroomDeliveryOptionPage(IWebDriver webDriver) : base(webDriver)
        {
           SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }


    }
}