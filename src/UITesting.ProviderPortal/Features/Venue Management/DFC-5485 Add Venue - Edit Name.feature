Feature: DFC-5485 Add Venue - Edit Venue Name
	In order to alter a provisionally entered Venue Name 
	As a provider user when Adding a Venue
	I want to be able to edit Venue Name

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
Scenario: Change name manually from Edit Venue Screen
Given I am on the edit venue name page
	And I have cleared the venue name field
	And I have entered a venue name
	When I press commit venue name
	#Then  I am on the Add Venue Confirm details page



#@CI
#Scenario: Change name manually during Add Venue
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit venue name
#	Then I am taken to the change venue name screen
#	And I can change the venue name manually
#	And my new venue name is shown on name screen
##-- reuse steps to confirm and check new venue
#
#
#@CI
#Scenario: User backs-out of change
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the venue name manually
#	And I click on cancel
#	Then original venue name is shown on the venue name and address screen
##-- reuse steps to confirm and check new venue
#
#
#@CI
#Scenario: Amended venue name can not be blank
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the venue name to blank and click commit
#	Then I am shown a message <message-text>
#
#	@CI
#Scenario: Amended venue name exceeds maximum name length
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the venue name to <excede-255-chrs> and click commit
#	Then I am shown a message <message-text>
#
##editing...
#		@CI
#Scenario: Amended venue name contains leading space
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the venue name to <excede-255-chrs> and click commit
#	Then I am shown a message <message-text>
#
#	@CI
#Scenario: Amended venue name contains non-standard chars
#	Given I have entered a venue name and address
#	And I am on the venue name and address screen
#	When I press edit address
#	Then I am taken to the change address screen
#	And I can change the venue name to <excede-255-chrs> and click commit
#	Then I am shown a message <message-text>