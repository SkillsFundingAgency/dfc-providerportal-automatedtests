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
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have accessed the Qualifications page	
	And I have entered a Qualification Name "Biology"
	And I click the link to Add Qualification
	And I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button

@CI
Scenario: DFC4950 User Adds Course Name
	When I enter the following in the course name field Course 123(A-1)
	Then course name error validation is not displayed

@CI
Scenario: DFC4950 User does not enter Course Name
	When I enter the following in the course name field Course blank
	And I enter the following in the URL field https://www.google.com
	And I click Publish leading to error
	Then course name error validation is displayed
	And error message for field Course Name states Enter course name

@CI
Scenario: DFC4950 User enter Course Name greater than 255 chars
	When I enter the following in the course name field Course ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV
	And I enter the following in the URL field https://www.google.com
	And I click Publish leading to error
	Then course name error validation is displayed
	And error message for field Course Name states The maximum length of Course Name is 255 characters

@CI
Scenario: DFC4950 User enters invalid Course Name
	When I enter the following in the course name field Course 我想输入文字
	And I enter the following in the URL field https://www.google.com
	And I click Publish leading to error
	Then course name error validation is displayed
	And error message for field Course Name states Course Name contains invalid characters

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
	When I enter the following in the URL field https://w.google
	When I enter the following in the course name field Course test
	And I click Publish leading to error
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect
	
@CI
Scenario: DFC5115 User enters Invalid course URL 2
	When I enter the following in the URL field htts://wwwgoogle
	When I enter the following in the course name field Course test
	And I click Publish leading to error
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect

@CI
Scenario: DFC5115 User enters Invalid course URL 3
	When I enter the following in the URL field https//w.g
	When I enter the following in the course name field Course test
	And I click Publish leading to error
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect

@CI
Scenario: DFC5115 User enters Invalid course URL 4
	When I enter the following in the URL field test
	When I enter the following in the course name field Course w.bbc.co.uk
	And I click Publish leading to error
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect  

@CI
Scenario: DFC5115 User enters Invalid course URL 5
	When I enter the following in the URL field https://w..test
	When I enter the following in the course name field Course test
	And I click Publish leading to error
	Then course URL error validation is displayed
	And error message for field URL states The format of URL is incorrect
	And the error summary header should say "There is an issue with this qualification"
	And the error message is displayed on the header "The format of URL is incorrect"

@CI
Scenario: DFC5115 User enters Invalid course URL 6
	When I enter the following in the URL field test
	When I enter the following in the course name field Course test
	And I click Publish leading to error
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
Scenario: DFC5116 User enters no cost 
	When I enter the following in the cost field blank
	When I enter the following in the course name field Course test
	And I click Publish leading to error
	Then course Cost error validation is displayed
	Then error message for field Invalid Cost states Enter cost or cost description

@CI
Scenario: DFC5011 User Adds Provider Course ID
	When I enter the following in the course id field 123(A-1)
	And I enter the following in the course name field Course test

@CI
Scenario: DFC5011 User does not enter Course ID
	When I enter the following in the course id field blank
	And I enter the following in the URL field https://www.google.com

@CI
Scenario: DFC5011 User enter Course ID greater than 255 chars
	When I enter the following in the course id field ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV
	And I enter the following in the URL field https://www.google.com
	And I click Publish leading to error
	Then course id error validation is displayed
	And error message for field Course ID states The maximum length of 'ID' is 255 characters

@CI
Scenario: DFC5011 User enters invalid Course ID
	When I enter the following in the course id field 我想输入文字
	And I enter the following in the URL field https://www.google.com
	And I click Publish leading to error
	Then course id error validation is displayed
	And error message for field Course ID states ID contains invalid characters

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
	And I click Publish leading to error
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

@CI
Scenario: DFC4901 Select Flexible Start Date
	When I select start date Flexible Start Date
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4901 Select Defined Start Date and enter no date
	When I select start date Defined Start Date
	And I enter the following in the course name field Course test
	And I click Publish leading to error
	Then error message for field Start Date states Enter start date

@CI
Scenario: DFC4901 Select Defined Start Date and enter valid date
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2020 in the Year field
	And I enter the following in the course name field Course test
	And I click Publish leading to error

@CI
Scenario: DFC4901 Select Defined Start Date and enter date before today
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2019 in the Year field
	And I enter the following in the course name field Course test
	And I click Publish leading to error
	Then error message for field Past Date states Start Date cannot be earlier than today’s date

@CI
Scenario: DFC4901 Select Defined Start Date and enter date more than 2 years in future
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2024 in the Year field
	And I enter the following in the course name field Course test
	And I click Publish leading to error
	Then error message for field Future Date states Start Date cannot be later than 2 years from today’s date

@CI
Scenario: DFC4901 Select Defined Start Date and enter invalid date
	When I select start date Defined Start Date
	And I enter 30 in the Day field
	And I enter 02 in the Month field
	And I enter 2020 in the Year field
	And I enter the following in the course name field Course test
	And I click Publish leading to error
	Then error message for field Invalid Date states Invalid date

@CI
Scenario: DFC4902 Select Duration in Days
	When I select duration length 999
	And I select duration unit Days
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4902 Select Duration in Weeks
	When I select duration length 099
	And I select duration unit Weeks
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4902 Select Duration in Months
	When I select duration length 9
	And I select duration unit Months
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4902 Select Duration in Years
	When I select duration length 1
	And I select duration unit Years
	And I enter the following in the course name field Course test

@CI
Scenario: DFC4902 No Duration entered
	When I enter the following in the course name field Course test
	And I select the first venue in the venues list
	And I click Publish leading to error
	Then error message for field Duration states Enter duration	

@CI
Scenario: DFC4769 Select Single Venue 
	When I enter the following in the course name field Course test
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 999
	And I select duration length 9
	And I select duration unit Weeks
	And I select the first venue in the venues list

@CI
Scenario: DFC4769 Select Multiple Venues 
	When I enter the following in the course name field Course test
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 999
	And I select duration length 9
	And I select duration unit Weeks
	And I select the first venue in the venues list
	And I select the second venue in the venues list

@CI
Scenario: DFC4900 User Publishes Course
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

@CI
Scenario: DFC6704 User clicks back to page 1
	When I enter the following in the course name field Course test
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 999
	And I select duration length 9
	And I select duration unit Weeks
	And I select the first venue in the venues list
	And I click Page1 link
	When I click Next Button
	And I click Publish

@CI
Scenario: DFC6704 Session maintainance - Classroom based
	When I enter the following in the course name field Course test
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 999
	And I select duration length 9
	And I select duration unit Weeks
	And I select the first venue in the venues list
	And I click Page1 link
	When I click Next Button
	And I click Publish

@CI
Scenario: DFC6704 Session maintainance - Single Region
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption2
	And I enter the following in the cost field 1999.00
	And I click on the Work Based Option Radio Button
	And I click on No to National coverage
	And I select the first course region option on selector
	And I select duration length 9
	And I click Page1 link
	When I click Next Button
	And I click Publish

@CI
Scenario: DFC6704 Session maintainance - National Coverage
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption2
	And I enter the following in the cost field 1999.00
	And I click on the Work Based Option Radio Button
	And I click on Yes to National coverage
	And I select duration length 9
	And I click Page1 link
	When I click Next Button
	And I click Publish

@CI
Scenario: DFC6704 Session maintainance - Online Delivery
	When I enter the following in the course name field Course test
	When I select delivery mode Online
	When I select start date Defined Start Date
	And I enter 01 in the Day field
	And I enter 01 in the Month field
	And I enter 2021 in the Year field
	And I enter the following in the cost field 999
	And I select duration length 9
	And I select duration unit Weeks
	And I click Page1 link
	When I click Next Button
	And I click Publish