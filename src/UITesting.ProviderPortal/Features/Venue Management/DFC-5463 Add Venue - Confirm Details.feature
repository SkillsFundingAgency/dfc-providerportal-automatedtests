Feature: DFC-5463 Add Venue - Confirm Details

As a user
I want to confirm the venue details that I have added
so that I can amend the details or confirm that the venue details are correct

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
	And I enter venue name Test Venue
	And I click continue to confirm page


@CI
Scenario: User is on Add Venue Confirm Address Page
	When I am on the Add Venue Confirm details page
	Then the Add venue confirm details page displays the expected content

