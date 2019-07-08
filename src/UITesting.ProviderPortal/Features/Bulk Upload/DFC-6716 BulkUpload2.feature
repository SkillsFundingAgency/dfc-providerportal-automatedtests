Feature: DFC-6716 Bulk Upload 2
	In order to update my Courses
	As a provider
	I want to be able to be able to use the Bulk Upload functionality


@CI
Scenario: DFC-7224 Bulk Upload Cancel Course Edit
	Given I have accessed course directory as a provider
	And I login as provider admin with ncscoursedirectoryprovsuper1@guerrillamail.com  and Password1!!!
	Then I am logged in as a provider
	Given I have accessed the Bulk Upload fixes page
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course i want edit and save
	Then I click on Cancel to cancel edit
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-7224 Bulk Upload Cancel Course Run Edit
	Given I have accessed course directory as a provider
	And I login as provider admin with ncscoursedirectoryprovsuper1@guerrillamail.com  and Password1!!!
	Then I am logged in as a provider
	Given I have accessed the Bulk Upload fixes page
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course Run i want edit and save
	Then I click on Cancel to cancel edit course run
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-6719 Bulk Upload Edit uploaded Course
	Given I have accessed course directory as a provider
	And I login as provider admin with ncscoursedirectoryprovsuper1@guerrillamail.com  and Password1!!!
	Then I am logged in as a provider
	Given I have accessed the Bulk Upload fixes page
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course i want edit and save
	And I edit bulk upload course description Semi-qualified (people)
	Then I click on Cancel to cancel edit
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-6736 Bulk Upload Edit uploaded Course Run
	Given I have accessed course directory as a provider
	And I login as provider admin with ncscoursedirectoryprovsuper1@guerrillamail.com  and Password1!!!
	Then I am logged in as a provider
	Given I have accessed the Bulk Upload fixes page
	Then I am on the Fix and publish bulk upload page
	When I click fix against the first Course Run i want edit and save
	When I edit bulk upload course cost 9
	Then I click on Cancel to cancel edit course run
	Then I am on the Fix and publish bulk upload page

@CI
Scenario: DFC-7224 Bulk Upload Save Course Edit
	Given I have accessed course directory as a provider
	And I login as provider admin with ncscoursedirectoryprovsuper5@guerrillamail.com  and Password1!!!
	Then I am logged in as a provider
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_SaveTest.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page for a new file upload
	When I click fix against the first Course i want edit and save
	And I edit bulk upload course description Semi-qualified (people)
	And I click to Save the Course details
	Then I am on the Publish your courses page
	When I click publish to publish upload courses
	Then I am on the courses published page

@CI
Scenario: DFC-7225 Bulk Upload Save Course Run Edit
	Given I have accessed course directory as a provider
	And I login as provider admin with ncscoursedirectoryprovsuper5@guerrillamail.com  and Password1!!!
	Then I am logged in as a provider
	Given I have accessed the Bulk Upload page
	When I click Choose a File BulkUpload_SaveTest2.csv to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page for a new file upload
	When I click fix against the first Course i want edit and save
	When I edit bulk upload course cost 9
	And I click to Save the Course Run details
	Then I am on the Publish your courses page
	When I click publish to publish upload courses
	Then I am on the courses published page

@CI
Scenario Outline: COUR-765 Field Validations
	Given I have accessed course directory as a provider
	And I login as provider admin with ncscoursedirectoryprovsuper3@guerrillamail.com  and Password1!!!
	Then I am logged in as a provider
	Given I have accessed the Bulk Upload page
	When I click Choose a File <file> to upload
	And I click Upload File leading to course errors
	Then I am on the Fix and publish bulk upload page for a new file upload
	#uncomment once working in SIT
	#Given I have accessed the Bulk Upload delete file page
	#When I click delete bulk upload file
	#Then I am on Bulk Upload file deleted page

Examples: 
| file                                 |
| BulkUpload_AttendancePatternNone.csv |
| BulkUpload_CostformatInvalid.csv     |
| BulkUpload_CostorCostDescNone.csv    |
| BulkUpload_DurationInvalid.csv       |
| BulkUpload_URLInvalid.csv            |
| BulkUpload_StartDateDDInvalid.csv    |
| BulkUpload_StartDatePast.csv         |
| BulkUpload_StartDateFuture.csv       |
| BulkUpload_NoStudyMode.csv           |
| BulkUpload_attendancemissing.csv     |
| BulkUpload_DateNone.csv              |
| BulkUpload_DeliveryModeNone.csv      |