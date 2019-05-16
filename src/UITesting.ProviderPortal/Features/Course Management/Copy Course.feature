Feature: Copy Course
	In order to create a course
	As a provider
	I want to be able to copy a course

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10001800" and clicked search
	When I click to view my courses
@CI
Scenario: Copy a Course
	Given I have selected a course
	When I clicked the Copy Course
	Then Copy Course page should be displayed
	Given I have accessed the selected course run data
	When I  Save the data
	Then the course should be added
