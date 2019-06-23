Feature: COUR-626 Select National Provider Capability
	As a user
	I need to select if I can deliver the apprenticeship training at employers locations anywhere is England
	so that the correct information is added to the CD system

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
	Given I have selected employers address as delivery type
	When I press continue employer address
	Then the national provider capability page should be delivered

@CI
Scenario: COUR-626 Select Nothing for national provider
	When I press continue on the National provider capability page
	Then the error message should be displayed Select Can you deliver this training at employer’s locations anywhere in England?

@CI
Scenario: COUR-626 Select Yes for national provider
	When i  select yes to National provider
	When I press continue on the National provider capability page yes
	Then I am on the confirm details page


@CI
Scenario: COUR-626 Select No for national provider
	When i  select no to National provider
	When I press continue on the National provider capability page no
	Then I am on the employer based delivery page