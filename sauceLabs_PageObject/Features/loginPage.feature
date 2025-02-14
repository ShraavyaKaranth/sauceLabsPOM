Feature: SauceLabs Step1: loginPage

A short summary of the feature

@LoginPage
Scenario: User is in the login page and logs in using correct username and password
	Given User is on login page
	When User enters username and password and clicks on login button
	Then User is logged in
