Feature: COUR-11 Delete Venue
	In order to manage my venues
	As a provider
	I want to be able to delete venues

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10001800" and clicked search
	When I click to view my courses
	Given I have navigated to the Your Venues Pages
	Then I should be able to see a Edit and Delete Link
@CI
Scenario: Validate after clicking Delete button
	Given I have clicked the delete link for Venue "TestDeleteVenueWithCourse"
	And I have clicked the delete link
	Then I should be able to see a confirm delete button and a cancel link
@CI
Scenario: Click cancel to stop deletion of venue
	Given I have clicked the delete link for Venue "TestDeleteVenueNoCourse"
	And I have clicked the cancel link
	Then I should be able to see a Edit and Delete Link
	And Venue "TestDeleteVenueNoCourse" should not be deleted
@CI
Scenario: Delete Venue with no course
	Given I have clicked the delete link for Venue "TestDeleteVenueNoCourse"
	And I have clicked the delete link
	Then I should be able to see a confirm delete button and a cancel link
	When I have clicked the confirm delete button
	Then the venue should be deleted "TestDeleteVenueNoCourse"
	And a delete message should be displayed "Venue TestDeleteVenueNoCourse has been deleted"
@CI
Scenario: Delete Venue with course associated with Venue
	Given I have clicked the delete link for Venue "TestDeleteVenueWithCourse"
	And I have clicked the delete link
	Then I should be able to see a confirm delete button and a cancel link
	When I have clicked the confirm delete button
	Then the venue "TestDeleteVenueWithCourse" should not be deleted 
	And a message should be displayed "There are live courses associated with this venue. Please delete these courses or assign a different venue to the courses before deleting the venue"
