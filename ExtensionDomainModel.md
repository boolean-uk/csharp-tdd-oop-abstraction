| Classes | Fields |
|-|-|
| `Account` (*abstract*) | `string _email` `string _isEnabled` `string _password` | 
| `User` | |
| `SystemAdministrator` | `bool _isEnabled` |

| Classes | Method | Scenario | Outputs | 
|-|-|-|-|
|`Account` (*abstract*)| `CanLogIn()` | If user is able to log into this account | true |
| | | If account has not been activated | false | 
| | `EnableAccount(Account acc)` | Attempt to enable the account | void |
| | `IsEnabled()` | If account is enabled | true | 
| | | If account is not enabled | false | 
| | `validateEmail(string email)` | The email fulfills requirements | true |
| | | The email does not fulfill requirements | false | 
| | `validatePassword(string password)` | The password fulfills requirements | true | 
| | | The password does not fulfill requirements | false |
| `User` implements `Account` | | |
| `SystemAdministrator` implements `Account` | `IsEnabled()` | Show that admin account is enabled | true | 