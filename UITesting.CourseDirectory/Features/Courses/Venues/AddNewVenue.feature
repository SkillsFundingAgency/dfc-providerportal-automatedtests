Feature: Add New Venue
	In order to Add a new venue
	As a provider
	I want to be able to add a venue via Add Venue screen

@regression
Scenario: Add a Venue
	Given I have logged onto Course Directory as a provider
	And I have accessed the Add Venue screen via course menu
	And I have entered the required details to add a new venue and clicked create
	Then the new venue should be saved and visible on the All venues screen
