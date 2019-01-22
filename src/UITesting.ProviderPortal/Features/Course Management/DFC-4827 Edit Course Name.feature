Feature: DFC-4827 Edit Course Name
	In order to be able to change the course details
	As a Provider
	I want to be able to change the course name

Background:
	Given I have logged to course directory as a provider
	And I have searched for UKPRN "10002815" and clicked search
	And I have clicked View Courses button
	Then I want to view my courses
@CI
Scenario: Edit Course Name with valid data
	Given I have searched for a Qualification "QCF Units"
	And I have searched for a course name "Forensic Detection"
	And I have searched for a course runs with a course name "Forensic Detection"
	And I have changed the course name from "Forensic Detection" to "Forensic Detection 001"
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the new course name should be saved as "Forensic Detection 001"
	
@CI
Scenario: Edit Course Name with null data
	Given I have searched for a Qualification "NVQ/GNVQ Key Skills Unit"
	And I have searched for a course name "Key Skills in Application of Number - level 3"
	And I have searched for a course runs with a course name "Key Skills in Application of Number - level 3"
	And I have changed the course name from "Key Skills in Application of Number - level 3" to ""
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the Error message should be displayed "Enter Course Name"
@CI
Scenario: Edit Course Name with 255 characters
	Given I have searched for a Qualification "BSc"
	And I have searched for a course name "BSc (Hons) in Biological Science - Teeside Univeristy"
	And I have searched for a course runs with a course name "BSc (Hons) in Biological Science - Teeside Univeristy - Testing1"
	And I have changed the course name from "BSc (Hons) in Biological Science - Teeside Univeristy - Testing1" to "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV"
	Then Save , Discard and preview buttons should be visible 
	When I Click Save
	Then the new course name should be saved as "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUV"
@CI
Scenario: Edit Course Name with more than 255 characters
	Given I have searched for a Qualification "GCE A level"
	And I have searched for a course name "GCE A Level in Biology"
	And I have searched for a course runs with a course name "GCE A Level in Biology - Testing2"
	And I have changed the course name from "GCE A Level in Biology - Testing2" to "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVB"
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the Error message should be displayed "The maximum length of Course Name is 255 characters"
@CI
Scenario: Edit Course Name with non-ascii characters
	Given I have searched for a Qualification "GCE A level"
	And I have searched for a course name "GCE A Level in Biology"
	And I have searched for a course runs with a course name "GCE A Level in Biology - Testing2"
	And I have changed the course name from "GCE A Level in Biology - Testing2" to "GCEЕлизавета A Level in Biology - Testing"
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the Error message should be displayed "Course Name contains invalid characters"
@CI
Scenario: Edit Course Name with trailing and leading spaces
	Given I have searched for a Qualification "GCE A level"
	And I have searched for a course name "GCE A Level in Biology"
	And I have searched for a course runs with a course name "GCE A Level in Biology - Testing2"
	And I have changed the course name from "GCE A Level in Biology - Testing2" to " GCE A Level in Biology - Testing3 "
	Then Save , Discard and preview buttons should be visible
	When I Click Save
	Then the course name should be saved without leading or trailing spaces as "GCE A Level in Biology - Testing3"