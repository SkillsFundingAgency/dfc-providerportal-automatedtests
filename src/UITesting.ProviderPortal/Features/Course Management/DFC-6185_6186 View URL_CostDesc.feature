Feature: DFC-6185_6816 View URL_CostDesc
	In order to View course details
	As a provider
	I want to be view details of URL and Cost Description


Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have clicked the Main Qualification
	And I have clicked one of the courses available
	Then I should be able to view the course runs.	


@CI
Scenario: DFC-6185 Edit URL with Valid Data
	Given I have selected a course run to update
	And I have changed the URL to http://www.testing.co.uk
	When I Click Save
