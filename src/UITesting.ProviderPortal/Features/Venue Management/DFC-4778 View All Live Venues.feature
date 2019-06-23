Feature: DFC-4778 View Live Venues
	In order to look at all venues
	As a provider
	I want to be able to list all my venues

@CI
Scenario: View Live Venues
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Venues Pages
	Then links to Edit and Archive should be visible
	And Add Venue Button should be visible


@CI
Scenario: DFC-4778 Delete Venue - add venue to be deleted
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Your Venues Pages
	When I click Add Venue
	Then I am on the Add Venue page
	And the Add Venue page displays the expected content
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road
	And I enter venue name x venue 99
	And I click continue to confirm page

@CI
Scenario: DFC-4778 Delete Venue - delete venue
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Your Venues Pages
	Then Add Venue Button should be visible
	When I delete the following venue x venue 99