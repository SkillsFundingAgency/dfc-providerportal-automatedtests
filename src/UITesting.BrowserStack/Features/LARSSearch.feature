Feature: LARS Search


@BrowserStack
Scenario Outline: Search for LARS
	Given I have navigated to the landing page for <profile> and <environment>
	When I do a LARS Search for Biology
	Then I should see title Biology
	
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
		| parallel | ie9win7        |
		| parallel | ie8win7        |
		| parallel | edge17win10    |
		| parallel | edge16win10    |
		| parallel | safari12macos  |
		| parallel | safari11macos  |
		| parallel | safari10macos  |
		| parallel | safari9macos   |
		| parallel | ipad           |
		| parallel | iphone         |
		| parallel | android        |


@Regression
Scenario: Search for LARS Regression
	Given I have navigated to the landing page
	When I do a LARS Search for Biology
	Then I should see title Biology


@Regression
Scenario: Search for LARS Regression2
	Given I have navigated to the landing page
	When I do a LARS Search for Biology
	Then I should see title Biology


@Regression
Scenario: User navigate to DFE home page
	Given I navigate to GOV.UK home page
	When I search for Department for Education
	And I click on DFE link
	Then I should be on Department for Education home page	

