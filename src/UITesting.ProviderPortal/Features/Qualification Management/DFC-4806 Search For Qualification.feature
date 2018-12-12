Feature: DFC-4806 Search For Qualification
	In order to Add a Qualification
	As a provider
	I want to be able to search for a Qualification using LARS/QAN Reference Number or by Qualification Name

Background:
	Given I have accessed the Course Directory as a provider
	And I have accessed the Qualifications page	
@CI
Scenario: Search for a Qualification by LARS/QAN Reference Number
	Given I have entered LARS/QAN Number 
	Then I want to see the Qualification for that LARS/QAN Number
	And I want to validate the returned results
@CI
Scenario: Search for a Qualification when user enters an invalid LARS/QAN Reference Number
	Given that I have entered and invalid LARS/QAN Number
	Then I want to see a validation message should be displayed.
@CI
Scenario: Search for a Qualification by Qualification Name
	Given I have entered a full Qualification name
	Then I want to see all the qualificatiions with that Qualification Name
	And I want to validate the returned results
