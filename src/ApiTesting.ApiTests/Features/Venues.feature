Feature: Venues
		As a Provider Course Directory Micoservice function
		I want to Access the Venue Information resource
		So that I retrieve Venue data for my provider


#venue_count isn't checked:
@venue-view
Scenario Outline: Search request returns all Live Venues 
	Given a provider service issues a View Live Venues request 
	Then the response should contain <venue_count> venues	
	And the response returns a status of <http_response>
	Examples: 
	| venue_count | http_response |
	| 3846        | 200           |


#@venue-view
#Scenario Outline: Search request returns Live Venues matching a given ID
#	Given a provider service issues a View Live Venues request for <id> 
#	Then the response should contain <venue_count> venues
#	And the response returns a status of <http_response>
#	And the response contains venue record: <UKPRN><provider_id><venue_id><venue_name><prov_venue_id><addr1><addr2><town><county><postcode>
#	Examples:
#	| id                                   | venue_count | http_response | UKPRN    | provider_id | venue_id | venue_name                     | prov_venue_id | addr1                  | addr2         | town   | county  | postcode |
#	| cebdc367-c606-4c53-959e-cbab0db1e3f8 | 1           | 200           | 10001800 | 300021      | 3499420  | Castle Street Community Centre | CA-7          | 3 Castle Street Centre | Castle Street | Kendal | Cumbria | LA97AD   |
	





#	#And each record returned should contain correct address information:
#
#@venue-view
#Scenario: Search request returns Live Venues for a UKPRN filtered by Name
#	Given a provider service issues a View Live Venues request 
#	When the request body includes <ukprn> 
#	And the request body incudes <name>
#	Then the response should contain <venue_count> venues
#	And the response returns a status of 400
#	#And each record returned should contain correct address information:
#
#@venue-view
#Scenario: Live Venue Search request returns Live Venues for a UKPRN
#	Given a provider service issues a View Live Venues request 
#	When the request body includes <ukprn> 
#	Then the response should contain <venue_count> venues
#	And the response returns a status of 200
#	#And each record returned should contain correct address information:
#
#
#@venue-view
#Scenario Outline: Live Venue Search request containing Special Chars
#	Given a provider service issues a View Live Venues request 
#	When the request body includes <search> a special character
#	Then the response should contains zero records
#	And the response returns a status of 400
#	Examples:
#| search |
#| \      |
#| -      |
#| (      |
#| )      |
#| '      |
#| @      |
#| +      |
#| =      |
#| :      |
#| ,      |
#
#@venue-view
#Scenario: Search request issued with invalid Auth Key
#	Given a provider service issues a View Live Venues request 
#	When the request header does not contain a valid Auth Key
#	Then the response should contains zero records
#	And the response returns a status of 403
#
#
#@venue-view
#Scenario: Search request issued with empty body section
#	Given a provider service issues a View Live Venues request 
#	When the request body contains no data
#	Then the response should contains zero records
#	And the response returns a status of 400
#
#@venue-view
#Scenario: Search request issued with invalid parameter in body section
#	Given a provider service issues a View Live Venues request 
#	When the request body contains an invalid parameter
#	Then the response should contains zero records
#	And the response returns a status of 400
#
#@venue-view
#Scenario Outline: Search venues by venue id returns correct record only 
#	Given a provider service issues a View Live Venues request 
#	When the request header specifies a specific venue id <venue_id>
#	Then the response should contain <venue_count> venues
#	And the response returns a status of <http_response>
#	And the venue specified in search <venue_id> is returned in response
#	Examples: 
#	| venue_id                             | venue_count | http_response |
#	| cebdc367-c606-4c53-959e-cbab0db1e3f8 | 1        | 200           |