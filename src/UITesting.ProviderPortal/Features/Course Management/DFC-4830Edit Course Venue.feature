Feature: DFC-4830 Edit Course Venue
	In order to be able to change the course details
	As a Provider
	I want to be able to change the course venue

@CI
Scenario: Edit Course Venue
	Given I have accessed course directory as a provider
	And I login with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have clicked the Main Qualification
	And I have clicked one of the courses available
	Then I should be able to view the course runs.	
	Given I have selected a course run to update
	And I have changed the course venue to Farnham Sixth Form College
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the new course venue should be saved as Farnham Sixth Form College
	#Revert changes for next test
	Given I have logged to course directory as a provider
	And I have searched for UKPRN "10002815" and clicked search
	And I have clicked View Courses button to see a list of courses
	Given I have clicked the Main Qualification
	Given I have clicked one of the courses available
	Then I should be able to view the course runs.
	Given I have selected a course run to update
	And I have changed the course venue to Show_Tell
	When I Click Save
