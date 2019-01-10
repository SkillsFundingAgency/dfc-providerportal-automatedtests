Feature: View Apprenticeship Locations
	In order to look at locations where apprenticeships are available
	As a Provider
	I want to be able to view all apprenticeship locations

@regression
Scenario: View all apprenticeship Locations
	Given I have logged into course directory
	When I press click the Apprenticeship menu and select View all locations
	Then I should be able to view the locations in a table format
