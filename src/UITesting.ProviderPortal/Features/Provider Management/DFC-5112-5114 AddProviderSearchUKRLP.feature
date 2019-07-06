Feature: DFC-5112-5114 AddProviderSearchUKRLP
As a user I want to search the UKRLP using a UKPRN
so that I can check that the provider has a valid record on the UK Register of Learning Providers (UKRLP)


Background:  
Given I have accessed course directory as a provider
And I login as admin with user and password
Then I am logged in
#Given I have searched for UKPRN "10002815" and clicked search
#When I click to view my courses
## End of Provider Search Steps
Given I am on Add a Provider Page
Then I should see label "Add Provider"
And I should see another label "Enter UKPRN number"
And I should see a text input field
And I should see a search icon

@CI
Scenario: DFC-5112 User enters invalid input_BUG_COUR-1159
When I do not put an input and click "Find"
Then I should see an error message UKPRN required
When I enter UKPRN less than eight digits 102345
Then I should see an error message UKPRN is 8 digit number starting with a 1 e.g. 10000364
When I enter input which is a string of alphabets"abcdef" 
Then I should see an error message UKPRN is 8 digit number starting with a 1 e.g. 10000364
When I enter UKPRN that does not start with one "23456712"
Then I should see an error message UKPRN is 8 digit number starting with a 1 e.g. 10000364

@CI
Scenario: DFC-5112 User enters valid input
When I enter a valid input "10002370"
Then I should not see the error message on clicking "Find"

@CI
Scenario: DFC-5114 User enters valid UKPRN and sees the following input
When I enter a valid input "10002370"
Then I should not see the error message on clicking "Find"
Then The label will be "Course directory status" and the data will be "Onboarded"
Then The label will be "UKPRN status" and the data value will be "Active"
And The label will be "UKPRN" and the data value will be the entered regiestration number
And The label wil be "Name" and the data value will be the Provider name
And The label will be "Address"and the data value will be the Provider's address and the address lines are separated by commas
And the label will be "Web" and the data value will be the Web address of provider
And The label wll be "Email" and the data value will be the Provider's email
And The label will be "Telephone" and the data value will be the Provider's telephone
And an "Add provider" button at the bottom
