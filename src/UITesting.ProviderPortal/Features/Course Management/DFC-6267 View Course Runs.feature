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
Scenario: Sum of course runs displayed matches the runs expected totalled by qualification level
	Given I have added up the number of runs expected for each qualification level
	 And I have added up the total runs for each course
	 Then The total number of runs by course matches the total by qualification level


@CI
Scenario: Open Qual type accordian and then open second Course accordian
Given I have openend the main Qual Type accordian
And I have openned the secondary Course accordian
When I add up the number of course runs displayed
Then The total number of runs by course matches the total by qualification level

