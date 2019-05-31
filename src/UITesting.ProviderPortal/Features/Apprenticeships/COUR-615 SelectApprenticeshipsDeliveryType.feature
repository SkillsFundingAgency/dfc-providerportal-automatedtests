﻿Feature: COUR-615 SelectApprenticeshipsDeliveryType
	In order to select a delivery type for apprenticeships
	As a user
	I want to be able to a delivery method

Background: 
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for Plumber
	Then the Results are displayed
	Given I have selected an apprenticeship
	And I have accessed the Apprenticeships training details page
	When I enter apprenticeships information "Test Apprenticeship"
	And I have entered a website "http://www.google.com"
	And I have entered an email "Testapp@gmail.com"
	And I have entered a telephone "07112234598"
	And I have entered contact details " "
	And I have clicked continue
	Then the apprenticeship delivery screen should be visible 
@CI
Scenario: Select Apprenticeship location
	Given I have accessed the apprenticeship delivery screen
	And I have selected locations as delivery type
	When I press continue location
	Then the Apprenticeships delivery options screen is displayed
@CI
Scenario: Select employer address
	Given I have accessed the apprenticeship delivery screen
	And I have selected employers address as delivery type
	When I press continue employer address
	Then the national provider capability page should be delivered
@CI
Scenario: No Option selected
	Given I have accessed the apprenticeship delivery screen
	And I have not selected an option
	When I press continue error
	Then an apprenticeships error message should be displayed "Select Where will this apprenticeship training be delivered?"

#@CI - Story not yet ready(353)
#Scenario: Select Both
#	Given I have accessed the apprenticeship delivery screen
#	And I have selected both as delivery type
#	When I press continue
#	Then the Apprenticeships combined delivery options screen is displayed