| Class          | Members                                                | Methods                                   | Scenario                                | output    |
|----------------|--------------------------------------------------------|-------------------------------------------|-----------------------------------------|-----------|
| TodoList       | bool status                                            | changeStatus()                            | status was true before func was called  | FALSE     |
|                |                                                        |                                           | status was false before func was called | TRUE      |
|                | DateTime datetime                                      | getDateTime                               | dateTime exists                         | DateTime  |
| Account        | GUID id, string email, string password, bool isEnabled | CreateUser(string email, string password) | email and password are valid            | TRUE      |
|                |                                                        |                                           | email does not include @                | FALSE     |
|                |                                                        |                                           | password is shorter than 8 char         | FALSE     |
|                |                                                        | getEnable()                               | Returns value isEnabled                 | isEnabled |
|                |                                                        | protected EnableAccount()                 | admin changes value                     | TRUE      |
| AccountManager | List<Account> users                                    |                                           | Store the existing users                |
