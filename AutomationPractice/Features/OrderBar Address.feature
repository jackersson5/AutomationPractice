Feature: OrderBar Address
	In order to change my address details before payment 
	As an application user
	I want to be able to update my address data and back to order page

Background: 

Given I am on adress window being logged in

Scenario: Update delivery address
	When I click Update delivery address
	And I change city name
	And I click Save
	Then City name should be updated
	And I should back on address window

	Scenario: Update billing address 
	When I press Update billing address
	And I change Address
	And I click Save
	Then Address name should be updated
	And I should back on address window
