Feature: COUR-350 SearchApprenticeship
	As a User
	I want the functionality to search for a apprenticeship training 
	so that I can select the appropriate apprenticeship

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in


@CI
Scenario: COUR-351 Search for an apprenticeship - Valid Search term
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for Plumbing
	Then the Results are displayed

@CI
Scenario: COUR-351 Search for an apprenticeship - Valid Search term using brackets
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for Engineer (degree)
	Then the Results are displayed

@CI
Scenario: COUR-351 Search for an apprenticeship - Valid Search term using space
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for information technology
	Then the Results are displayed

@CI
Scenario: COUR-351 Search for an apprenticeship - Valid Search term using all Caps
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for INFORMATION
	Then the Results are displayed

#@CI
#Scenario: COUR-351 Search for an apprenticeship - Valid Search term using numbers
#	Given I have accessed the Apprenticeship Search page
#	When I use apprenticeship search to search for ICT 1
#	Then the Results are displayed

@CI
Scenario: COUR-351 Search for an apprenticeship - Valid Search terms 3 chars
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for plu
	Then the Results are displayed

@CI
Scenario: COUR-351 Search for an apprenticeship - Invalid Valid Search term
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for plumber/plumbing
	Then the No Results error message is displayed

@CI
Scenario: COUR-351 Search for an apprenticeship - Less than 3 chars BUG COUR-1146
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for pl
	Then the No Results error message is displayed

@CI
Scenario: COUR-432 Search for an apprenticeship - Search Results
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for Information
	Then the Results are displayed
	And Each result displays the apprenticeship details

@CI
Scenario: COUR-432 Search for an apprenticeship - Framework Label
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for plumbing and heating
	Then the Results are displayed
	And the Framework label is present

@CI
Scenario: COUR-475 Select an apprenticeship
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for Plumbing
	Then the Results are displayed
	And the user select the apprenticeship

