Feature: DFC-4761 Edit Venue - View Venue Details
	As a User
	I need to edit the details of a venue
	so that I can ensure the venue details are up to date

Background:
	Given I have logged into course directory as a provider
	## Use Provider Search to Navigate o course for a Provider
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Your Venues Pages



@CI
Scenario: Select venue to Edit
	When I click Edit against the first venue
	Then I am on the Edit venue details page
