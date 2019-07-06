Feature: DFC-4759 Add Venue - Find Address via Postcode and Select Address

As a User
I need to find an address via postcode lookup and select this address
so that I can use the address to create a new venue in the course directory

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

@CI
Scenario: DFC-4759 User Does Not enter postcode to Find Address
	When I click Find Address
	Then Address validation message is displayed Enter a postcode

# START OF INVALID POSTCODES
@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address 
	When I enter the following postcode hello
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode


# The letters Q, V and X are not used in the first position
@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address QA14 7EN
	When I enter the following postcode QA14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address VA14 7EN
	When I enter the following postcode VA14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address XA14 7EN
	When I enter the following postcode XA14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode


# The letters I, J and Z are not used in the second position.
@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address BI14 7EN
	When I enter the following postcode BI14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address BJ14 7EN
	When I enter the following postcode BJ14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address BZ14 7EN
	When I enter the following postcode BZ14 7EN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode


# The only letters to appear in the third position are A, B, C, D, E, F, G, H, J, K, S, T, U and W.
@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address W1I 1HQ
	When I enter the following postcode W1I 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 DFC-4759 User enters invalid postcode to Find Address W1L 1HQ
	When I enter the following postcode W1L 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1M 1HQ
	When I enter the following postcode W1M 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1N 1HQ
	When I enter the following postcode W1N 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1O 1HQ
	When I enter the following postcode W1O 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1P 1HQ 
	When I enter the following postcode W1P 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1Q 1HQ
	When I enter the following postcode W1Q 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1R 1HQ
	When I enter the following postcode W1R 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1V 1HQ
	When I enter the following postcode W1V 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1X 1HQ
	When I enter the following postcode W1X 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address W1Y 1HQ
	When I enter the following postcode W1Y 1HQ
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode


# The only letters to appear in the fourth position are A, B, E, H, M, N, P, R, V, W, X, Y.
@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1C 1BB
	When I enter the following postcode EC1C 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1D 1BB
	When I enter the following postcode EC1D 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1F 1BB
	When I enter the following postcode EC1F 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1G 1BB
	When I enter the following postcode EC1G 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1I 1BB
	When I enter the following postcode EC1I 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1J 1BB
	When I enter the following postcode EC1J 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1K 1BB
	When I enter the following postcode EC1K 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1L 1BB
	When I enter the following postcode EC1L 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1O 1BB
	When I enter the following postcode EC1O 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1Q 1BB
	When I enter the following postcode EC1Q 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1S 1BB
	When I enter the following postcode EC1S 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1T 1BB
	When I enter the following postcode EC1T 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1U 1BB
	When I enter the following postcode EC1U 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address EC1Z 1BB
	When I enter the following postcode EC1Z 1BB
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode


###  The second half of the postcode is always consistent numeric, alpha, alpha format and the letters C, I, K, M, O and V are never used
@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7CN
	When I enter the following postcode B14 7CN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7IN
	When I enter the following postcode B14 7IN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7KN
	When I enter the following postcode B14 7KN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7MN
	When I enter the following postcode B14 7mN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7ON
	When I enter the following postcode B14 7ON
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7VN
	When I enter the following postcode B14 7VN
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7EC
	When I enter the following postcode B14 7EC
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7EI
	When I enter the following postcode B14 7EI
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7EK
	When I enter the following postcode B14 7EK
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7EM
	When I enter the following postcode B14 7em
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7EO
	When I enter the following postcode B14 7EO
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 7EV
	When I enter the following postcode B14 7EV
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters invalid postcode to Find Address B14 E77
	When I enter the following postcode B14 E77
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

# END OF INVALID  POSTCODE TESTS

@CI
Scenario: DFC-4759 User enters valid not found postcode to Find Address
	When I enter the following postcode b13 9zy
	And I click Find Address
	Then Address validation message is displayed Enter a real postcode

@CI
Scenario: DFC-4759 User enters valid postcode to Find Address
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: DFC-4759 User enters valid postcode to Find Address M1 1AA
	When I enter the following postcode M1 1AA
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: DFC-4759 User enters valid postcode to Find Address M60 1NW
	When I enter the following postcode M60 1NW
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: DFC-4759 User enters valid postcode to Find Address CR2 6XH
	When I enter the following postcode CR2 6XH
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: DFC-4759 User enters valid postcode to Find Address DN55 1PT
	When I enter the following postcode DN55 1PT
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: DFC-4759 User enters valid postcode to Find Address W1A 1HQ
	When I enter the following postcode W1A 1HQ
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: DFC-4759 User enters valid postcode to Find Address EC1A 1BB
	When I enter the following postcode EC1A 1BB
	And I click Find Address
	Then I am on the Select Address page

@CI
Scenario: DFC-4759 User clicks continue without selecting from list of addresses
	When I enter the following postcode b14 7en
	And I click Find Address
	Then I am on the Select Address page
	When I click continue
	Then Select Address validation message is displayed Select an address

@CI
Scenario: DFC-4759 User selects address and does not enter venue name then clicks continue
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road
	And I click continue
	Then Venue Name validation message is displayed Enter a venue name

@CI
Scenario: DFC-4759 User selects address and enters space in venue name then clicks continue
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road
	And I enter venue name space
	And I click continue
	Then Venue Name validation message is displayed Venue name must not have any leading, trailing or contain multiple consecutive spaces

@CI
Scenario: DFC-4759 User selects address and enter invalid venue name then clicks continue
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road
	And I enter venue name ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV
	And I click continue
	Then Venue Name validation message is displayed Venue name must be 255 characters or less

@CI
Scenario: DFC-4759 User selects address and enters valid venue name then clicks continue
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road
	And I enter variable venue nameTest Venue
	And I click continue to confirm page
	Then I am on the Add Venue Confirm details page

@CI
Scenario: DFC-4759 User selects Change on add venue select address page
	When I enter the following postcode b14 7en
	And I click Find Address
	Then I am on the Select Address page
	When I Click Change
	Then I am on the Add Venue page