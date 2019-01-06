Feature: DFC-6183 View Course - Description
As a Provider
I need to view the Course Description
so that I can review the course description content that was added when the course was created

Background:
	Given I have logged into course directory as a provider
	And I have navigated to the Your-Courses Page
	And accordion of courses is maximised

@mytag
Scenario: View description of the first diploma course encountered
	Given I have clicked on 'view course description'
	Then course description pop-up opens
	And qualification title is shown
	And Who is the course for is shown
	And Entry requirements are shown
	And What you’ll learn is shown
	And What you'll need to bring is shown
	And How you'll be assessed is shown
	And Where next? is shown
	When I click close 'view course description' pop-up button 
	Then course description pop-up is no longer visible
