Feature: DFC-5624 Add Venue - Commit Add Venue Record

As a user
I need to commit the add venue record
so that the new venue record is committed to the CD database

Background:
	Given I have logged into course directory as a provider
	## Use Provider Search to Navigate o course for a Provider
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Your Venues Pages
	When I click Add Venue
	Then I am on the Add Venue page
	And the Add Venue page displays the expected content
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road Birmingham, B13 9DA
	And I enter venue name Academy Of Contemporary Music
	And I click continue to confirm page


@CI
Scenario: User Confirms Details
	When I am on the Add Venue Confirm details page
	And On the Confirmation Page I click continue
	Then I am on the View All Live Venues Page
	And System displays banner message
	And System displays new Venue added Academy Of Contemporary Music
	