Feature: DFC-4762 Add Venue - Enter Address Manually
	In order to add an address 
	As a provider user when Adding a Venue
	I want to add manually without using postcode look-up

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10040838" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Your Venues Pages
	When I click Add Venue
	Then I am on the Add Venue page
	And the Add Venue page displays the expected content
	When on the Add Venue page I want to enter address manually
	And the Add Venue page displays the fields to enter address

@CI
Scenario: DFC-4762 User enters all valid details
	When I enter Valid Venue Name 
	And I enter valid Address Line1
	And I enter Town or City
	And I Enter a Valid postcode
	And I Click Continue 
	Then Add Venue screen with the entered details should be displayed
@CI
Scenario: DFC-4762 User does not enter Venue Name
	When I do not enter Venue Name
	And I Click Continue 
	Then a venue name validation message should be displayed "Enter a venue name"
@CI
Scenario: DFC-4762 User does not enter Address Line 1
	When I leave Address Line 1 as blank
	And I Click Continue 
	Then a Address Line validation message should be displayed "Enter address line 1"
@CI
Scenario: DFC-4762 User does not enter Town or City
	When I leave Town or City as blank 
	And I Click Continue 
	Then a Town or City validation message should be displayed "Enter a town or city"
@CI
Scenario: DFC-4762 User does not enter PostCode
	When I leave PostCode as blank
	And I Click Continue 
	Then a postcode validation message should be displayed "Enter a postcode"
@CI
Scenario: DFC-4762 User does not enter Valid PostCode
	When I enter the following PostCode "xxxxxx"
	And I Click Continue 
	Then a valid postcode validation message should be displayed "Enter a real postcode"