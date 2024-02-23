Feature: Calculator
    In order to perform mathematical operations
    As a user
    I want to use a calculator

Scenario: Add two numbers
    Given I have entered 50 into the calculator
    And I have entered 70 into the calculator
    When I press add
    Then the result should be 120 on the screen
