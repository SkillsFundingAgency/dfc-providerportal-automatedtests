Feature: DFC-4759 Add Venue - Find Address via Postcode and Select Address

As a User
I need to find an address via postcode lookup and select this address
so that I can use the address to create a new venue in the course directory

Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Your Venues Pages
	When I click Add Venue
	Then I am on the Add Venue page
	And the Add Venue page displays the expected content

@CI
Scenario: User Does Not enter postcode to Find Address
	When I click Find Address
	Then A validation message is displayed postcode must be entered

@CI
Scenario: User enters invalid postcode to Find Address
	When I enter the following postcode hello
	And I click Find Address
	Then A validation message is displayed postcode is invalid

@CI
Scenario: User enters valid not found postcode to Find Address
	When I enter the following postcode b17 7en
	And I click Find Address
	Then A validation message is displayed postcode is not found

@CI
Scenario: User enters valid postcode to Find Address
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: User clicks continue without selecting from list of addresses
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page
	When I click continue
	Then A validation message is displayed select address

@CI
Scenario: User selects address and does not enter venue name then clicks continue
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page
	When I select the first address returned
	And I click continue
	Then A validation message is displayed enter venue name

@CI
Scenario: User selects address and enters space in venue name then clicks continue
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page
	When I select the first address returned
	And I enter venue name Test Venue
	And I click continue
	Then A validation message is displayed enter valid venue name

@CI
Scenario: User selects address and enter invalid venue name then clicks continue
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page
	When I select the first address returned
	And I enter venue name ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV
	And I click continue
	Then A validation message is displayed enter valid venue name

@CI
Scenario: User selects address and enters valid venue name then clicks continue
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page
	When I select the first address returned
	And I enter venue name Test Venue
	And I click continue
	Then I am on the Add Venue Confirm details page

@CI
Scenario: User selects Change on add venue slect address page
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page
	When I Click Change
	Then I am on the Add Venue page

