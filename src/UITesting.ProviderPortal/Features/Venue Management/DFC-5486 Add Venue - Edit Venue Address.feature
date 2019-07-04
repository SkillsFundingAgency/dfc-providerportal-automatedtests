Feature: DFC-5486 Add Venue - Edit Venue Address
	In order to alter a provisionally entered address 
	As a provider user when Adding a Venue
	I want to be able to edit Venue Address

#all tests start at Add Venue address screen 
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
	Then  I am on the Add Venue Confirm details page

@CI
Scenario Outline: DFC-5486 Change address manually during Add Venue
Given I am on the edit venue address screen
	When Editing I enter the postcode <postcode>
	And I click Find Address to change to
Examples:
| postcode |
| CV23 9JR |

#-- reuse steps to confirm and check new venue
