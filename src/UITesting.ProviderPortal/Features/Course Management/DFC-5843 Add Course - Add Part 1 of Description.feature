Feature: DFC-5843 Add Course - Add Part 1 of Description
	In order to a add a course
	As a provider
	I want to be able to enter section 1 of the course description details

@CI
Scenario Outline: Valid data entered in all section 1 fields
	Given I am on the add a course form
	And I have specified who the course is for <audience>
	And I have entered the entry requirements <pre-requisites>
	And I have entered what the student will learn <outline>
	And I have entered how the student will learn <instruction>
	And I have entered what equipment will be needed <equipment>
	And I have entered how the student will be assessed <assessment>
	And I have enter the next step following completion of the course <next-stage>
	When I click Next Button
	Then I progess to section 2 of course description
Examples:
	| audience                | pre-requisites         | outline                              | instruction     | equipment             | assessment       | next-stage             |
	| Semi-qualified (people) | 1. Industry experience | Student will learn about the subject | Classroom-based | Will need to buy pens | Practical & Exam | Level 2 of this course |

