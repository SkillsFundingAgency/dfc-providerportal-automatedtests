Feature: View All Venues
	In order to enusre I can view all courses venues
	As a provider
	I want to be able to test all venues for courses

@Courses
Scenario: View all course venues
	Given I have logged into course directory
	And I have clicked the courses menu and selected View All venues
	Then I should be able to view all venues for courses
