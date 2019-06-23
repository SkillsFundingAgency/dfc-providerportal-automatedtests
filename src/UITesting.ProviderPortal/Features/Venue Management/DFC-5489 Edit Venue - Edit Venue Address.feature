Feature: DFC-5489 Edit Venue - Edit Venue Address
	As a user
    I need to edit the venue address
    so that the venue has the up to date address

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Your Venues Pages
	When I click Edit against the first venue
	Then I am on the Edit venue details page

@CI
Scenario: DFC-5489 Edit Venue Address
	When I click Change Address on Edit Venue page
	Then I am on Edit Venue Address page
	When I edit the venue address to b14 7rz
	And I chose the following address 8 York Road
	And I click continue on edit venue address page
	Then I am on the Edit venue details page