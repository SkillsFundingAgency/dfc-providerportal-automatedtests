Feature: COUR-353 Classroom and Employer Based Delivery Options
As a user
I need to add the details for a Classroom and Employer based delivery method (i.e. both) for a new apprenticeshipso 
So that these details are held within the course directory

Background: 
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10044200" and clicked search
	When I click to view my courses
	Given I have accessed the Apprenticeship Search page
	When I use apprenticeship search to search for Plumbing
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
	Given I have selected both as delivery type
	When I press continue both
	Then the classroom and employer based delivery page should be delivered

@CI
Scenario: COUR-353 Select Day Release location and choose to add another
	When I select Day Release option
	And I select a location
	And I enter 10 miles in radius field
	And I click Add another

@CI
Scenario: COUR-353 Select Day Release location and add another second time
	When I select Day Release option
	And I select a location
	And I enter 10 miles in radius field
	And I click Add another
	When I select Day Release option
	And I select a location
	And I enter 10 miles in radius field
	And I click Add another

# Test takes too long to run as part of CI
#@CI
#Scenario: Add 250 locations
#	When I add 250 locations for an apprenticeship