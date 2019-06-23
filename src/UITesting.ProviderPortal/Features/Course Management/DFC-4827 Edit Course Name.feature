Feature: DFC-4827 Edit Course Name
	In order to be able to change the course details
	As a Provider
	I want to be able to change the course name

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
Scenario: DFC-4827 Edit Course Name with valid data
	Given I have selected a course run to update
	And I have changed the course name to "Updated Course Name"
	When I Click Save

@CI
Scenario: DFC-4827 Edit Course Name with null data
	Given I have selected a course run to update
	And I have changed the course name to " "
	When I Click Save leading to Error
	Then the Error message for Course Name should be displayed Enter course name

@CI
Scenario: DFC-4827 Edit Course Name with 255 characters
	Given I have selected a course run to update
	And I have changed the course name to "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV"
	When I Click Save

@CI
Scenario: DFC-4827 Edit Course Name with more than 255 characters
	Given I have selected a course run to update
	And I have changed the course name to "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVB"
	When I Click Save leading to Error
	Then the Error message for Course Name should be displayed The maximum length of Course Name is 255 characters

@CI
Scenario: DFC-4827 Edit Course Name with non-ascii characters
	Given I have selected a course run to update
	And I have changed the course name to "GCEЕлизавета A Level in Biology - Testing"
	When I Click Save leading to Error
	Then the Error message for Course Name should be displayed Course Name contains invalid characters

@CI
Scenario: DFC-4827 Edit Course Name with trailing and leading spaces
	Given I have selected a course run to update
	And I have changed the course name to " Course name update 001 "
	When I Click Save