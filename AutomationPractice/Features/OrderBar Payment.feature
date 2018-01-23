Feature: OrderBar Payment
	In order to pay for my order
	As an application user
	I want to be able to pay by bank wire or check

	Background: 
	Given I am on Payment window

Scenario: Pay by bank wire
	When I choose pay by bank wire
	And I confirm my order
	Then Payment by bank wire confirmation should appear

	Scenario: Pay by check
	When I choose pay by check
	And I confirm my order
	Then Payment by check confirmation should appear