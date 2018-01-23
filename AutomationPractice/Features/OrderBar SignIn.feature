Feature: OrderBar SignIn
	In order to continue payment
	As an user which is logged out
	I want to be able to sign in now or create new account

Background: 

Given I am on Sign In window being not logged in

Scenario Outline: Sign in with correct Email adress and Password
	When I enter valid email '<email>' and password '<password>'
	And I Click Sign In
	Then I should be on Address window

	Examples: 

	|      email                           |  password  |
	|  darengibson@automationpractice.com  |   11111    |
	
