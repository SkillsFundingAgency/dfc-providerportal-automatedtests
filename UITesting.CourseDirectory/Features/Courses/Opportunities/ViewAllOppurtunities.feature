Feature: View All Oppurtunities
	In order to enusre I can view all oppurtunities
	As a provider
	I want to be able to test view all oppurtunities

@Courses
Scenario: View all Oppurtunities
	Given I have accessed the course directory as a provider
	And I have clicked the courses menu and selected View All oppurtunities
	Then I should be able to view a list of all oppurtunities
