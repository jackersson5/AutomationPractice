
Feature: Registration
	In order to create new account
	As a new user
	I want to be able to register

	Background: 
	Given I am on the Register page

	@JustClickRegister
Scenario: Register without enter required fields
	When I click Register
	Then I should see error message about required fields

	
	@SuccessfulRegister
Scenario Outline: Register with correct details
  When I enter correct details to all required fields with following '<FirstName>','<LastName>','<Email>','<Password>','<AdressFirstName>','<AdressLastName>','<Adress>','<City>','<State>','<Zip>','<Country>','<MobilePhone>','<AliasAdress>'
  And I click Register
  Then My account should be created and I should be redirected to it
   
   Examples: 
   
   
	| FirstName     | LastName       | Email               | Password    | AdressFirstName  | AdressLastName  | Adress           | City       | State       | Zip        | Country       | MobilePhone         |    AliasAdress       |
	| Peter         | Smith          |  testEmail@test.com | 12345       |   Peter          | Parker          | New York adress  |  New York  |  New York   |  12345     |   USA         |    111222333        |      testAliasAdress |  
	 
  

  


