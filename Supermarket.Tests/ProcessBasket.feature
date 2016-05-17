Feature: ProcessBasket
	
Scenario: Buying an item produces a bill
	Given I buy the following books
	| Item Name             | Price |
	| Learning C#           | 20.99 |
	| Automated Testing 101 | 10.00 |
	When the basket is sent to the checkout
	Then the bill shows the following
	| Item Type    | Item Price |
	| Book         | 20.99      |
	| Book         | 10.00      |
	| <BLANK LINE> |            |
	| Sub Total:   | 30.99      |
	| Tax:         | 0          |
	| Discount:    | 0          |
	| Total:       | 30.99      |
