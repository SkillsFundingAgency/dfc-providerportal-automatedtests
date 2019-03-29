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
Scenario: Edit URL with Valid Data
	Given I have selected a course run to update
	And I have changed the URL to http://www.testing.co.uk
	When I Click Save


# KADIR - THIS IS NO LONGER APPLICABLE IN YC3
#@CI
#Scenario: View and close Course URL
#	Given I have clicked view URL Link
#	Then I should be able to view the Course URL
#	And the URL text should not be editable
#	When I click close url
#	Then the URL text should be hidden

# KADIR - THIS IS NO LONGER APPLICABLE IN YC3
#@CI
#Scenario: View and close Course Cost Description
#	Given I have clicked the Course Cost description
#	Then I should be able to view the course cost description
#	And the course cost description should not be editable
#	When I click close cost description
#	Then the course cost description text should be hidden
