Feature: DFC-6667 Add Course - Work Based Option
	In order to Add A Course
	As a provider
	I want the option to make the Course Work Based


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
Scenario: DFC-6667 Enter Work Based Options when adding a course field changes
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption1
	And I enter the following in the cost field 999.00
	And I click on the Work Based Option Radio Button
	Then the flexible start date option is selected
	And the venue selection options are not shown
	And full time or part time options are hidden
	And Day Night or Weekend attendance options are hidden
	And the course region selection options are shown

	@CI
Scenario: DFC-6667 Publish course with Work Based Options - Single Region
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption2
	And I enter the following in the cost field 1999.00
	And I click on the Work Based Option Radio Button
	And I click on No to National coverage
	And I select the first course region option on selector
	And I select duration length 9
	And I click Publish

	@CI
Scenario: DFC-6667 Publish course with Work Based Options - No Region Selected_BUG_COUR-1183
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption2
	And I enter the following in the cost field 1999.00
	And I click on the Work Based Option Radio Button
	And I click on No to National coverage
	And I select duration length 9
	And I click Publish leading to error
	Then error message for field Sub Region states Select at least one region

@CI
Scenario: DFC-6667 Publish course with Work Based Options - National Coverage
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption2
	And I enter the following in the cost field 1999.00
	And I click on the Work Based Option Radio Button
	And I click on Yes to National coverage
	And I select duration length 9
	And I click Publish

@CI
Scenario: DFC-6667 Publish course with Work Based Options - National Flag not answered
	When I enter the following in the course name field Course AutoTestAddWorkBasedOption2
	And I enter the following in the cost field 1999.00
	And I click on the Work Based Option Radio Button
	And I select duration length 9
	And I click Publish leading to error
	Then error message for field National Check states Choose if you can deliver this course anywhere in England