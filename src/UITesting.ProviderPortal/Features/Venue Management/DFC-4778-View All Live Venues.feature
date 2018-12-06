Feature: View Live Venues
	In order to look at all venues
	As a provider
	I want to be able to list all my venues

@CI
Scenario: View Live Venues
	Given I have accessed the Course Directory
	And I have searched for a PRN Number "UKPRN Number" 
	Then all venues for that provider should be displayed with complete address
	And links to Edit and Archive should be visible
	And Add Venue Button should be visible
	And I should be able to view my archived venues
