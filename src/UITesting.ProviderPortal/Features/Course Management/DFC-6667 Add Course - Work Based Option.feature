Feature: DFC-6667 Add Course - Work Based Option
	In order to Add A Course
	As a provider
	I want the option to make the Course Work Based


Background:
	Given I have accessed the Course Directory as a provider
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses

	Given I have accessed the Qualifications page	
	And I have entered a Qualification Name "Biology"
	And I click the link to Add Qualification
	And I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button

@CI
Scenario: Enter Work Based Options when adding a course
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption1
	And I enter the following in the cost field 999.00
	And I click on the Work Based Option Radio Button
	Then the flexible start date option is selected
	And the venue selection options are not shown
	And full time or part time options are hidden
	And Day Night or Weekend attendance options are hidden
	And the course region selection options are shown

	@CI
Scenario: Publish course with Work Based Options selected
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption2
	And I enter the following in the cost field 1999.00
	And I click on the Work Based Option Radio Button
	And I select the first course region option on selector
	And I select duration length 9
	And I click Publish
