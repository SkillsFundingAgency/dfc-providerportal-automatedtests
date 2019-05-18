Feature: Data Quality Indicator
	In order to maintain my Courses
	As a provider
	I want to be able to view course with Data Quality Issues


@BrowserStack
Scenario Outline: Bulk Upload Status of upload Courses
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as provider admin with Provider.10033145@gmail.com and SITtesting123
	Then I am logged in as a provider
	Given I click on the courses need their start date updated link
	Then I am taken to the DQI page
	When I click on the first course run requiring start date update
	Then I am take to Edit Course page
	When I update the start date
	And I click cancel DQI Edit
	Then I am taken to the DQI page

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
		| parallel | edge18win10    |
		| parallel | edge17win10    |
		| parallel | edge16win10    |
		| parallel | safari12macos  |
