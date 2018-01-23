Feature: Sign In
	In order to access my account
	As an application user
	I want to be able to Sign In in and Sign Out

	Background: 
	Given I'm on Authentication page

	@LoginProperly
	Scenario Outline: Sign in with correct Email adress and Password
	When I enter email '<email>' and password '<password>'
	And I click Sign In 
	Then I should be logged into my account

	Examples: 

	|      email                         |  password  |
	| darengibson@automationpractice.com |   11111    |
	| gregorysmith@automationpractice.com|   54321    |

	@LogOut
	Scenario Outline: Sign out from the account
	Given I am logged in with email '<email>' and password '<password>'
	When I click Sign out
	Then I should be logged out

	Examples: 

	|      email                          |  password  |
	| darengibson@automationpractice.com  |   11111    |
	
	@InvalidPassword
	Scenario Outline: Sign in with correct Email adress and invalid Password
	When I enter email '<email>' and password '<password>'
	And I click Sign In
	Then I should see "Authentication failed."

	Examples: 

	|      email                         |  password  |
	| darengibson@automationpractice.com |   111112   |
	
	@InvalidEmail
Scenario Outline: Sign in with invalid Email adress and correct Password
	When I enter email '<email>' and password '<password>'
	And I click Sign In
	Then I should see "Invalid email address."

	Examples: 

	|      email                                   |  password  |
	| darengibsonautomationpractice.com  |   11111   |
	

	
	@JustSignIn
Scenario: Sign in without enter any credentials
	When I click Sign In
	Then I should see "An email address required."


	

