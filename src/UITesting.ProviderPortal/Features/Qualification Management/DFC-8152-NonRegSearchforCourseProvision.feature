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
Scenario: Validate the Unregulated courses page
	Given I have accessed the Unregulatd courses page
	Then a Back Link should be visible
	And a text box to enter a Z code should be visble
	And a I don't know the Z code link should be visible
@CI
Scenario: Click back to go back to the Regulated qualifications page
	Given I have accessed the Unregulated courses page
	And I click the Back Link
	Then the Regulated Qualifications page should be displayed
@CI
Scenario: Enter Valid Z Code
	Given I have accessed the Unregulated courses page
	And I have entered a valid Z code "Z00004395"
	And I click the search button
	Then I should be able to view the Non regulated course details
	And I should be able to view the Choose button and the Cancel Link
@CI
Scenario: Enter blank Z Code
	Given I have accessed the Unregulated courses page
	And I have entered a blank Z code " "
	And I click the search button
	Then an error message should be displayed ""
@CI
Scenario: Enter Invalid Z code- code without z
	Given I have accessed the Unregulated courses page
	And I have entered a z code "10000000"
	And I click the search button
	Then an error message should be displayed ""
@CI
Scenario: Enter Invalid Z code- less than 8 characters
	Given I have accessed the Unregulated courses page
	And I have entered a z code "Z000122"
	And I click the search button
	Then an error message should be displayed ""
@CI
Scenario: Enter Z code- Not available in database
	Given I have accessed the Unregulated courses page
	And I have entered a z code "Z0000439A"
	And I click the search button
	Then an error message should be displayed ""	
#@CI
#Scenario: Add non regulated course
#	Given I have accessed the Unregulated courses page
#	And I have entered a valid Z code "Z00004395"
#	And I click the search button
#	Then I should be able to view the Non regulated course details
#	And I click the choose button
#	Then add course page should be displayed
@CI
Scenario: Enter valid Z code-Click Cancel link
	Given I have accessed the Unregulated courses page
	And I have entered a valid Z code "Z00004395"
	And I click the search button
	Then I should be able to view the Non regulated course details
	When i click Cancel Link 
	Then Unregulated course page should be displayed
	And the Z code text box should be empty
@CI
Scenario: Enter valid Z code-Click Back link
	Given I have accessed the Unregulated courses page
	And I have entered a valid Z code "Z00004395"
	And I click the search button
	Then I should be able to view the Non regulated course details
	When i click Back Link 
	Then Unregulated course page should be displayed
	And the Z code text box should be empty
@CI
Scenario: Click I don't know Z Code
	Given I have accessed the Unregulated courses page
	And I have clicked  I dont know z code link
	Then Unknown Z code page should be displayed