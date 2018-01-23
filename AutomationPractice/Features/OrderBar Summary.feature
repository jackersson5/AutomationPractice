Feature: OrderBar Summary
	In order to make sure that my cart contains what I need
	As an application user
	I want to be able to edit the cart on the summary screen
	
	Background: 
	Given I am on the summary screen and the cart contains some product

Scenario: Product removal
	When I remove the product
	Then the product is removed from the cart

	Scenario: Adding a product
	When I add product
	Then The product should be added

	Scenario: Subtraction of the product
	When I subtract product
	Then The product should be subtracted
