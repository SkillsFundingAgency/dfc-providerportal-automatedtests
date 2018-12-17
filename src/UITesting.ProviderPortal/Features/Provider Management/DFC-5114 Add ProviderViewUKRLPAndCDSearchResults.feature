Feature: DFC-5112 Add ProviderViewUKRLPAndCDSearchResults
As a user
I need to view the UKRLP and Course Directory search result
so that I can confirm that the UKPRN can be added as a new provider record to the Course Directory

@CI
Scenario: User is on Add A Provider Page
	Given I am on Add A Provider Page
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
