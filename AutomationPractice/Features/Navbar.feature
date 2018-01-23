Feature: Navbar

    In order to quickly navigate to diffrent places
	As an application user
	I want to be able to move by navbar

 

  Scenario: Navigation to the Women page using navbar
    Given I am on Authentication page
    When I click Woman 
    Then I should be redirected to Woman page

  Scenario: Navigation to the Tops page using navbar
    Given I am on Homepage
    When I mouse over Woman and click Tops
    Then I should be redirected to Tops page

  Scenario: Navigation to the T-shirts page using navbar
    Given I am on Women page
	When I mouse over Woman and click t-shirts 
    Then I should be redirected to Tshirts page
	 
  Scenario: Navigation to the Blouses page using navbar
    Given I am on Homepage
	When I mouse over Woman and click Blouses
    Then I should be redirected to Blouses page

  Scenario: Navigation to the Dresses page using navbar
    Given I am on Casual Dresses page
    When I click Dresses 
    Then I should be redirected to Dresses page

  Scenario: Navigation to the Casual Dresses page using navbar
    Given I am on Homepage
	When I mouse over Dresses and click Casual dresses
    Then I should be redirected to Casual Dresses page

  Scenario: Navigation to the Evening Dresses page using navbar
    Given I am on Homepage
    When I mouse over Dresses and click Evening dresses
    Then I should be redirected to Evening Dresses page

  Scenario: Navigation to the Summer Dresses page using navbar
    Given I am on Contact page
    When I mouse over Dresses and click Summer dresses
    Then I should be redirected to Summer Dresses page