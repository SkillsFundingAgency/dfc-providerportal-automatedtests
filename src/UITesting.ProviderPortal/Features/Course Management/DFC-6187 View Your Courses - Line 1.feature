Feature: DFC-6187 View Your Courses - Line 1
	In order to View details of my courses
	As a Provider
	I want to view details of my line 1 of my courses

@CI
Scenario: View Line 1 of your courses
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have clicked the Main Qualification
	And I have clicked one of the courses available
	Then I should be able to view the course runs.
	And a link to view the course description link
	
