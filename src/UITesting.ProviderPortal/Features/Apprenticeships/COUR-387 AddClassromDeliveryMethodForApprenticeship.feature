﻿Feature: COUR-387 AddClassromDeliveryMethodForApprenticeship
	In order to add a new apprenticehship delivery
	As a provider
	I want to be able to select classroom delivery as an option

Background: 
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
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
	Given I have accessed the apprenticeship delivery screen
	And I have selected locations as delivery type
	When I press continue location
	Then the Apprenticeships delivery options screen is displayed
@CI
Scenario: Select a location and Day Release and click SaveAddAnother
	Given I have selected a venue from the Location dropdown
	And I have selected Day release as delivery mode
	When I click continue
	Then the result should be 120 on the screen