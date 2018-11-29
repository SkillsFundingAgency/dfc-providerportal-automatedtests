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
Scenario Outline: GET Provider by UKPRN
		Given a user is using the providers resource
		When he requests details for provider <ukprn_ref> By UKPRN
		Then the response contains provider UKPRN <ukprn_ref>
Examples: 
| ukprn_ref |
| 10025273  |
| 10028192  |
| 10030798  |
| 10057206  |


@ukrlp
Scenario Outline: GET Provider by Name
		Given a user is using the providers resource
		When he requests details for provider <provider_name> By Name
		Then the response should contain <provider_count> providers
		Then the response should contain provider <provider_name>
Examples:
| provider_name | provider_count |
| XENON         | 1              |
| MARCUS EVANS  | 1              |
| TEACH         | 34             |


@ukrlp
Scenario Outline: GET Provider by UKPRN using POST
		Given a user is using the providers resource
		When he requests details for provider <ukprn_ref> By UKPRN POST Method
		Then the response contains provider UKPRN <ukprn_ref>
Examples:
| ukprn_ref |
| 10025273  |
| 10028192  |
| 10030798  |
| 10057206  |


@ukrlp
Scenario Outline: GET Provider by Name using POST
		Given a user is using the providers resource
		When he requests details for provider <provider_name> By Name POST Method
		Then the response should contain <provider_count> providers
		Then the response should contain provider <provider_name>
Examples:
| provider_name | provider_count |
| XENON         | 1              |
| MARCUS EVANS  | 1              |
| TEACH         | 34             |
