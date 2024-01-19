```
As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
```
| Classes | Methods                    | Function                                 | Scenario            | Output              |
|---------|----------------------------|------------------------------------------|---------------------|---------------------|
| System  | createUser(string, string) | Creates a user in the system             | Creates account     | User                |
|         |                            |                                          | Invalid Password    | Change errorMessage |
|         |                            |                                          | Invalid Email       | Change errorMessage |
|         |                            |                                          |                     |                     |
| Admin   | toggleUser(User)           | Enables or disables a user in the system | User exists         | Toggle status       |
|         |                            |                                          | User does not exist | Change errorMessage |
|         |                            |                                          |                     |                     |
| System  | signIn()                   | Signs in the user to the system          | Signs in            | Successful sign in  |
|         |                            |                                          | User is disabled    | Change errorMessage |

