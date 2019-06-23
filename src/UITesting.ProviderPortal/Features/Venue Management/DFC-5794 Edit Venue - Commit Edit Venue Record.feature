Feature: DFC-5794 Edit Venue - Commit Edit Venue Record
	As a user
	I need to commit the edit venue record
	so that the edit venue record is committed to the CD database

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have navigated to the Your Venues Pages
	When I click Edit against the first venue
	Then I am on the Edit venue details page


@CI
Scenario: DFC-5794 Commit Edited Venue Name and Address
	When I click Change Name on Edit Venue page
	Then I am on Edit Venue name page
	When I edit the venue name to New Venue Name
	And I click continue on edit venue name page
	Then I am on the Edit venue details page
	When I click Change Address on Edit Venue page
	Then I am on Edit Venue Address page
	When I edit the venue address to b14 7rz
	And I chose the following address 8 York Road
	And I click continue on edit venue address page
	Then I am on the Edit venue details page
	When I click continue on the Edit venue details page
	Then I am on the View All Live Venues Page
	And System displays banner message
	And System displays new Venue added New Venue Name

@CI
Scenario: DFC-5794 Commit Edited Venue Name
	When I click Change Name on Edit Venue page
	Then I am on Edit Venue name page
	When I edit the venue name to New Venue Name
	And I click continue on edit venue name page
	Then I am on the Edit venue details page
	When I click continue on the Edit venue details page
	Then I am on the View All Live Venues Page
	And System displays banner message
	And System displays new Venue added New Venue Name

@CI
Scenario: DFC-5794 Commit Edited Venue Address
	When I click Change Address on Edit Venue page
	Then I am on Edit Venue Address page
	When I edit the venue address to b14 7rz
	And I chose the following address 8 York Road
	And I click continue on edit venue address page
	Then I am on the Edit venue details page
	When I click continue on the Edit venue details page
	Then I am on the View All Live Venues Page
	And System displays banner message