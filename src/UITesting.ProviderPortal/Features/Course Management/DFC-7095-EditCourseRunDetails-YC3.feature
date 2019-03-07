Feature: DFC-7095-EditCourseRunDetails-YC3
	In order to edit a course run
	As a provider
	I want to be able to select edit course details and change course data

Background: 
Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in
	Given I have searched for UKPRN "10002815" and clicked search
	When I click to view my courses
	And I selected a Course and a course run
	And I have clicked Edit Course Details 
	Then Edit Course details screen should be displayed
@CI
Scenario: Edit Course Name with valid data
	Given I have accessed the selected course run data
	And I have entered the following course name "Award in Computerised Accounts-Edited"
	When I  Save the data
	Then the course run should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data
@CI
Scenario: Edit Course Name with blank data
	Given I have accessed the selected course run data
	And I have entered the following course name " "
	When I  Save the data
	Then the following course name message should be displayed "Enter course name"
Scenario: Edit course run with valid defined start date when Classroom mode is selected
	Given I have accessed the selected course run data
	And I have selected "Classroom" as delivery mode
	And I have entered "25" in Day, "09" in Month and "2019" in Year
	When I  Save the data
	Then the date should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data	
Scenario: Edit course run with invalid defined start date when Classroom mode is selected
	Given I have accessed the selected course run data
	And I have selected "Classroom" as delivery mode
	And I have entered "31" in Day, "02" in Month and "2019" in Year
	When I  Save the data
	Then the following error date message should be displayed "Invalid date"
Scenario: Edit course run with no defined start date when Classroom mode is selected
	Given I have accessed the selected course run data
	And I have selected "Classroom" as delivery mode
	And I have entered " " in Day, " " in Month and " " in Year
	When I Save the data
	Then the following error date message should be displayed "Enter start date"
Scenario: Edit course run by selecting classrroom mode and a venue is selected
	Given I have accessed the selected course run data
	And I have selected "Classroom" as delivery mode
	And I have entered selected a venue from the dropdown
	When I  Save the data
	Then the course run should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data with the new venue
Scenario: Edit course run by entering a value in cost and leave cost description blank
	Given I have accessed the selected course run data
	And I have selected entered a value in cost "200"
	And I have left cost description as blank
	When I  Save the data 
	Then the course run should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data with the cost
Scenario: Edit course run by entering a value in cost description and leave cost blank
	Given I have accessed the selected course run data
	And I have entered a value in cost description "Please call for course cost"
	And I have left cost description as blank
	When I  Save the data
	Then the course run should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data with the cost description
Scenario: Edit course run by leaving cost description and leave cost blank
	Given I have accessed the selected course run data
	And I have left cost and cost description as blank
	And I have left cost description as blank
	When I  Save the data 
	Then the following cost message should be displayed "Enter cost or cost description"
Scenario: Edit course run with duration
	Given I have accessed the selected course run data
	And I have entered a value in Duration "6"
	And I have selected "Years" in the duration unit
	When I  Save the data
	When I click the link to the changed course run
	Then I should be able to view the changed data with the duration
Scenario: Edit course run with blank duration
	Given I have accessed the selected course run data
	And I have entered a blank value in Duration " "
	When I  Save the data
	Then the following duration message should be displayed "Enter Duration"
Scenario: Edit course run by selecting part time and Evening
	Given I have accessed the selected course run data
	And I have selected "Part-Time" in attendance pattern 
	And I have selected "Weekend" in Attendance
	When I Save the data
	Then the course run should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data with the attendance pattern and attendance
Scenario: Edit course with Online and a valid URL
	Given I have accessed the selected course run data
	And I have selected "Online" as delivery mode
	And I have entered following URL "http://www.ips-apprenticeships.co.uk/"
	When I  Save the data
	Then the course run should be saved and the changed course run link should be visible
	When I click the link to the changed course run
	Then I should be able to view the changed data with the Url
Scenario: Edit course with Online and a invalid URL
	Given I have accessed the selected course run data
	And I have selected "Online" as delivery mode
	And I have entered following URL "http://www.ips-apprenticeships"
	When I  Save the data
	Then the following URL message should be displayed "The format of URL is incorrect"
Scenario: No chnages should be done once cancel is clicked
	Given I have accessed the selected course run data
	And I have selected "Online" as delivery mode
	And I have selected "Full-Time" as attendance pattern
	When I Click Cancel
	Then changes should not be saved
