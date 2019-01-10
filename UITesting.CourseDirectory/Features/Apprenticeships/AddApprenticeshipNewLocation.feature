Feature: Add Apprenticeship New Location
	In order to be able to add a new apprenticeship location
	As a provider
	I want to test adding a new location

@mytag
Scenario: Add new Apprenticeship Location
	Given I have accessed and logged into course directory
	And I have clicked on Apprenticeships Menu and selected Add new Location
	Then the Add new Location screen should be displayed.
	And I have entered the required details and clicked Create
	Then a new location should be created
	And the location should be listed in the View All Locations page
