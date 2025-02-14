Feature: sauceLabs

A short summary of the feature

@tag1
Scenario: User adds item to cart
	Given User is on the login page
	When User enters username and password and logs in
	And Views an item
	And Adds item to cart
	And Opens cart
	Then Item added to cart shows up
@tag1
Scenario: User checks out cart item
	Given User is viewing items in the cart
	When User clicks checkout
	And User enters firstname, lastname and postal code
	And User clicks on continue
	And OUser clicks on finish
	Then Order confirmation page shows up
