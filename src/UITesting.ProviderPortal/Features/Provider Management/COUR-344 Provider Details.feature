Feature: COUR-344 Provider Details
	As a Provider Super User
	I need to view my provider details
	so that I can check that these are correct

Background:
	Given I have accessed course directory as a provider
#	And I login as provider admin with Provider.10033145@gmail.com and SITtesting123
	And I login as provider admin with ncscoursedirectoryprovsuper5@guerrillamail.com and Password1!!!
	Then I am logged in as a provider

@CI
Scenario: COUR-493 View Provider Details
	When I click on the Provider name in the header
	Then I am taken to the provider details page

@CI
Scenario: COUR-496 Add Provider Details - Alias
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter alias Test Alias
	And I click Save on Add provider details page

@CI
Scenario: COUR-496 Add Provider Details - Alias Max Chars
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter alias ALL TRAINING TAKES PLACE 1N THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND
	And I click Save on Add provider details page

@CI
Scenario: COUR-496 Add Provider Details - Alias Special Chars
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter alias 1234567890-= !"£$%^&*()_+{}:'#;@~/.,?> < ABCDEFGHIJKLMNOPQRSTUVWXYZ
	And I click Save on Add provider details page

@CI
Scenario: COUR-496 Add Provider Details - Alias Over Max Chars
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter alias ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND.
	And I click Save on Add provider details page leading to error

@CI
Scenario: COUR-496 Add Provider Details - Alias Non ASCII
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter alias 我想输入文字
	And I click Save on Add provider details page leading to error

@CI
Scenario: COUR-496 Add Provider Details - Overview
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter overview Provider Overview Testing
	And I click Save on Add provider details page

@CI
Scenario: COUR-496 Add Provider Details - Overview Max Chars
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter overview ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES ALL TRAINING TAKES PLAC
	And I click Save on Add provider details page

@CI
Scenario: COUR-496 Add Provider Details - Overview Special Chars
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter overview 1234567890-= !"£$%^&*()_+{}:'#;@~/.,?> < ABCDEFGHIJKLMNOPQRSTUVWXYZ
	And I click Save on Add provider details page

@CI
Scenario: COUR-496 Add Provider Details - Overview Over Max Chars
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter overview ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES ALL TRAINING TAKES PLACE
	And I click Save on Add provider details page leading to error

@CI
Scenario: COUR-496 Add Provider Details - Overview Non ASCII
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click add alias
	Then I enter overview 我想输入文字
	And I click Save on Add provider details page leading to error

@CI
Scenario: COUR-497 Edit Provider Details - Alias
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click edit alias
	Then I edit alias Test Alias
	And I click Save on Edit provider details page

@CI
Scenario: COUR-497 Edit Provider Details - Overview
	When I click on the Provider name in the header
	Then I am taken to the provider details page
	When i click edit alias
	Then I edit overview Provider Overview Testing
	And I click Save on Edit provider details page