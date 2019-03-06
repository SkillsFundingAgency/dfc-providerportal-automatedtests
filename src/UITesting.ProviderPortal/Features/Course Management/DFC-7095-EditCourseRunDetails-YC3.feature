Feature: DFC-7095-EditCourseRunDetails-YC3
	In order to edit a course run
	As a provider
	I want to be able to select edit course details and change course data

Background: 
Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	And I selected a Course and corresponding course run
	And I have clicked Edit Course Details 
	Then Edit Course details screen should be displayed
@CI
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
