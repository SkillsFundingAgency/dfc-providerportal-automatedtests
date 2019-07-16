Feature: COUR-387 AddClassromDeliveryMethodForApprenticeship
	In order to add a new apprenticehship delivery
	As a provider
	I want to be able to select classroom delivery as an option

Background: 
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
@CI
Scenario: COUR-387 Select a location and Day Release and click SaveandContinue
	Given I have selected a venue from the Location dropdown
	And I have selected Day release as delivery mode
	When I click SaveandContinue
	Then the Apprenticeship Summary Screen should be displayed
@CI
Scenario: COUR-387 Select a location and Block Release and click SaveandContinue
	Given I have selected a venue from the Location dropdown
	And I have selected Block release as delivery mode
	When I click SaveandContinue
	Then the Apprenticeship Summary Screen should be displayed
@CI
Scenario: COUR-387 Select a location and select both Day and Block Release and click SaveandContinue
	Given I have selected a venue from the Location dropdown
	And I have selected Day Release and Block release as delivery mode
	When I click SaveandContinue
	Then the Apprenticeship Summary Screen should be displayed
@CI
Scenario: COUR-387 Select a location and Day Release and click SaveandAddAnother
	Given I have selected a venue from the Location dropdown
	And I have selected Day release as delivery mode
	When I click SaveandAddAnother
	Then the Apprenticeship delivery Screen should be displayed
@CI
Scenario: COUR-387 Select a location and Block Release and click SaveandAddAnother
	Given I have selected a venue from the Location dropdown
	And I have selected Block release as delivery mode
	When I click SaveandAddAnother
	Then the Apprenticeship delivery Screen should be displayed
@CI
Scenario: COUR-387 Select a location and select both Day and Block Release and click SaveandAddAnother
	Given I have selected a venue from the Location dropdown
	And I have selected Day Release and Block release as delivery mode
	When I click SaveandAddAnother
	Then the Apprenticeship delivery Screen should be displayed
@CI
Scenario: COUR-387 Select a location and select multiple locations
	Given I have selected a venue from the Location dropdown
	And I have selected Day release as delivery mode
	When I click SaveandAddAnother
	Then the Apprenticeship delivery Screen should be displayed
	Given I have selected a venue from the Location dropdown
	And I have selected Block release as delivery mode
	When I click SaveandContinue
	Then the Apprenticeship Summary Screen should be displayed
@CI
Scenario: COUR-387 Display Error Message-Location
	Given I have not selected a venue 
	And I have selected Block release as delivery mode
	When I click SaveandAddAnother
	Then Location error message should be displayed "Select location"
@CI
Scenario: COUR-387 Display Error Message-Delivery Mode
	Given I have selected a venue from the Location dropdown
	When I click SaveandContinue
	Then Delivery Mode error message should be displayed "Select how is the training delivered at this location"
@CI
Scenario: COUR-387 Display Error Message-Location/Delivery Mode/SaveandAddAnother 
	Given I have not selected a venue 
	When I click SaveandAddAnother
	Then Location error message should be displayed "Select location"
	Then Delivery Mode error message should be displayed "Select how is the training delivered at this location"
@CI
Scenario: COUR-387 Display Error Message-Location/Delivery Mode/SaveandContinue 
	Given I have not selected a venue 
	When I click SaveandContinue
	Then Location error message should be displayed "Select location"
	Then Delivery Mode error message should be displayed "Select how is the training delivered at this location"
