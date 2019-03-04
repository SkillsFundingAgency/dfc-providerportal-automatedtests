Feature: Search Provider
	In order to view provider details
	As a provider
	I want to be able to search for providers


@BrowserStack
Scenario Outline: Search a Provider
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps

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
	   #| parallel | ie10win7       | # not supported
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
