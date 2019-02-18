Feature: DFC-4832 Edit Cost
	In order to be able to change the course details
	As a Provider
	I want to be able to change the course cost

Background:
	Given I have logged to course directory 
	And I have searched for a UKPRN "10043577" and clicked search
	And I have clicked View Courses button
	And I have clicked the Main Qualification Chevron
	And I have clicked one of the courses available Chevron
	Then I should be able to view the course run details.	
@CI
Scenario: Update cost with valid value
	Given I have selected a course cost to update
	And I have updated the cost as "1500.00"
	Then I'm able to view Save, Discard and Preview
	And I press save
	Then the cost should be updated with 1500.00
@CI
Scenario: Update cost with value more than 999999.99
	Given I have selected a course cost to update
	And I have updated the cost as "1000000.99"
	Then I'm able to view Save, Discard and Preview
	And I press save
	Then there should be an error message "Maximum value for cost is £999,999.99"
##@CI
##Scenario: Update cost and cost detail with null value
##	Given I have selected a course cost to update
##	And I have updated the cost as "  "
##	Then I'm able to view Save, Discard and Preview
##	And I press save
##	Then there should be an error message "Enter the cost in pounds and pence"
@CI
Scenario: Update cost with a value without decimals
	Given I have selected a course cost to update
	And I have updated the cost as "2000"
	Then I'm able to view Save, Discard and Preview
	And I press save
	Then the cost should be updated with decimal places as "2000.00"
@CI
Scenario: Update cost with a value with one decimals
	Given I have selected a course cost to update
	And I have updated the cost as "300.0"
	Then I'm able to view Save, Discard and Preview
	And I press save
	Then the cost should be updated with decimal places as "300.00"