Feature: Edit Venue - Venue Found
	In order to be able to edit venue details
	As a provider
	I want to be able to add/edit venue details

@mytag
Scenario: Edit Venue-Venue Found
	Given I have logged into course directory using Provider Login
	And I have accessed all venues via courses menu
	And I want to Search for "New Campus"
	And I have found the Venue and clicked Edit
	Then I want to add an email to the venue and click Save
	Then the venue should be updated with the email.
