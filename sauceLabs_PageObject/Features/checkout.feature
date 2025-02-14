Feature: SauceLabs Step4: checkout

A short summary of the feature

@Checkout
Scenario: Cart is opened and user tries to checkout
	Given The cart is opened
	When User clicks on checkout button
	Then checkout page will be opened
