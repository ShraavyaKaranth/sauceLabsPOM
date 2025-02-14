Feature: SauceLabs Step7: ConfirmationPage

A short summary of the feature

@ConfirmationPage
Scenario: User is on confirmation page and checks for the confirmation text
	Given User is in the confirmation page
	When User checks for confirmation text and compares it with actual text
	Then If it matches, the test case passes. Else it fails.
