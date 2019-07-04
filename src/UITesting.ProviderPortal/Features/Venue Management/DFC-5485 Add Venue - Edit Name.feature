Feature: DFC-5485 Add Venue - Edit Venue Name
	In order to alter a provisionally entered Venue Name 
	As a provider user when Adding a Venue
	I want to be able to edit Venue Name

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
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road
	And I enter variable venue nameTest Venue
	And I click continue to confirm page				

@CI
Scenario: DFC-5485 Change name manually from Edit Venue Screen
Given I am on the edit venue name page
	And I have cleared the venue name field
	And I have entered a venue name
	When I press commit venue name