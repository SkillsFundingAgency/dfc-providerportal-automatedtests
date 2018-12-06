Feature: DFC-5486 Add Venue - Edit Venue Address
	In order to alter a provisionally entered address 
	As a provider user when Adding a Venue
	I want to be able to edit Venue Address

#all tests start at Add Venue address screen 

@add_venue
Scenario: Change address manually during Add Venue
	Given I have entered an address
	And I am on the address screen
	When I press edit address
	Then I am taken to the change address screen
	And I can change the address manually
	And my new address is shown on address screen
#-- reuse steps to confirm and check new venue


@add_venue
Scenario: Change address using postcode during Add Venue
	Given I have entered an address
	And I am on the address screen
	When I press edit address
	Then I am taken to the change address screen
#--look into using postcode look-up steps
	And my new address is shown on address screen
#-- reuse steps to confirm and check new venue