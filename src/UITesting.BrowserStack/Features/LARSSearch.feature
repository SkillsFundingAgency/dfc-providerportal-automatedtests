Feature: LARS Search

@BrowserStack
Scenario Outline: Search for LARS
	Given I have navigated to the landing page for <profile> and <environment>
	When I do a LARS Search for Biology
	Then I should see title Biology
	
	Examples:
		| profile  | environment |
		| parallel | chrome      |
		| parallel | macchrome   |
		| parallel | firefox     |
		| parallel | safari      |
		| parallel | macfirefox  |
		| parallel | ie8         |
		| parallel | ie9         |
		| parallel | ie10        |
		| parallel | ie11        |
		| parallel | edge        |
		| parallel | ipad        |
		| parallel | iphone      |
		| parallel | android     |


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
	
