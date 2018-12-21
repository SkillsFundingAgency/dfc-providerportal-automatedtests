﻿Feature: DFC-5488 Edit Venue - Edit Venue Name
	As a user
	I need to edit the venue name
	so that I can use the venue name is up to date

Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Your Venues Pages
	When I enter 10028015 and click search
	When I click Edit against the first venue
	Then I am on the Edit venue details page

@CI
Scenario: Edit Venue Name
	When I click Change Name on Edit Venue page
	Then I am on Edit Venue name page
	When I edit the venue name to New Venue Name
	And I click continue on edit venue name page
	Then I am on the Edit venue details page