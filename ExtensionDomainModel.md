# Domain Model

| Classes    | Methods                                        | Scenario                        | Outputs              |
|------------|------------------------------------------------|---------------------------------|----------------------|
| `AdminApp` | `CreateAccount(string email, string password)` | everything ok                   | `"account created"`  |
|            |                                                | password less than 8 characters | `"invalid password"` |
|            |                                                | email without an @ symbol       | `"invalid email"`    |
| `AdminApp` | `SetEnabledAccount(string email)`              |                                 |                      |
| `AdminApp` | `IsEnabledAccount(string email)`               | account has been enabled        | `true`               |
|            |                                                | account has not been enabled    | `false`              |

