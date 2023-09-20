Feature: Sauce

As a user of sauce demo, 
I want to login to the website
So that I can see landing page

@tag1
Scenario: Verify user can sign into sauce demo site with valid login details
	Given I navigate to sauce demo website
	When I enter valid username 
	And I enter valid password
    And I click the login button
    Then landing page should be displayed

	@tag1
	Scenario: Verify user cannot sign into sauce demo site with lockedout login details
	Given I navigate to sauce website
	When I enter lockedout username 
	And I enter locked password
    And I click the log in button
    Then error message should be displayed
