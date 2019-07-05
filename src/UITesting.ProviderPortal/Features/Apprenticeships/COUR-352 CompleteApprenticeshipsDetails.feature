Feature: COUR-352 CompleteApprenticeshipsDetails
	In order to Add a new Apprenticehsip
	As a provider
	I want to be able to go through the add apprenticeships journey


Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10044200" and clicked search
	When I click to view my courses
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for Plum
	Then the Results are displayed
@CI
Scenario: COUR-352 Add all valid Values
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "Test Apprenticeship"
	And I have entered a website "http://www.google.com"
	And I have entered an email "Testapp@gmail.com"
	And I have entered a telephone "07112234598"
	And I have entered contact details " "
	And I have clicked continue
	Then the apprenticeship delivery screen should be visible 
@CI
Scenario: COUR-352 Apprenticeships info not entered
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information " "
	And I have entered a website "www.google.com"
	And I have entered an email "Testapp@gmail.com"
	And I have entered a telephone "07112234598"
	And I have entered contact details " "
	And I have clicked continue error
	Then a Blank App Info error message should be displayed "Enter Apprenticeship information for employers"
@CI
Scenario: COUR-352 Email not entered
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "Test Apprenticeship"
	And I have entered a website "http://www.google.com"
	And I have entered an email " "
	And I have entered a telephone "07112234598"
	And I have entered contact details " "
	And I have clicked continue error
	Then a email Info error message should be displayed "Enter email"
@CI
Scenario: COUR-352 Phone not entered
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "Test Apprenticeship"
	And I have entered a website "www.google.com"
	And I have entered an email "Testapp@gmail.com"
	And I have entered a telephone " "
	And I have entered contact details " "
	And I have clicked continue error
	Then a phone Info error message should be displayed "Enter telephone"
@CI
Scenario: COUR-352 Invalid Email entered
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "Test Apprenticeship"
	And I have entered a website "http://www.google.com"
	And I have entered an email "Testappgmail.uk"
	And I have entered a telephone "+44 (0)121 445 6767"
	And I have entered contact details " "
	And I have clicked continue error
	Then a email Info error message should be displayed "Enter a valid email"
@CI
Scenario: COUR-352 Invalid Phone Number entered-less than 11 characters
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "Test Apprenticeship"
	And I have entered a website "www.google.com"
	And I have entered an email "Testapp@gmail.com"
	And I have entered a telephone "7112234598"
	And I have entered contact details " "
	And I have clicked continue error
	Then a phone Info error message should be displayed "Telephone should be minimum 11 characters"
@CI
Scenario: COUR-352 Invalid Phone Number entered-no numbers
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "Test Apprenticeship"
	And I have entered a website "www.google.com"
	And I have entered an email "Testapp@gmail.com"
	And I have entered a telephone "wrongnumber"
	And I have entered contact details " "
	And I have clicked continue error
	Then a phone Info error message should be displayed "Enter a valid telephone number"
@CI
Scenario: COUR-352 Apprenticeships info entered that is more than 750 characters
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "The European languages are members of the same family. Their separate existence is a myth. For science, music, sport, etc, Europe uses the same vocabulary. The languages only differ in their grammar, their pronunciation and their most common words. Everyone realizes why a new common language would be desirable: one could refuse to pay expensive translators. To achieve this, it would be necessary to have uniform grammar, pronunciation and more common words. If several languages coalesce, the grammar of the resulting language is more simple and regular than that of the individual languages. The new common language will be more simple and regular than the existing European languages. It will be as simple as Occidental; in fact, it will be Occid"
	And I have entered a website "http://www.google.com"
	And I have entered an email "Testapp@gmail.com"
	And I have entered a telephone "07112234598"
	And I have entered contact details " "
	And I have clicked continue error
	Then a App Info error message should be displayed "Apprenticeship information for employers should be no more than 750 characters"
@CI
Scenario: COUR-352 Email more than 255 characters
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "Test Apprenticeship"
	And I have entered a website "www.google.com"
	And I have entered an email "testABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ@gmail.com"
	And I have entered a telephone "+44 (0)121 445 6767"
	And I have entered contact details " "
	And I have clicked continue error
	Then a email Info error message should be displayed "Email should be no more than 255 characters"

