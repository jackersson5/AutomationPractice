Feature: Forgot password
As an application user 
If I forget password
I want to be able to generate new one

Background: 
Given I am on Forgot Password page

@positive
Scenario Outline: Request new password with valid email adress

  Given I enter email '<email>' adress
  When I click Retrieve Password
  Then Confirmation message "A confirmation email has been sent to your address" + here your Adress appear 

  Examples: 

	|             email					  |
	|  darengibson@automationpractice.com | 

@forgot-negative
Scenario Outline: Request new password with a non-existent email adress
  Given I enter email '<email>' adress
  When I click Retrieve Password
  Then Email validation "There is no account registered for this email address." appears 

  Examples: 

	| email                             |
	| noExistingEmail@automPractice.com |


  @forgot-negative2
Scenario: Request new password without email
  
  When I click Retrieve Password
  Then Email validation "Invalid email address." appears
  

  