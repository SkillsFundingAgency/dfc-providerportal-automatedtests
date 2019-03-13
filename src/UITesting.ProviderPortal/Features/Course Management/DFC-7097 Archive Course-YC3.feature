Feature: DFC-7097 Archive Course-YC3
	In order to archive a course
	As a provider
	I want to be able to archive a course using Archive button

Background: 
Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	And I select Edit Course Description
	Then Edit Course screen should be displayed
@CI
Scenario: 
