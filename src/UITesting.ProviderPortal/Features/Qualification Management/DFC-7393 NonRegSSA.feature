Feature: DFC-7393 NonRegSSA
	In order to select a Non Reg Provision
	As a provider
	I want to be able to add a non reg provision as my published course

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I Navigate to Regulated Qualifications page
	And I have selected Non Regulated Option and Clicked Next
	Then the Unregulated courses page should be displayed
	Given I have clicked  I dont know z code link
	Then Unknown Z code page should be displayed

@CI
Scenario: DFC-7393 Validate SSA Page
	Given I have accessed the UnKnown Z Code Page
	Then I should be able to view the First Level and Second Level dropdowns
	And the Back Link should be visible

@CI
Scenario: DFC-7393 Click Back to go back to Unregulated courses page
	Given I have accessed the UnKnown Z Code Page
	When I click the Back Link
	Then Unregulated course page should be displayed

@CI
Scenario: DFC-7393 Select First Level and Second Level dropdowns and validate the results page
	Given I have accessed the UnKnown Z Code Page
	When I Select First Level and Second Level
	Then Level filter and Category filter selections should be visible
	And a link to add this provision should be visible

@CI
Scenario: DFC-7393 Select First Level and Second Level dropdowns and add selected course 
	Given I have accessed the UnKnown Z Code Page
	When I Select First Level and Second Level
	And I click the Add this Provision link
	Then add course page should be displayed
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button
	Then add course run should be displayed
	When I enter the following in the course name field Course test for non regulated course
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 03 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 2000
	And I select duration length 12
	And I select duration unit Weeks
	And I select the first venue in the venues list
	And I click Publish
	Then the course should be listed in the Your courses page

@CI
Scenario: DFC-7393 Select First Level and Second Level dropdowns and add selected course from Page 2
	Given I have accessed the UnKnown Z Code Page
	When I Select First Level and Second Level
	And select page 2 from pagination
	And I click the Add this Provision link
	Then add course page should be displayed
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button
	Then add course run should be displayed
	When I enter the following in the course name field Course test for non regulated course
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 02 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 2000
	And I select duration length 12
	And I select duration unit Weeks
	And I select the first venue in the venues list
	And I click Publish
	Then the course should be listed in the Your courses page

@CI
Scenario: DFC-7393 Select Level filter, category filter and click reset
	Given I have accessed the UnKnown Z Code Page
	When I Select First Level and Second Level
	And I have selected the first checkbox in Level filter Level 
	And I have selected the first checkbox in Category Filter
	Then a reset link should be visible
	When I Click the reset link
	Then all the checkboxes in Level and category filter should be visible
	And the selected checkboxes should be deselected.