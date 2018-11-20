Feature: UKRLP
		Retrieve all updates to provider data in the last 24 hours

@ukrlp
Scenario: SYNC Providers
		Given a user is using the providers resource
		When user requests sync providers
		Then all providers should contain required properties

@ukrlp
Scenario: GET All Providers 
		Given a user is using the providers resource
		When user requests all providers
		Then all providers should contain required properties

@ukrlp
Scenario: GET Provider by UKPRN
		Given a user is using the providers resource
		When he requests details for provider 10025273 By UKPRN
		Then the response contains provider UKPRN 10025273

@ukrlp
Scenario: GET Provider by Name
		Given a user is using the providers resource
		When he requests details for provider XENON By Name
		Then the response should contain 1 providers By Name
		Then the response should contain provider XENON

@ukrlp
Scenario: GET Provider by UKPRN using POST
		Given a user is using the providers resource
		When he requests details for provider 10025273 By UKPRN POST Method
		Then the response contains provider UKPRN 10025273

@ukrlp
Scenario: GET Provider by Name using POST
		Given a user is using the providers resource
		When he requests details for provider XENON By Name POST Method
		Then the response should contain 1 providers By Name 
		Then the response should contain provider XENON
