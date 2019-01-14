Feature: Add Venue

As a user
I need to commit the add venue record
so that the new venue record is committed to the CD database

@BrowserStack
Scenario Outline: Add Venue Details
	Given I have navigated to the Venues page using <profile> and <environment>
	And I have navigated to the Your Venues Pages
	When I enter 10043577 and click search
	When I click Add Venue
	Then I am on the Add Venue page
	And the Add Venue page displays the expected content
	When I enter the following postcode b13 9da
	And I click Find Address
	Then I am on the Select Address page
	When I select the address 120 Sandford Road Birmingham, B13 9DA
	And I enter venue name Test Venue
	And I click continue to confirm page
	When I am on the Add Venue Confirm details page
	And On the Confirmation Page I click continue

	Examples:
		| profile  | environment    |
		| parallel | chrome70win10  |
		| parallel | chrome69win10  |
		| parallel | chrome62win10  |
		| parallel | chrome63win10  |
		| parallel | chrome70win81  |
		| parallel | chrome69win81  |
		| parallel | chrome70win8   |
		| parallel | chrome69win8   |
		| parallel | chrome70win7   |
		| parallel | chrome70win7   |
		| parallel | chrome70macos  |
		| parallel | chrome69macos  |
		| parallel | firefox63win10 |
		| parallel | firefox62win10 |
		| parallel | firefox63win81 |
		| parallel | firefox62win81 |
		| parallel | firefox63win7  |
		| parallel | firefox62win7  |
		| parallel | firefox63osx   |
		| parallel | firefox62osx   |
		| parallel | ie11win10      |
		| parallel | ie11win81      |
		| parallel | ie11win7       |
		| parallel | ie10win7       |
	   #| parallel | ie9win7        | # not supported
	   #| parallel | ie8win7        | # not supported
		| parallel | edge17win10    |
		| parallel | edge16win10    |
		| parallel | safari12macos  |
		#| parallel | safari11macos  | # safari webtoolkit needs to be applied
		#| parallel | safari10macos  | # safari webtoolkit needs to be applied
		#| parallel | safari9macos   | # safari webtoolkit needs to be applied
		#| parallel | ipad           | # real devices
		#| parallel | iphone         | # real devices
		#| parallel | android        | # real devices

