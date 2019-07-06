Feature: DFC-6716 Bulk Upload
	In order to update my Courses
	As a provider
	I want to be able to be able to use the Bulk Upload functionality

Background:
	Given I have accessed course directory as a provider
	And I login as admin with user and password
	Then I am logged in


@CI
Scenario: DFC-6737 Bulk Upload Status of upload Courses - No Errors
	Given I have searched for UKPRN "10037355" and clicked search
	When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_Valid.csv to upload
	And I click Upload File leading to no course errors
	Then I am on the Publish your courses page
	When I click publish to publish upload courses
	Then I am on the courses published page

@CI
Scenario: DFC-7272 Bulk Upload Status of upload Courses - Errors
	Given I have searched for UKPRN "10036802" and clicked search
	#When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_AttendancePatternNone.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-6738 Bulk Upload Stage 1 - Pass
	Given I have searched for UKPRN "10036802" and clicked search
	#When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_AttendancePatternNone.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-6738 Bulk Upload Stage 1 - File Not CSV
	Given I have searched for UKPRN "10036802" and clicked search
	#When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUploadNotCSV.txt to upload
	And I click Upload File leading to stage1 errors
	Then the error The selected file must be a csv is displayed
@CI
Scenario: DFC-6738 Bulk Upload Stage 1 - File Empty
	Given I have searched for UKPRN "10036802" and clicked search
	#When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_Empty.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error The selected file is empty is displayed in error summary

@CI
Scenario: DFC-6738 Bulk Upload Stage 1 - Missing Columns
	Given I have searched for UKPRN "10036802" and clicked search
	#When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_MissingColumns.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error Fields with names 'COURSE_NAME', 'DURATION', 'WHAT_YOU_WILL_LEARN' do not exist is displayed in error summary

@CI
Scenario: DFC-7379 Bulk Upload LARS Checks - Invalid LARS BUG COUR-1134
	Given I have searched for UKPRN "10036802" and clicked search
	#When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_LARSInvalid.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error Line 2, LARS_QAN = 60333079, invalid LARS is displayed in error summary

@CI
Scenario: DFC-7379 Bulk Upload LARS Checks - Expired LARS
	Given I have searched for UKPRN "10036802" and clicked search
	#When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_LARSExpired.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error Line 2, LARS_QAN = 50084914 expired LARS is displayed in error summary

@CI
Scenario: DFC-7379 Bulk Upload LARS Checks - Missing LARS
	Given I have searched for UKPRN "10036802" and clicked search
	#When I click to view my courses
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_LARSMissing.csv to upload
	And I click Upload File leading to stage1 errors
	Then the error Line 2, LARS_QAN = => LARS is missing. is displayed in error summary
