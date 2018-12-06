Feature: DFC-5463 Add Venue - Confirm Details

As a user
I want to confirm the venue details that I have added
so that I can amend the details or confirm that the venue details are correct

Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Your Venues Pages
	When I click Add Venue
	Then I am on the Add Venue page
	And the page displays the expected content
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page
	When I select the first address returned
	And I enter venue name Test Venue
	And I click continue


@CI
Scenario: User is on Add Venue Confirm Address Page
	When I am on the Add Venue Confirm details page
	Then the Add venue confirm details page displays the expected content

