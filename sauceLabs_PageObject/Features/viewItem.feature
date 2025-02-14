Feature: SauceLabs Step2: viewItem

A short summary of the feature

@ViewItem
Scenario: User is logged in and views an item
	Given User is logged in
	When User views an item
	Then Item data is displayed
