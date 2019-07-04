Feature: COUR-388 Add Employer Based Delivery Method
	As a user
	I need to add the details for an Employer based delivery method for a new apprenticeship
	so that these details are held within the course directory

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
	When i  select no to National provider
	When I press continue on the National provider capability page no
	Then I am on the employer based delivery page

@CI
Scenario: COUR-388 Select EastMidlands regions and the first sub-region
	When I expand the East Midlands region
	And I select the first sub-region
	And I click Continue on Add employer based delivery
	Then I am on the confirm details page

@CI
Scenario: COUR-388 Select EastMidlands regions and select All sub-regions
	When I expand the East Midlands region
	And I select the all sub-regions
	And I click Continue on Add employer based delivery
	Then I am on the confirm details page

@CI
Scenario: COUR-388 Select All regions and the first sub-region for each
	When I expand the Yorkshire region
	And I select the first sub-region
	Then I close the Yorkshire region
	#
	When I expand the East Midlands region
	And I select the first sub-region
	Then I close the East Midlands region
	#
	When I expand the East of England region
	And I select the first sub-region
	Then I close the East of England region
	#
	When I expand the London region
	And I select the first sub-region
	Then I close the London region
	#
	When I expand the North West region
	And I select the first sub-region
	Then I close the North West region
	#
	When I expand the North East region
	And I select the first sub-region
	Then I close the North East region
	#
	When I expand the South West region
	And I select the first sub-region
	Then I close the South West region
	#
	When I expand the South East region
	And I select the first sub-region
	Then I close the South East region
	#
	When I expand the West Midlands region
	And I select the first sub-region
	Then I close the West Midlands region
	#
	When I click Continue on Add employer based delivery
	Then I am on the confirm details page

@CI
Scenario: COUR-388 Select All regions and select All sub-regions
	When I expand the East Midlands region
	And I select the all sub-regions
	Then I close the East Midlands region
	#
	When I expand the East of England region
	And I select the all sub-regions
	Then I close the East of England region
	#
	When I expand the London region
	And I select the all sub-regions
	Then I close the London region
	#
	When I expand the North West region
	And I select the all sub-regions
	Then I close the North West region
	#
	When I expand the North East region
	And I select the all sub-regions
	Then I close the North East region
	#
	When I expand the South West region
	And I select the all sub-regions
	Then I close the South West region
	#
	When I expand the South East region
	And I select the all sub-regions
	Then I close the South East region
	#
	When I expand the West Midlands region
	And I select the all sub-regions
	Then I close the West Midlands region
	#
	When I expand the Yorkshire region
	And I select the all sub-regions
	Then I close the Yorkshire region
	#
	When I click Continue on Add employer based delivery
	Then I am on the confirm details page