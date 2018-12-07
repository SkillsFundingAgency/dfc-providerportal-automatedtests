Feature: DFC-4762 Add Venue - Enter Address Manually
	In order to add an address 
	As a provider user when Adding a Venue
	I want to add manually without using postcode look-up


#all tests start at Add Venue address screen 

Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Your Venues Pages
	When I click Add Venue
	Then I am on the Add Venue page
	And the page displays the expected content

@CI
Scenario: Add an Address without using postcode look-up
	Given I am on the address screen
	And I have chosen to enter address manually
	When I manually enter address without using postcode matching
	Then my new address is shown on address screen
	#-- reuse steps to confirm and check new venue


