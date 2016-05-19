Feature: SpecialOffers
	As a major supermarket
	In order to attract more customers
	I want to promote multisaver deals

Scenario: Buying apples on multisaver deal
	Given I buy 3 apples at £1 pound each
	And for every 3 apples there is a discount of £0.50
	When I need to make payment
	Then the total is £2.5