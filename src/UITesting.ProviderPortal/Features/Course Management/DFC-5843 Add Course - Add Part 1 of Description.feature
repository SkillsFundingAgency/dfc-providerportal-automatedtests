Feature: DFC-5843 Add Course - Add Part 1 of Description
	In order to a add a course
	As a provider
	I want to be able to enter section 1 of the course description details


@CI
Scenario: Valid data entered in all section 1 fields
	Given I am on the add a course form
	And I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	#And I have entered how the student will learn Classroom-based
	#And I have entered what equipment will be needed Will need to buy pens
	#And I have entered how the student will be assessed Practical & Exam
	#And I have enter the next step following completion of the course Level 2 of this course
	When I click Next Button
	Then I progess to next page

