Feature: DFC-6188 ViewCourseRunDetailsLine2
As a User
I need to view the Course Runs (line 2) of the course details within the Your Courses screen
so that I can review the course details

@CI 
Scenario: For individual course, system displays the following course run details for Line 2
	
	
    Given I have accessed the Course Directory as a provider for the first time
   
	Then I would see a text input box with title "Course name"
	And  I would see a text input box with title "ID"
	And  I would see a text input box with title "Delivery"
	And  The "Delivery" text input box should have a dropdown
	And  I would see a text input box with title "Start Date"
	And  I would see a text input box with title "Venue"
	And  The "Venue" text input box should have a dropdown
	And  I would see a title "URL"
	And  The "URL" should have a hyperlink "view"
	And  I would see a text input box with title "Cost"
	And  I would see a title "Cost Description"
	And  The "Cost Description" should have a hyperlink "view"
	And  I would see a text input box with title "Duration"
	And  I would see a text input box with title "Duration Unit"
	And  The "Duration Unit" text input box should have a dropdown
	And  I would see a text input box with title "Attendance"
	And  The "Attendance" text input box should have a dropdown
	And  I would see a text input box with title "Mode"
	And  The "Mode" text input box should have a dropdown



