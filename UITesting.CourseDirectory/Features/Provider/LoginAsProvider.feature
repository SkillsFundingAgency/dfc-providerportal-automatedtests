Feature: Login As Provider
	In order to Test provider access to course directory
	As a Provider
	I want to test the login functionality

@regression
Scenario: Login as a Provider 
	Given  I have accessed the course directory
	And I have entered valid provider credentials and clicked Login
	Then I should be logged in as Provider
	
