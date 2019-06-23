Feature: COUR-71 Delete a Course
	In order to maintain my courses
	As a provider
	I want to be able to delete a course

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
Scenario: COUR-71 Delete a Course
	Given I have selected a course run to delete
	When I click delete
	Then the course should be deleted