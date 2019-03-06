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
Scenario: Edit Course Name with valid data
	Given I have accessed the selected course run data
	And I have entered the following course name "Award in Computerised Accounts-Edited"
	When I click Save
	Then the course run should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data
@CI
Scenario: Edit Course Name with blank data
	Given I have accessed the selected course run data
	And I have entered the following course name " "
	When I click Save
	Then the following course name message should be displayed "Enter course name"
Scenario: Edit course run with valid defined start date when Classroom mode is selected
	Given I have accessed the selected course run data
	And I have selected "Classroom" as deleivery mode
	And I have entered "25" in Day, "09" in Month and "2019" in Year
	When I click Save
	Then the date should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data	
Scenario: Edit course run with invalid defined start date when Classroom mode is selected
	Given I have accessed the selected course run data
	And I have selected "Classroom" as deleivery mode
	And I have entered "31" in Day, "02" in Month and "2019" in Year
	When I click Save
	Then the following error date message should be displayed "Invalid date"