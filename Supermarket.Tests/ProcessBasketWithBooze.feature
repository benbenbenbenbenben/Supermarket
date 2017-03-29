Feature: ProcessBasketWithBooze
	In order to ensure that we don't sell alcohol to underage people
	As a supermarket cashier
	I want to be alerted when someone scans an item containing alcohol

@mytag
Scenario: Buying booze triggers flashing red light
	Given I'm going to buy a bottle of Chateau Neuf du Pape
	When I scan the bottle
	Then the light above the check-out should flash

Scenario: Buying milk does not trigger flashing red light
	Given I'm going to buy a bottle of milk
	When I scan the bottle
	Then the light above the check-out should not flash

Scenario: Buying scratchcard does trigger flashing red light
	Given I'm going to buy a scratchcard
	When I scan the barcode
	Then the light above the check-out should flash