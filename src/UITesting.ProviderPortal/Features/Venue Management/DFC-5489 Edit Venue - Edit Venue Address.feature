Feature: DFC-5489 Edit Venue - Edit Venue Address
	As a user
    I need to edit the venue address
    so that the venue has the up to date address

Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Your Venues Pages
	When I enter 10028015 and click search
	When I click Edit against the first venue
	Then I am on the Edit venue details page

@CI
Scenario: Edit Venue Address
	When I click Change Address on Edit Venue page
	Then I am on Edit Venue Address page
	When I edit the venue address to b14 7rz
	And I chose the following address 8 York Road Kings Heath, Birmingham, B14 7RZ
	And I click continue on edit venue address page
	Then I am on the Edit venue details page