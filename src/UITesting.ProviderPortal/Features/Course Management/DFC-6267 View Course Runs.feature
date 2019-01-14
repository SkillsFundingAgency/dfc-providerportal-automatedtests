Feature: DFC-6186 View Course Runs
As a provider
I need to view all of the course runs within a selected LARS/QAN Reference course
so that I can quickly review all of these related course runs

Background:
	#Given I have logged into course directory as a provider
	#And I have navigated to the Your-Courses Page
	#And accordion of courses is maximised

	#have to add these 2 steps to 'log in' as a provider with UKPRN
	Given I have accessed the Course Directory
	And I have searched for a PRN Number "UKPRN Number" 

	Given I have accessed my courses
	Then I want to view the course details

@CI
Scenario: Sum of course runs displayed for run matches the total course runs expected
	Given The first course displayed has a count of total live course runs
	 And the count of live course runs matches number of course runs displayed


