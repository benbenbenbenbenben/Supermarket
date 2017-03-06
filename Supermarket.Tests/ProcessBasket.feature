Feature: ProcessBasket
	
Scenario: Buying an item produces a bill
	Given I buy the following items
	| Item Name             | Price | Item Type |
	| Learning C#           | 20.99 | Book      |
	| Automated Testing 101 | 10.00 | Book      |
	| Cucumber              | 15.99 | Book      |
	When the basket is sent to the checkout
	Then the bill has the following:
	| Item Type    | Item Price |
	| Book         | 20.99      |
	| Book         | 10.00      |
	| Book         | 15.99      |
	| <BLANK LINE> |            |
	| Sub Total:   | 46.98      |
	| Tax:         | 0          |
	| Discount:    | 0          |
	| Total:       | 46.98      |

Scenario: Buying a gizmo produces a bill where the gizmo is taxed 20%
	Given I buy the following items
    | Item Name   | Price | Item Type | Tax Percentage |
    | Learning C# | 20.99 | Book      | 0              |
    | Gizmo       | 10.00 | Gizmo     | 0.20           |
	When the basket is sent to the checkout
	Then the bill has the following:
	| Item Type    | Item Price |
	| Book         | 20.99      |
	| Gizmo        | 10.00      |
	| <BLANK LINE> |            |
	| Sub Total:   | 30.99      |
	| Tax:         | 2.00       |
	| Discount:    | 0          |
	| Total:       | 32.99      |

