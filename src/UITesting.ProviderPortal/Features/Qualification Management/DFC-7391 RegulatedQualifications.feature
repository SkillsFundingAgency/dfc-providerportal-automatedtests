Feature: DFC-7391 RegulatedQualifications
	In order to Add a qualification
	As a provider
	I want to able to select a regulated or non regulated course

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search

@CI
Scenario: DFC-7391 Validate Qualification Options
	Given I have accessed the Regulated Qualifications page
	Then I need to view Regulated "Regulated", "NonRegulated" Option and a Next Button

@CI
Scenario: DFC-7391 Select Regulated Qualifications
	Given I have accessed the Regulated Qualifications page
	When I select the Regulated Option
	And I click Next
	Then Lars Search page should be displayed

@CI
Scenario: DFC-7391 Select Non Regulated Qualifications
	Given I have accessed the Regulated Qualifications page
	When I select the Non Regulated Option
	And I click Next
	Then Unregulated Courses page should be displayed

@CI
Scenario: DFC-7391 Display error message when no option is selected
	Given I have accessed the Regulated Qualifications page
	When no option is selected
	And I click Next
	Then an Error message should be displayed "Choose 1 option to continue"