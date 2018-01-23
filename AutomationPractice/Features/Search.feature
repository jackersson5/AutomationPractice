Feature: Search
	In order to quickly find products
	As an application user
	I want to find a product by their name

	Background: 

	Given I am on Home page

Scenario Outline: Searching for an existing product

	When I enter a '<product name>'
	And I click the search icon
	Then List of products should be visible

	Examples: 

	| product name |
	| Blouse       |


Scenario Outline: Searching for non existing product

	When I enter a '<productName>'
	And  I click the search icon
	Then No product should be found

	Examples: 

	|        productName             |
	|   noExistingProductName        |

	
Scenario: Searching without entering product name

	When I click the search icon
	Then No product should be found
	
	
