Feature: Contact
	In order to contact with customer service
	As an application user
	I want to send a message to them

Background: 
Given I am on Contact us page

@positive
Scenario Outline: Sending empty message with valid email adress

  When I enter email '<email>' and subjectHeading '<subjectHeading>'
  And I click Send
  Then Message validation "The message cannot be blank." appears

  Examples: 

	| email                              | subjectHeading   | 
	| darengibson@automationpractice.com | Customer service |       

	
Scenario Outline: Sending message with invalid/empty email adress

When I enter email '<email>' and message '<message>'
And I click Send
Then Email adress validation "Invalid email address." appears

Examples: 

| email				  | message     | 
|    testgmail.com    |    test     |   

Scenario Outline: Sending message without choose Subject Heading

When I enter email '<email>' and message '<message>'
And I click Send
Then Subject heading validation "Please select a subject from the list provided." appears

Examples: 

| email                                   | message     | 									  
|   darengibson@automationpractice.com    |  test       | 


Scenario Outline: Sending message with valid required credentials

When I enter email, subjectHeading and message '<email>','<subjectHeading>', '<message>'
And I click Send
Then Successful message "Your message has been successfully sent to our team." appears

Examples: 

| email                              | subjectHeading   | message | 
| darengibson@automationpractice.com | Customer Service | test    | 

Scenario Outline: Autocompleting email adress field by email adress from login

When I Sign In using '<signInEmailAdress>' and '<password>'
And I click Contact Us
Then The email adress field should be filled with email address from sign in

Examples: 

| signInEmailAdress                   | password | 
| darengibson@automationpractice.com  | 11111    |  