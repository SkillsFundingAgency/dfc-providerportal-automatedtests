Feature: DFC-5794 Edit Venue - Commit Edit Venue Record
	As a user
	I need to commit the edit venue record
	so that the edit venue record is committed to the CD database

Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Your Venues Pages
	When I enter 10028015 and click search
	When I click Edit against the first venue
	Then I am on the Edit venue details page


@CI
Scenario: Commit Edited Venue Name and Address
	When I click Change Name on Edit Venue page
	Then I am on Edit Venue name page
	When I edit the venue name to New Venue Name
	And I click continue on edit venue name page
	Then I am on the Edit venue details page
	When I click Change Address on Edit Venue page
	Then I am on Edit Venue Address page
	When I edit the venue address to b14 7rz
	And I chose the following address 8 York Road Kings Heath, Birmingham, B14 7RZ
	And I click continue on edit venue address page
	Then I am on the Edit venue details page
	When I click continue on the Edit venue details page
	Then I am on the View All Live Venues Page
	And System displays banner message
	And System displays new Venue added New Venue Name

@CI
Scenario: Commit Edited Venue Name
	When I click Change Name on Edit Venue page
	Then I am on Edit Venue name page
	When I edit the venue name to New Venue Name Two
	And I click continue on edit venue name page
	Then I am on the Edit venue details page
	When I click continue on the Edit venue details page
	Then I am on the View All Live Venues Page
	And System displays banner message
	And System displays new Venue added New Venue Name Two

@CI
Scenario: Commit Edited Venue Address
	When I click Change Address on Edit Venue page
	Then I am on Edit Venue Address page
	When I edit the venue address to b14 7rz
	And I chose the following address 8 York Road Kings Heath, Birmingham, B14 7RZ
	And I click continue on edit venue address page
	Then I am on the Edit venue details page
	When I click continue on the Edit venue details page
	Then I am on the View All Live Venues Page
	And System displays banner message