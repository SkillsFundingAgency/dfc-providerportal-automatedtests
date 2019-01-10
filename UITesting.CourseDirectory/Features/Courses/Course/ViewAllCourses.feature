Feature: View All Courses
	In order to enusre I can view all courses
	As a provider
	I want to be able to test view all courses

@Courses
Scenario: View all courses
	Given I have logged into course directory as a provider
	And I have clicked the courses menu and selected View All courses
	Then I should be able to view a list of all courses
