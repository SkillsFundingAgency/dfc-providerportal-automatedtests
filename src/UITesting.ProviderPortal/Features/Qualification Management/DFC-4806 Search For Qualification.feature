Feature: DFC-4806 Search For Qualification
	In order to Add a Qualification
	As a provider
	I want to be able to search for a Qualification using LARS/QAN Reference Number 

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	Given I have accessed the Qualifications page	
	And there is a field to enter the LARS/QAN number.

@CI
Scenario: DFC-4806 Search for a Qualification by LARS/QAN Reference Number
	Given I have entered LARS/QAN Number "60060955"
	Then I want to see the Qualifications listed for that LARS/QAN Number
	And I want to see LARS/QAN number "LARS/QAN", Level "Level" and awarding body "Awarding body" for each qualification
	And I want to see a Link to add this qualification.
	And I want to see Qualification Level Filter "Qualification level"
	And I want to see Awarding Organisation Filter on the screen "Awarding organisation"

@CI
Scenario: DFC-4806 Search for a Qualification when user enters an invalid search term
	Given that I have entered an invalid search term "xxxxx"
	Then I want to see a validation message "No records found"

@CI
Scenario: DFC-4806 Search for a Qualification using Qualification Name
	Given I have entered a Qualification Name "Biology"
	Then I want to see the Qualifications listed for that LARS/QAN Number
	And I want to see LARS/QAN number "LARS/QAN", Level "Level" and awarding body "Awarding body" for each qualification
	And I want to see the number of results returned for the name "Found results for Biology"
	And I want to see a Link to add this qualification.
	And I want to see Level and Awarding body on the screen.

@CI
Scenario: DFC-4806 Select filters for Qualification Level
	Given I have retrieved results for a search term
	And I select one level for qualification level

@CI
Scenario: DFC-4806 Select filters for Awarding Body
	Given I have retrieved results for a search term
	And I have selected one awarding body

@CI
Scenario: DFC-4806 Clear filters when reset is clicked
	Given I have entered a Qualification Name "Biology"
	Given I have selected filters in Qualification Level and/or Awarding body
	When I click reset
	Then all filters should be cleared.