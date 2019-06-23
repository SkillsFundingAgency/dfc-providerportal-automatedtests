
Feature: DFC-5844 Add Online Course
As a User I want to select the ‘Online’ option for Delivery Mode
so that I can assign the ‘Online’ option for the course within the Course Directory

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have accessed the Qualifications page	
	And I have entered a Qualification Name "zoo"
	And I click the link to Add Qualification
	And I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button



@CI
Scenario: DFC-5844 Add a course with Online Delivery
	When I enter the following in the course name field Course test
	When I select delivery mode Online
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 999
	And I select duration length 9
	And I select duration unit Weeks
	And I click Publish
	
	


	
