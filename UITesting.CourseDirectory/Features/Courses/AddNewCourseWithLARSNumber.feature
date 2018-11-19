Feature: Add New Course With LARSNumber
	In order to be able to add a course with a LARS number
	As a provider
	I want to be able to test adding a new course

@Courses
Scenario: Add a new course with LARS Number
	Given I have accessed course directory as a provider
	And I have accessed add new course via course menu and entered a LARS Number
	Then details of the course should be displayed in the fields
	Then the new course should be added when I click Save
