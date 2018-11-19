Feature: Add New Venue
	In order to create a new venue
	As a provider
	I want to be able to add a new venue via course directory

@Courses
Scenario: Add a new course venue
	Given I logged into course directory as a provider
	And I have accessed add a new venue screen via courses menu
	And I have entered the required values and clicked Create
	Then the new venue should be created 
	And the venue should be listed in the All venues screen
