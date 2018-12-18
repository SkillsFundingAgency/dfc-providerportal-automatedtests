Feature: DFC-4806 Search For Qualification
	In order to Add a Qualification
	As a provider
	I want to be able to search for a Qualification using LARS/QAN Reference Number 

Background:
	Given I have accessed the Course Directory as a provider
	And I have accessed the Qualifications page	
	And there is a field to enter the LARS/QAN number.
@CI
Scenario: Search for a Qualification by LARS/QAN Reference Number
	Given I have entered LARS/QAN Number "60060955"
	Then I want to see the Qualifications listed for that LARS/QAN Number
	And I want to see LARS/QAN number, Level and awarding body for each qualification
	And I want to see a Link to add this qualification.
	And I want to see Qualification Level Filter "Qualification Level"
	And I want to see Awarding Organisation Filter on the screen "Awarding Organisation"
@CI
Scenario: Search for a Qualification when user enters an invalid search term
	Given that I have entered an invalid search term "xxxxx"
	Then I want to see a validation message "No records found"
@CI
Scenario: No results to be returned when LARS/QAN number is not entered
	Given that I have not entered a LARS/QAN Number 
	Then no results should be returned and page should be empty
@CI
Scenario: Search for a Qualification using Qualification Name
	Given I have entered a Qualification Name "Biology"
	Then I want to see the Qualifications listed for that LARS/QAN Number
	And I want to see LARS/QAN number, Level and awarding body for each qualification
	And I want to see a Link to add this qualification.
	And I want to see Level and Awarding body on the screen.
@CI
Scenario: Check Qualification Level filter for returned results
	Given I have retrieved results for a LARS/QAN Number
	And I click the + sign for Qualification Level
	Then Entry Level and levels 1-8 should be displayed along with a check box to select the level
@CI
Scenario: Check Awarding body filter for returned results
	Given I have retrieved results for a LARS/QAN Number
	And I click the + sign for Awarding body
	Then the awarding bodies with a check box to select that body should be visible
	

