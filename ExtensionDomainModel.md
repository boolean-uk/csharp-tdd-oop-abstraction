As a system administrator,
I want my users to have to create a user account with an email address and a password.


I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.


I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.
| Classes         | Methods                                       | Scenario                  | Outputs                               |
|-----------------|-----------------------------------------------|---------------------------|---------------------------------------|
| `User`	      | `createAccount(string email, string password)`| password.Length < 8       | false, also prints "Invalid password" |
|                 |                                               | email without @           | false, also prints "Invalid email"    |
|                 |                                               | else                      | true, also prints "User created"      |


I want new accounts to be disabled by default until I manually set them as enabled.
| Classes         | Methods                                       | Scenario                  | Outputs                               |
|-----------------|-----------------------------------------------|---------------------------|---------------------------------------|
| `User`	      | `createAccount(string email, string password)`| any                       | void, sets isActive to false          |
| `User`	      | `setActive()`                                 | any                       | void, sets isActive to true           |

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

| Classes         | Methods                                       | Scenario                  | Outputs                               |
|-----------------|-----------------------------------------------|---------------------------|---------------------------------------|
| `User`	      | `login(string email, string password)`        | isActive                  | true, also prints "Log in success"    |
|                 |                                               | !isActive                 | false, also prints "Log in failed, account inactive" |