Feature: DFC-6188 ViewCourseRunDetails
As a User
I need to view the Course Runs (line 2) of the course details within the Your Courses screen
so that I can review the course details

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	## End of Provider Search Steps
	Given I have clicked the Main Qualification
	And I have clicked one of the courses available
	Then I should be able to view the course runs.	

Scenario: View Course Run Details
	Given I have selected a course run to update
	When I Click Save

# KADIR - THIS IS NO LONGER APPLICABLE IN YC3
#@CI 
#Scenario: For individual course, system displays the following course run details for Line 2
#	
#	Given I am on Your Course Screen Line Two and click line one
#	Then I would see a text input box with title "Course name"
#	And  I would see a text input box with title "ID"
#	And  I would see a text input box with title "Delivery"
#	And  The "Delivery" text input box should have a dropdown
#	And  I would see a text input box with title "Start Date"
#	And  I would see a text input box with title "Venue"
#	And  The "Venue" text input box should have a dropdown
#	And  I would see a title "URL"
#	And  The "URL" should have a hyperlink "view"
#	And  I would see a text input box with title "Cost"
#	And  I would see a title "Cost Description"
#	And  The "Cost Description" should have a hyperlink "view"
#	And  I would see a text input box with title "Duration"
#	And  I would see a text input box with title "Duration Unit"
#	And  The "Duration Unit" text input box should have a dropdown
#	And  I would see a text input box with title "Attendance"
#	And  The "Attendance" text input box should have a dropdown
#	And  I would see a text input box with title "Mode"
#	And  The "Mode" text input box should have a dropdown



