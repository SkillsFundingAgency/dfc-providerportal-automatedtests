Feature: DFC-6186 View Course Runs
As a provider
I need to view all of the course runs within a selected LARS/QAN Reference course
so that I can quickly review all of these related course runs

Background:

	Given I have accessed the Course Directory as a provider
	And I have navigated to the Search Provider Page
	When I enter 10001800 and click search provider
	And I click to view my courses
	#10028015

#@CI
#Scenario: Sum of course runs displayed matches the runs expected totalled by qualification level
#Given I have openend the main Qual Type accordian
#And I have openned the secondary Course accordian
#	And I have added up the number of runs expected for each qualification level
#	 And I have added up the total runs for each course
#	 Then The total number of runs by course matches the total by qualification level


@CI
Scenario: Open accordian and count all course runs shown and compare with total expected
Given I have openend the main Qual Type accordian
And I have openned the secondary Course accordian
When I add up the number of course runs displayed
And I get the main total of course runs from the main heading
Then The total number of runs by course matches the total by qualification level

