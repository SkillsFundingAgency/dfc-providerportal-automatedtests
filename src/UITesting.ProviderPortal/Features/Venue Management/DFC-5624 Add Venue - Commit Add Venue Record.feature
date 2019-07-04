Feature: DFC-5624 Add Venue - Commit Add Venue Record

As a user
I need to commit the add venue record
so that the new venue record is committed to the CD database

Background:
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
	And I enter variable venue nameAcademy Of Contemporary Music
	And I click continue to confirm page


@CI
Scenario: DFC-5624 User Confirms Details
	When I am on the Add Venue Confirm details page
	And On the Confirmation Page I click continue
	Then I am on the View All Live Venues Page
	And System displays banner message
	And System displays new Venue added Academy Of Contemporary Music
	