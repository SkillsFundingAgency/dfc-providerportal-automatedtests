﻿Feature: DFC-6716 Bulk Upload
	In order to update my Courses
	As a provider
	I want to be able to be able to use the Bulk Upload functionality

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in


@CI
Scenario: DFC-6737 Bulk Upload No Errors
	Given I have searched for UKPRN "10037355" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_Valid.csv to upload
	And I click Upload File leading to no course errors
	Then I am on the Publish your courses page
	When I click publish to publish upload courses
	Then I am on the courses published page

@CI
Scenario: DFC-6738 Bulk Upload Pass Stage 1
	Given I have searched for UKPRN "10036802" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_InvalidDuration.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-6738 Bulk Upload File Not CSV
	Given I have searched for UKPRN "10036802" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUploadNotCSV.txt to upload
	And I click Upload File leading to stage1 errors
	Then the error The selected file must be a csv is displayed

@CI
Scenario: DFC-6738 Bulk Upload File Empty
	Given I have searched for UKPRN "10036802" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_Empty.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error The selected file is empty is displayed in error summary

@CI
Scenario: DFC-6738 Bulk Upload Missing Columns
	Given I have searched for UKPRN "10036802" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_MissingColumns.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error Fields with names 'COURSE_NAME', 'DURATION', 'WHAT_YOU_WILL_LEARN' do not exist is displayed in error summary

@CI
Scenario: DFC-7379 Invalid LARS
	Given I have searched for UKPRN "10036802" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_InvalidLARS.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error Line 2, LARS_QAN = 60333079 invalid LARS is displayed in error summary

@CI
Scenario: DFC-7379 Expired LARS
	Given I have searched for UKPRN "10036802" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_ExpiredLARS.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error Line 2, LARS_QAN = 60079472 expired LARS is displayed in error summary

@CI
Scenario: DFC-7379 Missing LARS
	Given I have searched for UKPRN "10036802" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_MissingLARS.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error Line 2, LARS_QAN = => LARS is missing. is displayed in error summary

@CI
Scenario: DFC-7224 Bulk Upload Cancel Course Edit
	Given I have searched for UKPRN "10036790" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_CancelTest.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course
	Then I click on Cancel to cancel edit
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-7224 Bulk Upload Cancel Course Run Edit
	Given I have searched for UKPRN "10036790" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_CancelTest.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course Run
	Then I click on Cancel to cancel edit course run
	Then I am on the Fix and publish bulk upload page


@CI
Scenario: DFC-7224 Bulk Upload Save Course Edit
	Given I have searched for UKPRN "10036789" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_SaveTest.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course i want edit and save
	And I edit bulk upload course description Semi-qualified (people)
	And I click to Save the Course details
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-7225 Bulk Upload Save Course Run Edit
	Given I have searched for UKPRN "10036789" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_SaveTest.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course Run i want edit and save
	And I edit bulk upload course cost 9
	And I click to Save the Course Run details
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-6719 Bulk Upload Edit Course
	Given I have searched for UKPRN "10036789" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_EditTest.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course i want edit and save
	And I edit bulk upload course description Semi-qualified (people)
	And I edit bulk upload course entry requirements None Specified
	And I click to Save the Course details
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-6736 Bulk Upload Edit Course Run
	Given I have searched for UKPRN "10036789" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_EditTest.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course Run i want edit and save
	And I edit bulk upload course name Test Course 100
	And I edit bulk upload course cost 9
	And I click to Save the Course Run details
	Then I am on the Fix and publish bulk upload page

#	10036789