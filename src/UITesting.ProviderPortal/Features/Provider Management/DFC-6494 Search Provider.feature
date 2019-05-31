Feature: DFC-6494 Search Provider
	In order to view provider details
	As a provider
	I want to be able to search for providers

Background:  
Given I have accessed course directory as a provider
And I login as admin with user and password
Then I am logged in


@CI
Scenario:DFC-6494 Search Provider
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	Given I have accessed the Qualifications page	
	And I have entered a Qualification Name "Biology"
	And I click the link to Add Qualification

@CI
Scenario:COUR-481 Search Provider using UKPRN full
	Given I have searched for UKPRN "10002815" and clicked search
	Then 1 providers is displayed in the search results
	And the UKPRN for the provider is 10002815

@CI
Scenario:COUR-481 Search Provider using UKPRN full not onboarded
	Given I have searched for UKPRN "10002815" and clicked search
	Then No results message is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using UKPRN partial
	Given I have searched for UKPRN "1000" and clicked search
	Then nn providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using UKPRN below min entry
	Given I have searched for UKPRN "100" and clicked search
	Then 0 providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using Provider Name full
	Given I have searched for UKPRN "University College Birmingham" and clicked search
	Then 1 providers is displayed in the search results
	And the Name for the provider is University College Birmingham

@CI
Scenario:COUR-481 Search Provider using Provider Name full - not onbaorded
	Given I have searched for UKPRN "University College Birmingham" and clicked search
	Then No results message is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using Provider Name partial
	Given I have searched for UKPRN "Univ" and clicked search
	Then 1 providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using Provider Name below min entry
	Given I have searched for UKPRN "Uni" and clicked search
	Then 0 providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using Town full
	Given I have searched for UKPRN "Birmingham" and clicked search
	Then nn providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using Town partial
	Given I have searched for UKPRN "Bir" and clicked search
	Then nn providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using Town Name below min entry
	Given I have searched for UKPRN "Bi" and clicked search
	Then 0 providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using Postcode full
	Given I have searched for UKPRN "EC2A 1RS" and clicked search
	Then 1 providers is displayed in the search results
	And the Name for the provider is MARCUS EVANS (UK HOLDINGS) LIMITED

@CI
Scenario:COUR-481 Search Provider using Postcode partial
	Given I have searched for UKPRN "EC2" and clicked search
	Then nn providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using Postcode below min entry
	Given I have searched for UKPRN "EC" and clicked search
	Then 0 providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using invalid search input
	Given I have searched for UKPRN "EC" and clicked search
	Then 0 providers is displayed in the search results

@CI
Scenario:COUR-481 Search Provider using UKPRN and view provider
	Given I have searched for UKPRN "10002815" and clicked search
	Then 1 providers is displayed in the search results
	And the UKPRN for the provider is 10002815
	When I click the view link
	Then provider details page is displayed