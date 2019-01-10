Feature: DFC-6186 View Course Runs
As a provider
I need to view all of the course runs within a selected LARS/QAN Reference course
so that I can quickly review all of these related course runs

Background:
	#Given I have logged into course directory as a provider
	#And I have navigated to the Your-Courses Page
	#And accordion of courses is maximised

	Given I have accessed my courses
	Then I want to view the course details

@CI
Scenario: Show Course Runs for a given course LARS Ref
	Given The first course displayed has a count of total live course runs
