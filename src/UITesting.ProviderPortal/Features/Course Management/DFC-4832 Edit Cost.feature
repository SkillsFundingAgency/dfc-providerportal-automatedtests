Feature: DFC-4832 Edit Cost
	In order to be able to change the course details
	As a Provider
	I want to be able to change the course cost


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
Scenario: DFC-4832 Update cost with valid value
	Given I have selected a course run to update
	And I have changed the cost to 1234.56
	When I Click Save

@CI
Scenario: DFC-4832 Update cost with a value without decimals_BUG_COUR-1158
	Given I have selected a course run to update
	And I have changed the cost to 123456
	When I Click Save

@CI
Scenario: DFC-4832 Update cost with a value with one decimals
	Given I have selected a course run to update
	And I have changed the cost to 1234.5
	When I Click Save