Feature: LoginPageFeature
@tag1

Scenario: I fill inputs and click on login then i'm on portal page
Given I'm on login page
When I fill inputs login with "bee" and password with "bug"
And I click on button "submit"
Then I'm redirected on "bWAPP - Portal"

Scenario: I fill inputs with wrong values and click on login then i get an error message
Given I'm on login page
When I fill inputs login with "wasp" and password with "another"
And I click on button "submit"
Then I get a message "Invalid credentials or user not activated!"
And I'm on login page