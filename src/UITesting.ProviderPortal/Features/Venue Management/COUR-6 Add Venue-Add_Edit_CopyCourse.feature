Feature: COUR-6 Add Venue-Add_Edit_CopyCourse
	In order to Add a new Venue
	As a provider
	I want to be able to add venue via add course, edit course and copy course

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10033145" and clicked search
	When I click to view my courses
	 
@CI
Scenario: COUR-6 Add a Venue when adding a new course
	Given I have accessed the Regulated Qualifications page
	When I select the Regulated Option
	And I click Next
	Then Lars Search page should be displayed
	Given I have entered a Qualification Name "Chemistry"
	And I click the link to Add Qualification
	Then the First Page of Add Course should be displayed
	Given I have entered the following in Course description "Test Course for Add Venue"
	And I have clicked Next
	Then Second Page of Add Course should be displayed
	Given I have selected Delivery Mode as "Classroom"
	And  I have selected start date as "FlexibleStartDate"
	When I select the link to Add New Venue
	Then Add venue screen should be displayed.
	Given I have added a new Venue "TestAddVenue_AddCourse" 
	Then the venue "TestAddVenue_AddCourse" should be present in the Venue List
	Given I have selected "TestAddVenue_AddCourse" as venue from the Venue Checkbox List
	When I enter the following in the cost field 999.99
	When I select duration length 9
	And I select duration unit Months
	When I Select study mode Part-time
	When I Select attendance mode Daytime
	And I click Publish
	Then the Add Course Summary Page should be displayed
	And I have clicked Accept and Publish
	Then the course should be added


@CI
Scenario: COUR-6 Add a Venue when editing an existing course
	Given I have selected a course
	When I clicked the Edit course information
	Then Second Page of Edit Course should be displayed
	Given I have accessed the selected course run data
	And I have selected "Classroom" as delivery mode
	And I have selected Start Date "Defined Start Date"
	And I have entered "25" in Day, "04" in Month and "2021" in Year
	When I select the link to Add New Venue in the Edit Screen
	Then Add venue screen should be displayed.
	Given I have added a new Venue "TestAddVenue_EditCourse"
	Then the venue "TestAddVenue_EditCourse" should be present in the Venue List
	Given I have selected "TestAddVenue_EditCourse" as venue from Venue Dropdown
	And I have selected entered a value in cost "200"
	And I have entered a value in Duration "6"
	And I Select study mode "Part-time"
	And I Select attendance mode "Daytime"
	When I  Save the data
	#Then the course should be added

@CI
Scenario: COUR-6 Add a Venue when copying an existing course
	Given I have selected a course run to copy
	Then Copy Course Page should be displayed
	Given I have entered the following course name "XXX - COUR-6AddAVenueWhenCopyingAnExistingCourse" when copying a course
	Given I have selected "Classroom" as delivery mode when copying a course
	And I have selected Start Date "Defined Start Date" when copying a course
	And I have entered "25" in Day, "04" in Month and "2021" in Year when copying a course
	When I select the link to Add New Venue inthe copy course screen
	Then Add venue screen should be displayed.
	Given I have added a new Venue "TestAddVenue_CopyCourse"
	Given I have selected "TestAddVenue_CopyCourse" as venue from Venue Dropdown in the copy course page
	When I  Save the data in the copy course page
	#Then the course should be added