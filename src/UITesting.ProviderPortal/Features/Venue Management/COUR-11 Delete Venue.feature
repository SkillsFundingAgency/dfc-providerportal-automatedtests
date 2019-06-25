Feature: COUR-11 Delete Venue
	In order to manage my venues
	As a provider
	I want to be able to delete venues

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10007348" and clicked search
	When I click to view my courses
	Given I have navigated to the Your Venues Pages
	Then I should be able to see a Edit and Delete Link
@CI
Scenario: COUR-11 Validate after clicking Delete button
	Given I have searched for "TestDeleteVenueWithCourse" 
	And clicked the delete link for "TestDeleteVenueWithCourse" 
	Then I should be able to see a confirm delete button and a cancel link

@CI
Scenario: COUR-11 Click cancel to stop deletion of venue
	Given I have searched for "TestDeleteVenueNoCourse" 
	And clicked the delete link for "TestDeleteVenueNoCourse"
	And I have clicked the cancel link for "TestDeleteVenueNoCourse"
	Then I should be able to see a Edit and Delete Link
	And Venue "TestDeleteVenueNoCourse" should not be deleted

@CI
Scenario: COUR-11 Delete Venue with no course
	Given I have searched for "TestDeleteVenueNoCourse" 
	And clicked the delete link for "TestDeleteVenueNoCourse" 
	Then I should be able to see a confirm delete button and a cancel link
	When I have clicked the confirm delete button for "TestDeleteVenueNoCourse"
	Then the venue should be deleted "TestDeleteVenueNoCourse"
	And a delete message should be displayed "Venue TestDeleteVenueNoCourse has been deleted"

@CI
Scenario: COUR-11 Delete Venue with course associated with Venue
	Given I have searched for "TestDeleteVenueWithCourse" 
	And there is a course associated with the venue "TestDeleteVenueWithCourse"
	And clicked the delete link for "TestDeleteVenueWithCourse" 
	#Then I should be able to see a confirm delete button and a cancel link
	#When I have clicked the confirm delete button for "TestDeleteVenueWithCourse"
	Then the venue "TestDeleteVenueWithCourse" should not be deleted 
	And a message should be displayed "There are live courses associated with this venue. Please delete these courses or assign a different venue to the courses before deleting the venue"
