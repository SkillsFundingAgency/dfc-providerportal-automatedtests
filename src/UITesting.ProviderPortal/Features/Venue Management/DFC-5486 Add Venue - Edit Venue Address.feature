Feature: DFC-5486 Add Venue - Edit Venue Address
	In order to alter a provisionally entered address 
	As a provider user when Adding a Venue
	I want to be able to edit Venue Address

#all tests start at Add Venue address screen 
Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Your Venues Pages
	When I enter 10028015 and click search
	When I click Add Venue
	Then I am on the Add Venue page
	And the Add Venue page displays the expected content
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road Birmingham, B13 9DA
	And I enter venue name Test Venue
	And I click continue to confirm page
	Then  I am on the Add Venue Confirm details page

@CI
Scenario Outline: Change address manually during Add Venue
Given I am on the edit venue address screen
	When Editing I enter the postcode <postcode>
	And I click Find Address to change to
	#Then I am on the Select Address to change to page
Examples:
| postcode |
| CV23 9JR |

#-- reuse steps to confirm and check new venue


#@CI
#Scenario: Change address using postcode during Add Venue
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
##--look into using postcode look-up steps
#	And my new address is shown on the venue name and address screen
##-- reuse steps to confirm and check new venue
#
#@CI
#Scenario: Back out of address change during Add Venue
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the address manually
#	And I click on cancel
#	Then original address is shown on the venue name and address screen
##-- reuse steps to confirm and check new venue
#
#
#@CI
#Scenario: Amended address can not be blank
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the venue name to blank and click commit
#	Then I am shown a message <message-text>
#
#
#@CI
#Scenario: Amended address can not have blank postcode
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the venue name to blank and click commit
#	Then I am shown a message <message-text>
#
#	@CI
#Scenario: Amended address can not have blank line 1
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the venue name to blank and click commit
#	Then I am shown a message <message-text>
