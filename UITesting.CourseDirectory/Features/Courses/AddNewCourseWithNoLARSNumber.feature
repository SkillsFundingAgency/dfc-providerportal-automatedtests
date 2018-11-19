Feature: Add New Course With No LARS number
	In order to be able to add a course with no LARS number
	As a provider
	I want to be able to test adding a new course

@Courses
Scenario: Add a new course with no LARS Number
	Given I have logged into course directory as a provider
	And I have accessed add new course via course menu
	When I enter the required details
	Then the new course should be added
