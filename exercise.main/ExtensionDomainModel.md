# Extension

## User stories
As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

## Extracted requirments
1. Able to create user account with an email address and a password.
2. Receive an "invalid password" message if a password with less than 8 characters is provided.
3. Receive an "invalid email" message if a emailaddress without an @ symbol is provided.

4. Accounts are disabled by default
5. Able to set account to enabled.
6. Able to see whether their account can login based on whether account is enabled or disabled.

## Classes
| Class | properties |
|---|---|
| UserAccount | `string _email`, `string _password`, `bool _isEnabled` |


## Functionality
| User story | Method | Scenario | Output |
|---|---|---|---|---|---|
| 1 | `private IsValidEmail(string email)` | If `email` contains `@` | Returns `true` |
| 2 | | If `email` does not contain `@` | Returns `false` |
| 3 | `private IsValidPassword(string password)` | If `password` is 8 or more characters | Returns `true` |
| 5 | | If `password` is less than 8 | Returns `false` |
| 6 | `public Enable()` | | Sets `_isEnabled` to `true` |
| 7 | `public CanLogin()` | | Returns `_isEnabled` |