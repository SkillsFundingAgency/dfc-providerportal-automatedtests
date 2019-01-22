Feature: View Live Venues
	In order to look at all venues
	As a provider
	I want to be able to list all my venues

@CI
Scenario: View Live Venues
	Given I have accessed the Course Directory
	## Use Provider Search to Navigate o course for a Provider
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses
	## End of Provider Search Steps
	#And I have searched for a PRN Number "UKPRN Number"
	Given I have navigated to the Your Venues Pages
	#Then all venues for that provider should be displayed with complete address
	Then links to Edit and Archive should be visible
	And Add Venue Button should be visible
#	And I should be able to view my archived venues
