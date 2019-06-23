Feature: COUR-244 Copy Course
	In order to create a course
	As a provider
	I want to be able to copy a course

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10032433" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have clicked the Main Qualification
	And I have clicked one of the courses available
	Then I should be able to view the course runs.	

@CI
Scenario: COUR-244 Copy a Course
	Given I have selected a course run to copy
	Then Copy Course page should be displayed
	When I clik save to copy the course
	Then the course should be added