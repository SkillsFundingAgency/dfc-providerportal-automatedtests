Feature: DFC-4827 Edit Course Name
	In order to be able to change the course details
	As a Provider
	I want to be able to change the course name

Background:
	Given I have accessed course directory as a provider
	And I login with liam.wright@contractsonline.org and oCtober616!!
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	And I have clicked View Courses button to see a list of courses
	And I have clicked the Main Qualification
	And I have clicked one of the courses available
	Then I should be able to view the course runs.	
@CI
Scenario: Edit Course Name with valid data
	Given I have selected a course run to update
	And I have changed the course name to "Updated Course Name"
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the new course name should be saved as "Updated Course Name"	
@CI
Scenario: Edit Course Name with null data
	Given I have selected a course run to update
	And I have changed the course name to " "
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the Error message should be displayed "Enter Course Name"
@CI
Scenario: Edit Course Name with 255 characters
	Given I have selected a course run to update
	And I have changed the course name to "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV"
	Then Save , Discard and preview buttons should be visible 
	When I Click Save
	Then the new course name should be saved as "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV"
@CI
Scenario: Edit Course Name with more than 255 characters
	Given I have selected a course run to update
	And I have changed the course name to "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVB"
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the Error message should be displayed "The maximum length of Course Name is 255 characters"
@CI
Scenario: Edit Course Name with non-ascii characters
	Given I have selected a course run to update
	And I have changed the course name to "GCEЕлизавета A Level in Biology - Testing"
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the Error message should be displayed "Course Name contains invalid characters"
@CI
Scenario: Edit Course Name with trailing and leading spaces
	Given I have selected a course run to update
	And I have changed the course name to " Course name update 001 "
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the course name should be saved without leading or trailing spaces as "Course name update 001"