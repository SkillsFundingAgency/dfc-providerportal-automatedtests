Feature: DFC-6494 Search Provider
	In order to view provider details
	As a provider
	I want to be able to search for providers

Background:
	Given I have accessed the Course Directory as a provider
	## to attach Session to UKPRN - to be removed after login
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses
	## remove up to here
	Given I have accessed the Qualifications page	
	And I have entered a Qualification Name "Biology"
	And I click the link to Add Qualification


@CI
Scenario: DFC-5843 Valid data entered in all section 1 fields
	Given I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject 
	When I click Next Button