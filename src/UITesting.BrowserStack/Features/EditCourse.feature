Feature: Edit Course

	In order to be able to change the course details
	As a Provider
	I want to be able to change the course name

@BrowserStack
Scenario Outline:Edit Course Run Details
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have clicked the Main Qualification
	And I have clicked one of the courses available
	Then I should be able to view the course runs.	
	Given I have selected a course run to update
	And I have changed the course name to "Updated Course Name"
	When I Click Save
	
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


@BrowserStack
Scenario Outline:Edit Course Details
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	And I select Edit Course Description
	Then Edit Course screen should be displayed
	Given I have edited course description with valid values "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJ" 
	When I Click the Save button

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