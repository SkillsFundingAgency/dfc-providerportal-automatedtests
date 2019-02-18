Feature: View Live Venues
	In order to look at all venues
	As a provider
	I want to be able to list all my venues

@CI
Scenario: View Live Venues
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	#And I have searched for a PRN Number "UKPRN Number"
	Given I have navigated to the Your Venues Pages
	#Then all venues for that provider should be displayed with complete address
	Then links to Edit and Archive should be visible
	And Add Venue Button should be visible
#	And I should be able to view my archived venues
