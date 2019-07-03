Feature: DFC-7382 Data Quality Indicator
	In order to maintain my Courses
	As a provider
	I want to be able to view course with Data Quality Issues

Background:
	Given I have accessed course directory as a provider
	And I login as provider admin with provider.10021793@gmail.com  and SITtesting123
	Then I am logged in as a provider

@CI
Scenario: COUR-41 DQI View all out of date course runs
	Given I click on the courses need their start date updated link
	Then I am taken to the DQI page


@CI
Scenario: COUR-47 DQI Edit out of Date Course Run
	Given I click on the courses need their start date updated link
	Then I am taken to the DQI page
	When I click on the first course run requiring start date update
	Then I am take to Edit Course page
	And I update the start date

		
@CI
Scenario: COUR-51 DQI Save out of Date Course Run
	Given I click on the courses need their start date updated link
	Then I am taken to the DQI page
	When I click on the first course run requiring start date update
	Then I am take to Edit Course page
	When I update the start date
	Then the Save button is displayed


@CI
Scenario: COUR-55 DQI Cancel Edited out of Date Course Run
	Given I click on the courses need their start date updated link
	Then I am taken to the DQI page
	When I click on the first course run requiring start date update
	Then I am take to Edit Course page
	When I update the start date
	And I click cancel DQI Edit
	Then I am taken to the DQI page
