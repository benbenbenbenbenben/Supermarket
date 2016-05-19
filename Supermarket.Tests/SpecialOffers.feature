Feature: SpecialOffers
	As a major supermarket
	In order to attract more customers
	I want to promote multisaver deals

Scenario: Buying three apples on multisaver deal
	Given I buy 3 apples at £1 each
	And for every 3 apples there is a discount of £0.50
	When I need to make payment
	Then the total is £2.5

Scenario: Buying ten apples on multisaver deal
	Given I buy 10 apples at £1 each
	And for every 3 apples there is a discount of £0.50
	When I need to make payment
	Then the total is £8.50

Scenario: Buying two apples on multisaver deal
	Given I buy 2 apples at £1 each
	And for every 3 apples there is a discount of £0.50
	When I need to make payment
	Then the total is £2