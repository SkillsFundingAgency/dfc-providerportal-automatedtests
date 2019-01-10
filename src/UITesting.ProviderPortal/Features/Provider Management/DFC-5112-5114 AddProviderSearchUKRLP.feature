Feature: DFC-5112-5114 AddProviderSearchUKRLP
	As a user I want to search the UKRLP using a UKPRN
so that I can check that the provider has a valid record on the UK Register of Learning Providers (UKRLP)


Background:  
#Scenario: User is on Add a Provider page
Given I am on Add a Provider Page
Then I should see label "Add Provider"
And I should see another label "Enter UKPRN number"
And I should see a text input field
And I should see a search icon


@CI
Scenario: User enters invalid input
When I do not put an input and click "Find"
Then I should see an error message UKPRN required
When I enter UKPRN less than eight digits 102345
Then I should see an error message UKPRN is 8 digit number starting with a 1 e.g. 10000364
When I enter input which is a string of alphabets"abcdef" 
Then I should see an error message UKPRN is 8 digit number starting with a 1 e.g. 10000364
When I enter UKPRN that does not start with one "23456712"
Then I should see an error message UKPRN is 8 digit number starting with a 1 e.g. 10000364

@CI
Scenario: User enters valid input
When I enter a valid input "10002370"
Then I should not see the error message on clicking "Find"

# Flow continues for story DFC-5114
@CI
Scenario: User enters valid UKPRN and sees the following input
#When I enter valid input and hit search icon or Enter key
When I enter a valid input "10002370"
Then I should not see the error message on clicking "Find"
#Then System uses the entered UKPRN to search the Course Directory system
#When UKPRN number exists in the system
Then The label will be "Course Directory Status" and the data will be "Onboarded"
Then The label will be "UKPRN Status" and the data value will be "Active"
And The label will be "UKPRN" and the data value will be the entered regiestration number
And The label wil be "Name" and the data value will be the Provider name
And The label will be "Address"and the data value will be the Provider's address and the address lines are separated by commas
And the label will be "Web" and the data value will be the Web address of provider
And The label wll be "Email" and the data value will be the Provider's email
And The label will be "Telephone" and the data value will be the Provider's telephone
And an "Add Provider" button at the bottom


####################################################################################################################
# KM - we cannot automate this scenario unless we have a mechanism of changing the status back from Onboarded      #
####################################################################################################################
#@CI
#Scenario: User adds a new provider
#When I click the Add Provider button
#Then I should see a message on top saying "Provider added"
#And The Course Directory Status data value should be "Onboarded"

#############################################
# KM - could not find a deactivated UKPRN   #
#############################################
#@CI
#Scenario: User enters a deactivated UKPRN
#When The provider status is Deactivated
#Then System displays error message 

#############################################
# KM - could not find a unregistered UKPRN  #
#############################################
#@CI
#Scenario: User enters an unregistered UKPRN 
#When No result is found for the UKPRN entered by the user
#Then System displays an error message

