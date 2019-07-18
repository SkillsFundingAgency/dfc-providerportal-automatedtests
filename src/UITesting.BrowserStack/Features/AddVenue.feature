Feature: Add Venue

As a user
I need to commit the add venue record
so that the new venue record is committed to the CD database


@BrowserStack
Scenario Outline: Add Venue Details
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
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
	And I enter venue name Test Venue
	And I click continue to confirm page
	When I am on the Add Venue Confirm details page
	And On the Confirmation Page I click continue

	Examples:
		| profile  | environment    |
		| parallel | chrome74win10  |
		| parallel | chrome73win10  |
		| parallel | chrome72win10  |
		| parallel | chrome70win10  |
		| parallel | chrome74win81  |
		| parallel | chrome73win81  |
		| parallel | chrome74win8   |
		| parallel | chrome73win8   |
		| parallel | chrome74win7   |
		| parallel | chrome73win7   |
		| parallel | chrome74macos  |
		| parallel | chrome73macos  |
		| parallel | firefox66win10 |
		| parallel | firefox65win10 |
		| parallel | firefox66win81 |
		| parallel | firefox65win81 |
		| parallel | firefox66win7  |
		| parallel | firefox65win7  |
		| parallel | firefox66osx   |
		| parallel | firefox65osx   |
		| parallel | ie11win10      |
		| parallel | ie11win81      |
		| parallel | ie11win7       |
	   #| parallel | ie10win7       | # not supported
	   #| parallel | ie9win7        | # not supported
	   #| parallel | ie8win7        | # not supported
		| parallel | edge18win10    |
		| parallel | edge17win10    |
		| parallel | edge16win10    |
		| parallel | safari12macos  |
	   #| parallel | safari11macos  | # safari webtoolkit needs to be applied
	   #| parallel | safari10macos  | # safari webtoolkit needs to be applied
	   #| parallel | safari9macos   | # safari webtoolkit needs to be applied
		#| parallel | ipad           | # real devices
		#| parallel | iphone         | # real devices
		#| parallel | android        | # real devices