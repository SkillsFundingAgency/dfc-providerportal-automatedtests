Feature: DFC-5488 Edit Venue - Edit Venue Name
	As a user
	I need to edit the venue name
	so that I can use the venue name is up to date

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
Scenario: DFC-5488 Edit Venue Name
	When I click Change Name on Edit Venue page
	Then I am on Edit Venue name page
	When I edit the venue name to New Venue Name
	And I click continue on edit venue name page
	Then I am on the Edit venue details page