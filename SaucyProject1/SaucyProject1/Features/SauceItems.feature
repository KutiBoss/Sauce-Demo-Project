Feature: SauceItems

As a sauce demo site user
I want to see homepage
So that I can view available items

@tag1
Scenario: Verify User Can Sign into Sauce Demo Site and See Items
	Given I navigate to demo website
    Then I should see 6 items listed on the page

	@tag1
	Scenario: Verify User Can Sort Items on Sauce Demo Site 
	Given I navigate to demo order website
	And I click sorting dropdown tab
	And I click on low to high price tab
    Then I should see sauce labs onesie displayed
	Then the first item should have the lowest price
    And the last item should have the highest price

	