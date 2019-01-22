
Feature: DFC-5844As a User
I want to select the ‘Online’ option for Delivery Mode
so that I can assign the ‘Online’ option for the course within the Course Directory

Background:
   Given I have accessed the Course Directory as a provider
	
	## Use Provider Search to Navigate o course for a Provider
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses
	## End of Provider Search Steps

	
	Given I have accessed the Qualifications page
	And I have entered a Qualification Name "Biology"
	And I click the link to Add Qualification
	And I have specified who the course is for Semi-qualified (people)
	And I have entered the entry requirements 1. Industry experience
	And I have entered what the student will learn Student will learn about the subject
	When I click Next Button
	
	

@CI
Scenario: System displays existing page 2 of ‘Add Course’ screen
    Given I have navigated to the Add Course Section 2 page screen
	Then I should see Select Venue option
	And I should see Full Time or Part Time option
	And I should see Attendance option
	When I click Online option within Delivery mode
	Then I should not see Select Venue Option
	And I should not see Full Time or Part Time option
	And I should not see Attendance option
	And Flexible Start Date is already selected 
	##And I enter 01 in the Day field
	## And I enter 01 in the Month field
	## And I enter 2020 in the Year field
	
	


	
