Feature: DFC-5112 AddProviderSearchUKRLP
	As a user I want to search the UKRLP using a UKPRN
so that I can check that the provider has a valid record on the UK Register of Learning Providers (UKRLP)

@CI
Scenario: User is on Add a Provider page
Given I am on Add a Provider Page
Then I should see label "Add A Provider"
And I should see label "Enter UKPRN number"
And I should see a text input field

Scenario: User enters invalid input
When I do not put an input and click "Find"
Then I should see an error message
When I enter UKPRN less than 8 digits
Then I should see an error message
When I enter input which is either a string of alphabets or a string of alphanumeric characters
Then I should see an error message
When I enter UKPRN that does not start with 1 
Then I should see an error message

Scenario: User enters valid input
When I enter a valid input
Then I should not see the error message on clicking "Find"


