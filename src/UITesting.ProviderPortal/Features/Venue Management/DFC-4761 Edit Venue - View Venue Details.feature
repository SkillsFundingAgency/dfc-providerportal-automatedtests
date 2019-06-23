Feature: DFC-4761 Edit Venue - View Venue Details
	As a User
	I need to edit the details of a venue
	so that I can ensure the venue details are up to date

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Your Venues Pages

@CI
Scenario: DFC-4761 Select venue to Edit
	When I click Edit against the first venue
	Then I am on the Edit venue details page
