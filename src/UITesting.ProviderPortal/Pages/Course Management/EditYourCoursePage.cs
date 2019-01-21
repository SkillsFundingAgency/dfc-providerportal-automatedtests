using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using OpenQA.Selenium;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class EditYourCoursePage: BasePage
    {
        private static String PAGE_TITLE = "Your courses";

        public  EditYourCoursePage(IWebDriver webDriver):base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void SearchQual(string qualName)
        {
            throw new NotImplementedException();
        }

        internal void SearchCourseName(string courseName)
        {
            throw new NotImplementedException();
        }

        internal void SelectCourseRunName(string oldCourseRunName)
        {
            throw new NotImplementedException();
        }

        internal void ChangeCourseName(string newCourseName)
        {
            throw new NotImplementedException();
        }

        internal void SaveCourseName()
        {
            throw new NotImplementedException();
        }

        internal void ValidateButtons()
        {
            throw new NotImplementedException();
        }

        internal void ValidateSavedData()
        {
            throw new NotImplementedException();
        }

        internal void ValidateErrorMessage(string errMessage)
        {
            throw new NotImplementedException();
        }

        internal void ValidateSpacesData()
        {
            throw new NotImplementedException();
        }
    }
}
