Feature: DFC-5463 Add Venue - Confirm Details

As a user
I want to confirm the venue details that I have added
so that I can amend the details or confirm that the venue details are correct

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10040838" and clicked search
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
	And I enter variable venue nameTest Venue
	And I click continue to confirm page


@CI
Scenario: DFC-5463 User is on Add Venue Confirm Address Page
	When I am on the Add Venue Confirm details page
	Then the Add venue confirm details page displays the expected content

