Feature: Order

As a sauce demo site user
I want to put some items into the basket
So that I can count them

@tag1
 Scenario: Verify User Can Add and Remove Items from Basket
    Given I navigate to demo site
    When I add 3 items to the basket
    Then I should see 3 items in the basket
    When I remove 1 item from the basket
    Then I should see 2 items in the basket
