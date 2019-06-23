Feature: COUR-107-SearchonYourCourses
	In order to look at my courses
	As a user
	I want to be able to search for my courses

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	Then I should be able to view a Search box to enter my search criteria
@CI
Scenario: COUR-107 Enter a valid search term in full
	Given I have entered a full search term as "Biology"
	Then the results with biology should be returned

@CI
Scenario: COUR-107 Enter first three characters of valid search term
	Given I have entered a part search term as "Mat"
	Then the results containing Mat should be returned

@CI
Scenario: COUR-107 Search via LARS/QAN Number
	Given I have entered a LARS number in search "00288759"
	Then the results with the LARS number should be returned

@CI
Scenario: COUR-107 Search for a non existent course
	Given I have entered a non existant course "bsdfaf"
	Then the following message should be displayed "No courses found that match your search criteria"

