Feature: DFC 6074 Add Course - Add Course Details

As a User
I need the following actions to be performed on page 2:
Add Provider Course Reference/ID
Add Course Name
Add Course URL
Add Cost
Add Cost Description
Select Study Mode
Select Attendance Mode
so that I can add a course

Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Add Course Section 2 page

@CI
Scenario: DFC4950 User Adds Course Name
	When I enter the following in the course name field Course 123(A-1)
	Then course name error validation is not displayed

@CI
Scenario: DFC4950 User does not enter Course Name
	When I enter the following in the course name field Course blank
	And I enter the following in the URL field https://www.google.com
	Then course name error validation is displayed
	And error message for field Course Name states Enter Course Name

@CI
Scenario: DFC4950 User enter Course Name greater than 255 chars
	When I enter the following in the course name field Course ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV
	And I enter the following in the URL field https://www.google.com
	Then course name error validation is displayed
	And error message for field Course Name states The maximum length of Course Name is 255 characters

@CI
Scenario: DFC4950 User enters invalid Course Name
	When I enter the following in the course name field Course 我想输入文字
	And I enter the following in the URL field https://www.google.com
	Then course name error validation is displayed
	And error message for field Course Name states Invalid characters

@CI
Scenario: DFC5115 User enters valid course URL
	When I enter the following in the URL field https://www.google.com
	When I enter the following in the course name field Course test

@CI
Scenario: DFC5115 User enters valid course URL 2
	When I enter the following in the URL field http://www.google.com
	When I enter the following in the course name field Course test

@CI
Scenario: DFC5115 User enters valid course URL 3
	When I enter the following in the URL field http://www.google.net
	When I enter the following in the course name field Course test

@CI
Scenario: DFC5115 User enters valid course URL 4
	When I enter the following in the URL field http://www.12345.net
	When I enter the following in the course name field Course test

@CI
Scenario: DFC5115 User enters Invalid course URL
	When I enter the following in the URL field https://www.google
	When I enter the following in the course name field Course test
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect
	
@CI
Scenario: DFC5115 User enters Invalid course URL 2
	When I enter the following in the URL field htts://www.google
	When I enter the following in the course name field Course test
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect

@CI
Scenario: DFC5115 User enters Invalid course URL 3
	When I enter the following in the URL field https//www.google
	When I enter the following in the course name field Course test
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect

@CI
Scenario: DFC5115 User enters Invalid course URL 4
	When I enter the following in the URL field https:/www.google
	When I enter the following in the course name field Course test
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect

@CI
Scenario: DFC5115 User enters Invalid course URL 5
	When I enter the following in the URL field https://www.google.
	When I enter the following in the course name field Course test
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect

@CI
Scenario: DFC5115 User enters Invalid course URL 6
	When I enter the following in the URL field test
	When I enter the following in the course name field Course test
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect

@CI
Scenario: DFC5116 User enters valid cost
	When I enter the following in the cost field 9
	When I enter the following in the course name field Course test

@CI
Scenario: DFC5116 User enters valid cost 1
	When I enter the following in the cost field 0.01
	When I enter the following in the course name field Course test

@CI
Scenario: DFC5116 User enters valid cost 2
	When I enter the following in the cost field 999999.99
	When I enter the following in the course name field Course test

@CI
Scenario: DFC5116 User enters invalid cost 
	When I enter the following in the cost field 9999999
	When I enter the following in the course name field Course test
	Then course Cost error validation is displayed
	And error message for field Cost states Maximum value for cost is £999,999.99

@CI
Scenario: DFC5116 User enters no cost 
	When I enter the following in the cost field blank
	When I enter the following in the course name field Course test
	Then course Cost error validation is displayed
	And error message for field Cost states Enter the cost in pounds and pence


@CI
Scenario: DFC5011 User Adds Provider Course ID
	When I enter the following in the course id field 123(A-1)
	And I enter the following in the course name field Course test

@CI
Scenario: DFC5011 User does not enter Course ID
	When I enter the following in the course id field blank
	And I enter the following in the URL field https://www.google.com
	Then course id error validation is displayed
	And error message for field Course ID states Enter an ID

@CI
Scenario: DFC5011 User enter Course ID greater than 255 chars
	When I enter the following in the course id field ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV
	And I enter the following in the URL field https://www.google.com
	Then course id error validation is displayed
	And error message for field Course ID states ID must be 255 characters or less

@CI
Scenario: DFC5011 User enters invalid Course ID
	When I enter the following in the course id field 我想输入文字
	And I enter the following in the URL field https://www.google.com
	Then course id error validation is displayed
	And error message for field Course ID states Invalid characters	

@CI
Scenario: DFC4768 User Adds Cost Description
	When I enter the following in the cost description field 123(A-1) £!"£$%^&*()_+ 1234567890-= QWERTYUIOP asdfghjklmnbvcxz #';:@~/.,<>?|\ qwertyuiop ASDFGHJKL ZXCVBNM
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4768 User Adds Cost Description max chars
	When I enter the following in the cost description field ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTU
	And I enter the following in the course name field Course test
	Then info message for field Cost Description states You have 0 characters remaining

@CI
Scenario: DFC4768 User Adds Cost Description over max chars
	When I enter the following in the cost description field ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV
	And I enter the following in the course name field Course test
	Then cost description error validation is displayed
	And error message for field Cost Description states Cost description must be 255 characters or less
	And info message for field Cost Description states You have 1 character too many

@CI
Scenario: DFC4768 User Adds Cost Description under max chars
	When I enter the following in the cost description field ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRST
	And I enter the following in the course name field Course test
	Then info message for field Cost Description states You have 1 character remaining

@CI
Scenario: DFC4810 User Select Attendance Evening
	When I Select attendance mode Evening
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4810 User Select Attendance Weekend
	When I Select attendance mode Weekend
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4810 User Select Attendance Day/Block Release
	When I Select attendance mode Day/Block Release
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4810 User Select Attendance Daytime
	When I Select attendance mode Day/Block 
	When I Select attendance mode Daytime
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4770 User Study Mode Full-time
	When I Select study mode Part-time
	When I Select study mode Full-time
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4770 User Study Mode Part-time
	When I Select study mode Part-time
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4770 User Study Mode Flexible
	When I Select study mode Flexible
	And I enter the following in the course name field Course test