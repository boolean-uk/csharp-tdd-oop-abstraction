| Classes         | Members                 | Methods             | Scenario                        | Output  |
|-----------------|-------------------------|---------------------|---------------------------------|---------|
| BaseAccount     | string email            |                     |                                 |         |
|                 | string password         |                     |                                 |         |
| UserAccount     | bool isEnabled          | GetEmail()          |                                 | string  |
|                 |                         | CanUserLogin()      |                                 | bool    |
|                 |                         | EnableLogin()       |                                 | bool    |
| AdminAccount    |                         | EnableUserAccount() |                                 | bool    |
| AccountRegister | List<UserAccount> users | CreateUser()        | Account created with valid info | console |
|                 |                         |                     | Account with invalid email      | console |
|                 |                         |                     | Account with invalid password   | console |