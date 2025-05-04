Feature: ChangePasswordPageFeature
@tag3

Scenario: I fill inputs with right values and click on Change then i get a confirmation message
Given I'm logged on portal page
And I click on link "Change Password"
And I'm on change password page
When I fill inputs current_password with "bug" and new_password with "another" and re_type_password with "another"
And I click on button named "action"
Then I get a message "The password has been changed!"
And I'm on change password page

Scenario: I fill inputs with not matched password and click on Change then i get an error message
Given I'm logged on portal page
And I click on link "Change Password"
And I'm on change password page
When I fill inputs current_password with "bug" and new_password with "another" and re_type_password with "not same"
And I click on button named "action"
Then I get a message "The passwords don't match!"
And I'm on change password page

Scenario: I fill inputs with wrong current password and click on Change then i get an error message
Given I'm logged on portal page
And I click on link "Change Password"
And I'm on change password page
When I fill inputs current_password with "fix" and new_password with "another" and re_type_password with "another"
And I click on button named "action"
Then I get a message "The current password is not valid!"
And I'm on change password page

