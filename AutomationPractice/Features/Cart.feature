Feature: Cart
  In order to use a cart
  As an application user
  I want to be able to add and remove products from it

Background: 
Given I am on Product page

    Scenario: Adding a product to the cart
      When I add product to cart
      Then The Product is added to cart

    Scenario: Removing a product from the cart in the cart view
      Given The product is on the cart
      When I remove product on the cart view
      Then The product is removed from the cart

	  Scenario: Entering an empty cart
      When I enter the cart
      Then Information about empty cart appears

	  Scenario: Continue shopping after adding the product to the basket
      Given I add product to cart
      When I press Continue shopping 
      Then I am redirected to Product page

	  Scenario: Proceed to checkout after adding the product to the basket
      Given I add product to cart
      When I press Proceed to checkout
	  Then I am redirected to shopping cart summary
	  