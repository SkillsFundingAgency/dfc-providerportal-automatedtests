﻿using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class AddCoursePage : BasePage
    {

        private static String PAGE_TITLE = "Complete your qualification details";
        private By howWillLearn = By.Id("HowWillLearn");
        private By whatWillLearn = By.Id("WhatWillLearn");
        private By courseFor = By.Id("CourseFor");
        private By entryRequirements = By.Id("EntryRequirements");
        private By equipmentNeeded = By.Id("EquipmentNeeded");
        private By nextButton = By.Id("goToSection2");

        public AddCoursePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }


        public AddCoursePage EnterWhoCourseFor(String whoText)
        {
            FormCompletionHelper.EnterText(courseFor, whoText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage EnterEntryRequirements(String entryText)
        {
            FormCompletionHelper.EnterText(entryRequirements, entryText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage EnterWhatWillLearn(String whatText)
        {
            FormCompletionHelper.EnterText(whatWillLearn, whatText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage EnterHowYoullLearn(String howText)
        {
            FormCompletionHelper.EnterText(howWillLearn, howText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage EnterEquipmentNeeded(String equipText)
        {
            FormCompletionHelper.EnterText(equipmentNeeded, equipText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage ClickNext()
        {
            FormCompletionHelper.ClickElement(nextButton);
            return new AddCoursePage(webDriver);
        }

    }
}