Feature: DFC-6494 Search Provider
	In order to view provider details
	As a provider
	I want to be able to search for providers

Background:  
Given I have accessed course directory as a provider
And I login as admin with user and password
Then I am logged in
And I navigate to the Search provider screen
Then I am on the Search Providers page


@CI
Scenario:DFC-6494 Search Provider
	When I have searched for UKPRN "10002815" and clicked search

#   ****COMMNETING OUT DUE TO REWORK BEING DONE FOR SERACH PROVIDER
#	Then search results for the provider are displayed	
#
#@CI
#Scenario:COUR-481 Search Provider using UKPRN full
#	When I have searched for UKPRN "10002815" and clicked search
#	Then search results for the provider are displayed	
#	Then 1 providers is displayed in the search results
#	And the UKPRN for the provider is 10002815
#
#@CI
#Scenario:COUR-481 Search Provider using UKPRN full not onboarded
#	When I have searched for UKPRN "10040175" and clicked search
#	Then No results message is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using UKPRN partial
#	When I have searched for UKPRN "1003317" and clicked search
#	Then search results for the provider are displayed	
#	Then 10 providers is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using UKPRN below min entry
#	When I have searched for UKPRN "100" and clicked search
#	Then No results message is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using Provider Name full
#	When I have searched for UKPRN "University College Birmingham" and clicked search
#	Then 1 providers is displayed in the search results
#	And the Name for the provider is University College Birmingham
#
#@CI
#Scenario:COUR-481 Search Provider using Provider Name full - not onbaorded
#	When I have searched for UKPRN "COVERGIRL ACADEMY LTD" and clicked search
#	Then No results message is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using Provider Name partial
#	When I have searched for UKPRN "coverg" and clicked search
#	Then 1 providers is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using Provider Name below min entry
#	When I have searched for UKPRN "Co" and clicked search
#	Then No results message is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using Town full
#	When I have searched for UKPRN "Moseley" and clicked search
#	Then 6 providers is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using Town partial
#	When I have searched for UKPRN "Bir" and clicked search
#	Then 10 providers is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using Town Name below min entry
#	When I have searched for UKPRN "Bi" and clicked search
#	Then No results message is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using Postcode full
#	When I have searched for UKPRN "NW3 6XH" and clicked search
#	Then 1 providers is displayed in the search results
#	And the Name for the provider is UNIVERSITY COLLEGE SCHOOL
#
#@CI
#Scenario:COUR-481 Search Provider using Postcode partial
#	When I have searched for UKPRN "EC2" and clicked search
#	Then 10 providers is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using Postcode below min entry
#	When I have searched for UKPRN "EC" and clicked search
#	Then No results message is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using invalid search input
#	When I have searched for UKPRN "EC" and clicked search
#	Then No results message is displayed in the search results
#
#@CI
#Scenario:COUR-481 Search Provider using UKPRN and view provider
#	When I have searched for UKPRN "10002815" and clicked search
#	Then 1 providers is displayed in the search results
#	And the UKPRN for the provider is 10002815
#	When I click the view link
#	Then provider details page is displayed