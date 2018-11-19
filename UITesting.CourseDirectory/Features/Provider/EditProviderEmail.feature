Feature: Edit Provider
	In order to Test updation of provider details
	As a Provider
	I want to test the Edit functionality


@regression
Scenario: Edit Provider Email Details
	Given I have logged in as a provider
	And I have accessed the provider details
	And I have added email to the provider details and clicked Save
	Then the provider details should be updated with the email


