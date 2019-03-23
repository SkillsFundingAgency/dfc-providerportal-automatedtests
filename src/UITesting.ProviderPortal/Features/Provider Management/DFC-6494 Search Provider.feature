Feature: DFC-6494 Search Provider
	In order to view provider details
	As a provider
	I want to be able to search for providers

@CI
Scenario:DFC-6494 Search Provider
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have accessed the Qualifications page	
	And I have entered a Qualification Name "Biology"
	And I click the link to Add Qualification
