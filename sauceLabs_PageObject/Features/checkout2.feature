Feature: SauceLabs Step5: checkout2

A short summary of the feature

@Checkout2
Scenario: User enters information required for check out
	Given user is in check out page
	When User enters firstname, lastname and postalcode and clicks on continue button
	Then User is navigated to checkout overview page
