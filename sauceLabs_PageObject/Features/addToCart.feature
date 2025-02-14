Feature: SauceLabs Step3: addToCart

A short summary of the feature

@AddToCart
Scenario: User is viewing an item
	Given User is viewing an item
	When User adds item to cart and clicks on cart button
	Then Cart will be opened
