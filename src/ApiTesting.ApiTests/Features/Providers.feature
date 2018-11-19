Feature: UKRLP
		Retrieve all updates to provider data in the last 24 hours

Scenario: SYNC Providers
		Given a user is using the providers resource
		When user requests sync providers
		Then all providers should contain required properties

Scenario: Requesting updates of a specific provider
		Given a user is using the providers resource
		When he requests details for provider 00000000
		Then the response should contain n providers 
		Then the response should contain provider 00000000

Scenario: GET All Providers 
		Given a user is using the providers resource
		When user requests all providers
		Then all providers should contain required properties

Scenario: GET Provider by UKPRN
		Given a user is using the providers resource
		When he requests details for provider 00000000 By UKPRN
		Then the response should contain 1 providers 
		Then the response should contain provider 00000000

Scenario: GET Provider by Name
		Given a user is using the providers resource
		When he requests details for provider 00000000 By Name
		Then the response should contain n providers 
		Then the response should contain provider 00000000

Scenario: GET Provider by UKPRN using POST
		Given a user is using the providers resource
		When he requests details for provider 00000000 By UKPRN POST Method
		Then the response should contain n providers 
		Then the response should contain provider 00000000

Scenario: GET Provider by Name using POST
		Given a user is using the providers resource
		When he requests details for provider 00000000 By Name POST Method
		Then the response should contain n providers 
		Then the response should contain provider 00000000
