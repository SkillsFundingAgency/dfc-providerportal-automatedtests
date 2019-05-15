Feature: Non Regulated Qualification Search

	In order to select a Non Reg Provision
	As a provider
	I want to be able to add a non reg provision as my published course


@BrowserStack
Scenario Outline: Add Non Regulated Provision using SSA
	Given I have navigated to the Home page using <profile> and <environment>
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I Navigate to Regulated Qualifications page
	And I have selected Non Regulated Option and Clicked Next
	Then the Unregulated courses page should be displayed
	Given I have clicked  I dont know z code link
	Then Unknown Z code page should be displayed
#	Given I have accessed the UnKnown Z Code Page
	When I Select First Level and Second Level
	And I click the Add this Provision link
	Then add course page should be displayed
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button
	Then add course run should be displayed
	When I enter the following in the course name field Course test for non regulated course
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 03 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 2000
	And I select duration length 12
	And I select duration unit Weeks
	And I select the first venue in the venues list
	And I click Publish
	Then the course should be listed in the Your courses page

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