Feature: DFC-6185_6816 View URL_CostDesc
	In order to View course details
	As a provider
	I want to be view details of URL and Cost Description


Background:
	Given I have accessed course directory
	And I have entered "10043577" and clicked search provider
	Then I want to view the course details
@CI
Scenario: View and close Course URL
	Given I have clicked view URL Link
	Then I should be able to view the Course URL
	And the URL text should not be editable
	When I click close url
	Then the URL text should be hidden
@CI
Scenario: View and close Course Cost Description
	Given I have clicked the Course Cost description
	Then I should be able to view the course cost description
	And the course cost description should not be editable
	When I click close cost description
	Then the course cost description text should be hidden
