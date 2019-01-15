Feature: DFC-5843 Add Course - Add Part 1 of Description
	In order to a add a course
	As a provider
	I want to be able to enter section 1 of the course description details

Background:
	Given I have accessed the Course Directory as a provider
	## to attach Session to UKPRN - to be removed after login
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses
	## remove up to here
	Given I have accessed the Qualifications page	
	And I have entered a Qualification Name "Biology"
	And I click the link to Add Qualification


@CI
Scenario: DFC-5843 Valid data entered in all section 1 fields
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button

@CI
Scenario: DFC-4904 Valid data entered in all section 2 fields
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered how the student will learn Classroom-based
	And I have entered what equipment will be needed Will need to buy pens
	And I have entered how the student will be assessed Practical & Exam
	And I have enter the next steps following completion of the course Level 2 of this course
	When I click Next Button

@CI
Scenario: DFC-5843 Who Course is for not entered
	Given I have specified who the course is for blank
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button Failure
	Then Page 1 error message for field Who is the course for states Enter who is the course for

@CI
Scenario: DFC-5843 Who Course is for exceeds 500 chars
	Given I have specified who the course is for ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM
	When I click Next Button Failure
	Then Page 1 error message for field Who is the course for states Who is this course for must be 500 characters or less
	And Page 1 info message for field Who is the course for states You have 1 character too many

@CI
Scenario: DFC-5843 Entry Requirements exceeds 500 chars
	Given I have specified who the course is for Anybody who wishes to learn 1234567890 !"£$%^&*()
	And I have entered the entry requirements ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM 
	When I click Next Button Failure
	Then Page 1 error message for field Entry requirements states Entry requirements must be 500 characters or less
	Then Page 1 info message for field Entry requirements states You have 1 character too many

@CI
Scenario: DFC-5843 What you will learn exceeds 500 chars
	Given I have specified who the course is for ABCD\/?><  <!"£$%^&1234567
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM
	When I click Next Button Failure
	Then Page 1 error message for field What you will learn states What you will learn must be 500 characters or less
	Then Page 1 info message for field What you will learn states You have 1 character too many

@CI
Scenario: DFC-4904 How you will learn exceeds 500 chars
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered how the student will learn ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM
	When I click Next Button Failure
	Then Page 1 error message for field How you will learn states How you’ll learn must be 500 characters or less
	Then Page 1 info message for field How you will learn states You have 1 character too many

@CI
Scenario: DFC-4904 What you need to bring exceeds 500 chars
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered what equipment will be needed ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM
	When I click Next Button Failure
	Then Page 1 error message for field What you need to bring states What you’ll need to bring must be 500 characters or less
	Then Page 1 info message for field What you need to bring states You have 1 character too many

@CI
Scenario: DFC-4904 How you will be assessed exceeds 500 chars
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered how the student will be assessed ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM
	When I click Next Button Failure
	Then Page 1 error message for field How you will be assessed states ‘How you’ll be assessed' must be 500 characters or less
	Then Page 1 info message for field How you will be assessed states You have 1 character too many

@CI
Scenario: DFC-4904 Where Next exceeds 500 chars
	Given I have specified who the course is for Semi-qualified (people)
	And I have enter the next steps following completion of the course ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLM
	When I click Next Button Failure
	Then Page 1 error message for field Where next states 'Where next' must be 500 characters or less
	Then Page 1 info message for field Where next states You have 1 character too many

