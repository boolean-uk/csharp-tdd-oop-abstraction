# Extension Domain Model 


# User Stories 

1.
As a system administrator, I want my users to have to create a user account with an email address and a password.

2.
I want them to receive an "invalid password" message if they provide a password less than 8 characters in length.

3.
I want them to receive an "invalid email" message if they provide an email address without an @ symbol in it.

4.
I want new accounts to be disabled by default until I manually set them as enabled.

5.
I want users to know if they are able to log in or not based on whether their account is enabled or disabled.


| Classes                | Methods                                                 | Scenario                                                                                   | Expected Output                                                                         |
|------------------------|---------------------------------------------------------|--------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|
| `UserAccount`          | `Constructor(string email, string password)`            | `Creating a UserAccount object with properties.`                                           | `A UserAccount object is created with the specified properties.`                        |
|                        | `EnableAccount()`                                       | `Enabling a UserAccount.`                                                                  | `The specified UserAccount is enabled.`                                                 |
|                        | `DisableAccount()`                                      | `Disabling a UserAccount.`                                                                 | `The specified UserAccount is disabled.`                                                |
|                        | `SetPassword(string password)`                          | `Setting the password of the UserAccount.`                                                 | `The password of the UserAccount is set.`                                               |
|                        | `IsValidEmail(string email)`                            | `Validating the email of the UserAccount.`                                                 | `The email of the UserAccount is validated.`                                            |
|                        | `ValidatePassword(string password)`                     | `Validating the password of the UserAccount.`                                              | `The password of the UserAccount is validated.`                                         |
|                        | `SignIn(string email, string password)`                 | `User signing in.`                                                                         | `The specified user signs in.`                                                          |
