Feature: SauceLabs Step6: checoutOverview

A short summary of the feature

@CheckoutOverview
Scenario: User is in checkout overview page and he clicks on finish
	Given User is in checkout overview page
	When User scrolls down and clicks on finish
	Then Confirmation page will be appeared
