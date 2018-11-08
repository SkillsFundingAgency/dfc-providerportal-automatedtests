Feature: UKRLP
		Retrieve all updates to provider data in the last 24 hours

Scenario: Requesting all Provider Updates
		Given a user is using the providers resource
		When user requests all updated providers
		Then all providers should contain required properties

Scenario: Requesting updates of a specific provider
		Given a user is using the providers resource
		When he requests details for provider 00000000
		Then the response should contain n providers 
		Then the response should contain provider 00000000

