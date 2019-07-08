Feature: DFC-8152-NonRegSearchforCourseProvision
	In order to add Non Regulated Course
	As a provider
	I want to be able to search for Non Regulated Courses

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I Navigate to Regulated Qualifications page
	And I have selected Non Regulated Option and Clicked Next
	Then the Unregulated courses page should be displayed

@CI
Scenario: DFC-8152 Validate the Unregulated courses page
	Given I have accessed the Unregulated courses page
	Then a Back Link should be visible
	And a text box to enter a Z code should be visble
	And a I don't know the Z code link should be visible

@CI
Scenario: DFC-8152 Click back to go back to the Regulated qualifications page
	Given I have accessed the Unregulated courses page
	And I click the Back Link on the unregulated courses page
	Then the Regulated Qualifications page should be displayed

@CI
Scenario: DFC-8152 Enter Valid Z Code
	Given I have accessed the Unregulated courses page
	And I have entered a valid Z code "Z0004395"
	And I click the search button
	Then I should be able to view the Non regulated course results page
	And I should be able to view the Choose button and the Cancel Link

@CI
Scenario: DFC-8152 Enter blank Z Code
	Given I have accessed the Unregulated courses page
	And I have entered a blank Z code ""
	And I click the search button
	Then an blank z code error message should be displayed "Enter a z code to search"

@CI
Scenario: DFC-8152 Enter Invalid Z code- code without z
	Given I have accessed the Unregulated courses page
	And I have entered a z code "10000000"
	And I click the search button
	Then an error message should be displayed "Code must start with Z followed by 7 numbers or letters"

@CI
Scenario: DFC-8152 Enter Invalid Z code- less than 8 characters
	Given I have accessed the Unregulated courses page
	And I have entered a z code "Z000122"
	And I click the search button
	Then an error message should be displayed "Code must start with Z followed by 7 numbers or letters"

@CI
Scenario: DFC-8152 Enter Z code- Not available in database
	Given I have accessed the Unregulated courses page
	And I have entered a z code "Z0000000"
	And I click the search button
	Then an unavailable Z Code error message should be displayed "Z code does not exist"	

@CI
Scenario: DFC-8152 Add non regulated course
	Given I have accessed the Unregulated courses page
	And I have entered a valid Z code "Z0004395"
	And I click the search button
	Then I should be able to view the Un regulated courses results page
	And I click the choose button
	Then add course page should be displayed
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button
	Then add course run should be displayed
	When I enter the following in the course name field Course test for non regulated course
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 999
	And I select duration length 9
	And I select duration unit Weeks
	And I select the first venue in the venues list
	And I click Publish
	Then the course should be listed in the Your courses page

@CI
Scenario: DFC-8152 Enter valid Z code-Click Cancel link
	Given I have accessed the Unregulated courses page
	And I have entered a valid Z code "Z0004395"
	And I click the search button
	Then I should be able to view the Un regulated courses results page
	When i click Cancel Link 
	Then the Regulated Qualifications page should be displayed


@CI
Scenario: DFC-8152 Click I don't know Z Code
	Given I have accessed the Unregulated courses page
	And I have clicked  I dont know z code link
	Then Unknown Z code page should be displayed