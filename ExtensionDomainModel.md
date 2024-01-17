## Domain Model

| `Classes` | `Methods`     | `Scenarios`                                 | `Outputs`                                        |
|-----------|---------------|---------------------------------------------|--------------------------------------------------|
| `User`    | `IsEnabled`   |                                             | `Returns whether or not the account is enabled`  |
|           | `SetEnabled`  |                                             | `Sets the user to enabled`                       |
|           | `SetDisabled` |                                             | `Sets the user to disabled`                      |
|           | `SetEmail`    | `The email contains an @ character`         | `Sets the email of the user`                     |
|           |               | `The email does not contain an @ character` | `Returns a message that the email is invalid`    |
|           | `SetPassword` | `The password is at least 8 characters`  | `Sets the password of the user`                  |
|           |               | `The password is shorter than 8 characters` | `Returns a message that the password is invalid` |