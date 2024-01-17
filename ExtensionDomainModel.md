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

| Classes     | Members           | Methods                                     | Scenario                                                      | Outputs |
|-------------|-------------------|---------------------------------------------|---------------------------------------------------------------|---------|
| `Extension` | List<User> _users | `createUser(string email, string password)` | both inputs were correct and a new user was created           | true    |
|             |                   |                                             | one or both inputs were incorrect and no new user was created | false   |
|             |                   | `validEmail(string email)`                  | email contained @                                             | true    |
|             |                   |                                             | email did not contain                                         | false   |
|             |                   | `validPassword(string password)`            | password were 8 or more characters long                       | true    |
|             |                   |                                             | password were 8 less than characters long                     | false   |
| `User`      | string _status    | `canLogin()`                                | _status is "Activated"                                        | true    |
|             |                   |                                             | _status is not "Activated"                                    | false   |
|             | string _status    | `activate()`                                |                                                               |         |