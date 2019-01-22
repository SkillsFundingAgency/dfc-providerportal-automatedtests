Feature: Add Course

As a User
I need to provide the mandatory information
so that I can add a course


@BrowserStack
Scenario Outline: Add a Course
	Given I have navigated to the Home page using <profile> and <environment>
	## Use Provider Search to Navigate to course for a Provider
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses
	## End of Provider Search Steps
	Given I have accessed the Qualifications page	
	And I have entered a Qualification Name "Biology"
	And I click the link to Add Qualification
	And I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button
	When I enter the following in the course name field Course test
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 999
	And I select duration length 9
	And I select duration unit Weeks
	And I select the first venue in the venues list
	And I click Publish

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