Feature: Search Qualification
	In order to Search a Qualification
	As a provider
	I want to be able to search for a Qualification using LARS/QAN Reference Number 

@BrowserStack
Scenario Outline: Search a Qualification
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have accessed the Qualifications page	
	And there is a field to enter the LARS/QAN number.
	And I have entered LARS/QAN Number "60060955"
	Then I want to see the Qualifications listed for that LARS/QAN Number
	And I want to see LARS/QAN number "LARS/QAN", Level "Level" and awarding body "Awarding body" for each qualification
	And I want to see a Link to add this qualification.
	And I want to see Qualification Level Filter "Qualification Level"
	And I want to see Awarding Organisation Filter on the screen "Awarding Organisation"
	Given I have selected filters in Qualification Level and/or Awarding body

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
Scenario Outline: Clear filters when reset is clicked
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have accessed the Qualifications page	
	Given I have entered a Qualification Name "Biology"
	Given I have selected filters in Qualification Level and/or Awarding body
	When I click reset
	Then all filters should be cleared.

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