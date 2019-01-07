using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Provider_Management;


namespace UITesting.ProviderPortal.StepDefinitions
{
    [Binding]
    public class AddProviderSearchUKRLPSteps : TestSupport.BaseTest
    {
        [Given(@"I am on Add a Provider Page")]
        public void GivenIAmOnAddAProviderPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetProviderBaseUrl();
        }

        [Then(@"I should see label ""(.*)""")]
        public void ThenIShouldSeeLabel(string verifyLabel )
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.AddProviderLabelText(verifyLabel);

        }

        [Then(@"I should see another label ""(.*)""")]
        public void ThenIShouldSeeAnotherLabel(string verifyAnotherLabel)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.AddProviderLabelText2(verifyAnotherLabel);

        }

        [Then(@"I should see a text input field")]
        public void ThenIShouldSeeATextInputField()
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.TextInputField();

        }

        [Then(@"I should see a search icon")]
        public void ThenIShouldSeeASearchIcon()
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.VerifySearchIcon();

        }


        [When(@"I do not put an input and click ""(.*)""")]
        public void WhenIDoNotPutAnInputAndClick(string enterNull)
        {
            //nothing is entered
            
        }

        [When(@"I enter UKPRN less than eight digits (.*)")]
        public void WhenIEnterUKPRNLessThanEightDigits(string LessThanEightDigits)
        {
        AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
        addProviderSearchUKRLPPage.EnterLessThanEightDigits(LessThanEightDigits);

        }

        [When(@"I enter input which is a string of alphabets""(.*)""")]
        public void WhenIEnterInputWhichIsAStringOfAlphabets(string AlphabetString)
        {
        AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
        addProviderSearchUKRLPPage.EnterAlphabetString(AlphabetString);
        }



        [When(@"I enter UKPRN that does not start with one (.*)")]
        public void WhenIEnterUKPRNThatDoesNotStartWithOne(string InputDoesNotStartWithOne)
        {
        AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
        addProviderSearchUKRLPPage.EnterInputDoesNotStartWithOne(InputDoesNotStartWithOne);
        }


        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter a valid input ""(.*)""")]
        public void WhenIEnterAValidInput(string ValidInput)
        {
        AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
        addProviderSearchUKRLPPage.EnterValidInput(ValidInput);
 
        }

        [Then(@"I should not see the error message on clicking ""(.*)""")]
        public void ThenIShouldNotSeeTheErrorMessageOnClicking(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter valid input and hit search icon or Enter key")]
        public void WhenIEnterValidInputAndHitSearchIconOrEnterKey()
        {
        AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
        addProviderSearchUKRLPPage.ClickSearch();
  
        }
        
        [When(@"UKPRN number exists in the system")]
        public void WhenUKPRNNumberExistsInTheSystem()
        {
            //When UKPRN is in the database
        }

        
        [Then(@"The label will be ""(.*)"" and the data will be ""(.*)""")]
        public void ThenTheLabelWillBeAndTheDataWillBe(string CDStatus, string Registered)
        {
            
                AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
                addProviderSearchUKRLPPage.verifylabelCDStatus(CDStatus, Registered);

            
        }
        
        [Then(@"The label will be ""(.*)""and the data value will be ""(.*)""")]
        public void ThenTheLabelWillBeAndTheDataValueWillBe(string UKPRNStatus, string Active)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifylabelUKPRNStatus(UKPRNStatus, Active);

        }

        [Then(@"The label will be ""(.*)"" and the data value will be the entered regiestration number")]
        public void ThenTheLabelWillBeAndTheDataValueWillBeTheEnteredRegiestrationNumber(string UKPRN)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifyUKPRN(UKPRN);
        }
        
        [Then(@"The label wil be ""(.*)"" and the data value will be the Provider name")]
        public void ThenTheLabelWilBeAndTheDataValueWillBeTheProviderName(string Name)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifyName(Name);
        }
        
        [Then(@"The label will be ""(.*)""and the data value will be the Provider's address and the address lines are separated by commas")]
        public void ThenTheLabelWillBeAndTheDataValueWillBeTheProviderSAddressAndTheAddressLinesAreSeparatedByCommas(string Address)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifyAddress(Address);
        }
        
        [Then(@"the label will be ""(.*)"" and the data value will be the Web address of provider")]
        public void ThenTheLabelWillBeAndTheDataValueWillBeTheWebAddressOfProvider(string Web)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifyWeb(Web);
        }
        
        [Then(@"The label wll be ""(.*)"" and the data value will be the Provider's email")]
        public void ThenTheLabelWllBeAndTheDataValueWillBeTheProviderSEmail(string Email)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifyEmail(Email);
        }
        
        [Then(@"The label will be ""(.*)"" and the data value will be the Provider's telephone")]
        public void ThenTheLabelWillBeAndTheDataValueWillBeTheProviderSTelephone(string Telephone)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifyTelephone(Telephone);
        }

        [Then(@"an ""(.*)"" button at the bottom")]
        public void ThenAnButtonAtTheBottom(string AddProvider)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifyAddProviderButton(AddProvider);
        }
        
        
      
        [When(@"I click the Add Provider button")]
        public void WhenIClickTheAddProviderButton()
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.ClickAddProviderButton();
        }

        [Then(@"I should see a message on top saying ""(.*)""")]
        public void ThenIShouldSeeAMessageOnTopSaying(string ProviderAdded)
        {

            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.providerAddedMessage(ProviderAdded);
          


        }

        [Then(@"The Course Directory Status data value should be ""(.*)""")]
        public void ThenTheCourseDirectoryStatusDataValueShouldBe(string Onboarded)
        {
            AddProviderSearchUKRLPPage addProviderSearchUKRLPPage = new AddProviderSearchUKRLPPage(webDriver);
            addProviderSearchUKRLPPage.verifyOnboardStatus(Onboarded);
        }
        
        [When(@"The provider status is Deactivated")]
        public void WhenTheProviderStatusIsDeactivated()
        {
            //check for reg#10003284

        }

        [When(@"No result is found for the UKPRN entered by the user")]
        public void WhenNoResultIsFoundForTheUKPRNEnteredByTheUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        
        
        
        [Then(@"System uses the entered UKPRN to search the Course Directory system")]
        public void ThenSystemUsesTheEnteredUKPRNToSearchTheCourseDirectorySystem()
        {
            ScenarioContext.Current.Pending();
        }
       
        [Then(@"System displays error message")]
        public void ThenSystemDisplaysErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"System displays an error message")]
        public void ThenSystemDisplaysAnErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
