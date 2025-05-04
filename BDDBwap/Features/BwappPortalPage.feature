Feature: PortailPageFeature
@tag2

Scenario: I click on link "Change Password" then i'm redirected on password change page
Given I'm logged on portal page
When I click on link "Change Password"
Then I'm redirected on "bWAPP - Change Password"

Scenario: I click on link "Credits" then i'm redirected on credits page
Given I'm logged on portal page
When I click on link "Credits"
Then I'm redirected on "bWAPP - Credits"

Scenario: I click on link "Create User" then i'm redirected on Create User page
Given I'm logged on portal page
When I click on link "Create User"
Then I'm redirected on "bWAPP - Create User"

Scenario: I click on link "Logout" and confirm alert then i'm redirected on login page
Given I'm logged on portal page
When I click on link "Logout"
And I confirm alert
Then I'm redirected on "bWAPP - Login"

Scenario: I click on link "Logout" and dismiss alert nothing happened
Given I'm logged on portal page
When I click on link "Logout"
And I dismiss alert
Then I'm logged on portal page

Scenario: I click on link "Reset" and confirm alert then i'm redirected on reset page
Given I'm logged on portal page
When I click on link "Reset"
And I confirm alert
Then I'm redirected on "bWAPP - Reset"
And I get a message "The application has been reset!"

Scenario: I select a high security level and click on set submit then security level is set to high
Given I'm logged on portal page
When I select option "high" on "security_level" selection
And I click on button named "form_security_level"
Then I get a message "Current: high"