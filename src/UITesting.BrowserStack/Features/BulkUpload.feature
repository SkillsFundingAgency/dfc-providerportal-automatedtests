Feature: Bulk Upload
	In order to update my Courses
	As a provider
	I want to be able to be able to use the Bulk Upload functionality


@BrowserStack
Scenario Outline: Bulk Upload Status of upload Courses
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10037355" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_AttendancePatternNone.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page

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
