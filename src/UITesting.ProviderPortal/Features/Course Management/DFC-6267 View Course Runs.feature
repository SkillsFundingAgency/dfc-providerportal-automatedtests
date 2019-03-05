Feature: DFC-6186 View Course Runs
As a provider
I need to view all of the course runs within a selected LARS/QAN Reference course
so that I can quickly review all of these related course runs

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10000654" and clicked search
	When I click to view my courses



#@CI
#Scenario: Sum of course runs displayed matches the runs expected totalled by qualification level
#Given I have openend the main Qual Type accordian
#And I have openned the secondary Course accordian
#	And I have added up the number of runs expected for each qualification level
#	 And I have added up the total runs for each course
#	 Then The total number of runs by course matches the total by qualification level


#@CI
#Scenario: Open accordian and count all course runs shown and compare with total expected
#Given I have openend the main Qual Type accordian
#And I have openned the secondary Course accordian
#When I add up the number of course runs displayed
#And I get the main total of course runs from the main heading
#Then The total number of runs by course matches the total by qualification level

@CI
Scenario: Maximise all course runs for default Qualification Level on entering YC-three
Given I am on the YC-three screen
And The default Qualification Level is open in YC-three
Then the number of courses displayed matches the facet shown for Level in YC-three
When I click on each course listed for the qualification level that is selected in YC-three
Then the number of course runs displayed matches the facet shown for each Course in YC-three
When I click on each course run listed for each qualification level that is selected in YC-three


#Then the number of course runs matches the facet shown for the course in YC-three
#When I click on all displayed course runs in YC-three
#Then All the course run details are open for all open course runs in YC-three


