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
	Then Address validation message is displayed Enter a full and valid postcode

# START OF INVALID POSTCODES

@CI
Scenario: User enters invalid postcode to Find Address 
	When I enter the following postcode hello
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode


# The letters Q, V and X are not used in the first position

@CI
Scenario: User enters invalid postcode to Find Address QA14 7EN
	When I enter the following postcode QA14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address VA14 7EN
	When I enter the following postcode VA14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address XA14 7EN
	When I enter the following postcode XA14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode


# The letters I, J and Z are not used in the second position.

@CI
Scenario: User enters invalid postcode to Find Address BI14 7EN
	When I enter the following postcode BI14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address BJ14 7EN
	When I enter the following postcode BJ14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address BZ14 7EN
	When I enter the following postcode BZ14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode


# The only letters to appear in the third position are A, B, C, D, E, F, G, H, J, K, S, T, U and W.

@CI
Scenario: User enters invalid postcode to Find Address EC1I 1BB
	When I enter the following postcode EC1I 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1L 1BB
	When I enter the following postcode EC1L 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1M 1BB
	When I enter the following postcode EC1M 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1N 1BB
	When I enter the following postcode EC1N 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1O 1BB
	When I enter the following postcode EC1O 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1P 1BB
	When I enter the following postcode EC1P 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1Q 1BB
	When I enter the following postcode EC1Q 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1R 1BB
	When I enter the following postcode EC1R 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1V 1BB
	When I enter the following postcode EC1V 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1X 1BB
	When I enter the following postcode EC1X 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address EC1Y 1BB
	When I enter the following postcode EC1Y 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode


###  The second half of the postcode is always consistent numeric, alpha, alpha format and the letters C, I, K, M, O and V are never used

@CI
Scenario: User enters invalid postcode to Find Address B14 7CN
	When I enter the following postcode B14 7CN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode


@CI
Scenario: User enters invalid postcode to Find Address B14 7IN
	When I enter the following postcode B14 7IN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7KN
	When I enter the following postcode B14 7KN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7MN
	When I enter the following postcode B14 7MN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7ON
	When I enter the following postcode B14 7ON
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7VN
	When I enter the following postcode B14 7VN
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7EC
	When I enter the following postcode B14 7EC
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7EI
	When I enter the following postcode B14 7EI
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7EK
	When I enter the following postcode B14 7EK
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7EM
	When I enter the following postcode B14 7EM
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode

@CI
Scenario: User enters invalid postcode to Find Address B14 7EO
	When I enter the following postcode B14 7EO
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode


@CI
Scenario: User enters invalid postcode to Find Address B14 7EV
	When I enter the following postcode B14 7EV
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode


@CI
Scenario: User enters invalid postcode to Find Address B14 E77
	When I enter the following postcode B14 E77
	And I click Find Address
	Then Address validation message is displayed Enter a full and valid postcode


# END OF INVALID  POSTCODE TESTS

@CI
Scenario: User enters valid not found postcode to Find Address
	When I enter the following postcode b13 9cc
	And I click Find Address
	Then Address validation message is displayed Postcode is not found

@CI
Scenario: User enters valid postcode to Find Address
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: User enters valid postcode to Find Address M1 1AA
	When I enter the following postcode M1 1AA
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: User enters valid postcode to Find Address M60 1NW
	When I enter the following postcode M60 1NW
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: User enters valid postcode to Find Address CR2 6XH
	When I enter the following postcode CR2 6XH
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: User enters valid postcode to Find Address DN55 1PT
	When I enter the following postcode DN55 1PT
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: User enters valid postcode to Find Address W1A 1HQ
	When I enter the following postcode W1A 1HQ
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: User enters valid postcode to Find Address EC1A 1BB
	When I enter the following postcode EC1A 1BB
	And I click Find Address
	Then I am on the Select Address page



@CI
Scenario: User clicks continue without selecting from list of addresses
	When I enter the following postcode b14 7en
	And I click Find Address
	Then I am on the Select Address page
	When I click continue
	Then Select Address validation message is displayed select address

@CI
Scenario: User selects address and does not enter venue name then clicks continue
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road Birmingham, B13 9DA
	And I click continue
	Then Venue Name validation message is displayed enter venue name

@CI
Scenario: User selects address and enters space in venue name then clicks continue
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road Birmingham, B13 9DA
	And I enter venue name space
	And I click continue
	Then Venue Name validation message is displayed enter venue name

@CI
Scenario: User selects address and enter invalid venue name then clicks continue
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road Birmingham, B13 9DA
	And I enter venue name ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV
	And I click continue
	Then Venue Name validation message is displayed enter venue name

@CI
Scenario: User selects address and enters valid venue name then clicks continue
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road Birmingham, B13 9DA
	And I enter venue name Test Venue
	And I click continue
	Then I am on the Add Venue Confirm details page

@CI
Scenario: User selects Change on add venue select address page
	When I enter the following postcode b17 7en
	And I click Find Address
	Then I am on the Select Address page
	When I Click Change
	Then I am on the Add Venue page

