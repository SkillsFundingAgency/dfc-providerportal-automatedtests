Feature: COUR-599 Publish an Apprenticeship
As a user
I need to action a publish and receive confirmation that my new apprenticeship training offer has been published to the course directory
so that I know that I have completed the add process

@CI
Scenario: COUR-599 Publish a Classroom and Employer based Apprenticeship
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
	When I select Day Release option
	And I select a location
	And I enter 10 miles in radius field
	And I click Add another
	When I select Day Release option
	And I select a location
	And I enter 10 miles in radius field
	And I click Save and Continue
	Then I am on the confirm details page
	When I click publish apprenticeship
	Then I am on apprenticeship published page

@CI
Scenario: COUR-599 Publish an Employer based Apprenticeship
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
	When i  select no to National provider
	When I press continue on the National provider capability page no
	Then I am on the employer based delivery page
	When I expand the East Midlands region
	And I select the first sub-region
	And I click Continue on Add employer based delivery
	Then I am on the confirm details page
	When I click publish apprenticeship
	Then I am on apprenticeship published page

@CI
Scenario: COUR-599 Publish a Classroom based Apprenticeship
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
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
	Given I have accessed the apprenticeship delivery screen
	And I have selected locations as delivery type
	When I press continue location
	Then the Apprenticeships delivery options screen is displayed
	Given I have selected a venue from the Location dropdown
	And I have selected Day release as delivery mode
	When I click SaveandContinue
	Then the Apprenticeship Summary Screen should be displayed
	When I click publish apprenticeship
	Then I am on apprenticeship published page