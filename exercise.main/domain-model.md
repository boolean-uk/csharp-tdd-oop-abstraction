#Domain model Core


```
User story 1
I want to see a Date and Time the task was created but I do not want it changed.   



Class           | Member                        |  Method                     | Output
---------------------------------------------------------------------------------------------------------------------------------------------|
TodoItem        | title                         |                             |                                                              |
                | detail                        |                             |                                                              |       
                | status                        | setStatus(String status)    | Changes status                                               |
                | creationDateTime              |                             | Read-only field representing the date and time of creation.  |
                |                               | getStatus()                 | Retrieves the current status of the task.                    |
                |                               | getCreationDateTime()       | Retrieves the date and time of task creation.                |
----------------------------------------------------------------------------------------------------------------------------------------------

```

﻿#Domain model Extension

User Story 1: User Account Creation

/*
As a system administrator,
I want my users to have to create a user account with an email address and a password.
*/

Class           | Member/Attributes                       |  Method                     | Output
--------------------------------------------------------------------------------------------------------------------------------------------------|
User            | email: string                           |User(email, password)        |Creates a user account with the given email and password.|                                                              
                | password: string                        |                             |                                                         |           
                |                                         |                             |                                                         |
--------------------------------------------------------------------------------------------------------------------------------------------------|


User Story 2: Invalid Password Message

/*
I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.
*/

Class           | Member/Attributes                       |  Method                     | Output
--------------------------------------------------------------------------------------------------------------------------------------------------|
User            | password: string                        | IsValidPassword(): bool     |Checks if the password is valid (at least 8 characters). |
                |                                         |                             |                                                         |           
                |                                         |                             |                                                         |
--------------------------------------------------------------------------------------------------------------------------------------------------|


User Story 3: Invalid Email Message

/*
I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.
*/

Class           | Member/Attributes                       |  Method                     | Output
--------------------------------------------------------------------------------------------------------------------------------------------------|
User            |  email: string                          | IsValidEmail(): bool        |Checks if the email is valid (contains '@' symbol).      |
                |                                         |                             |                                                         |           
                |                                         |                             |                                                         |
--------------------------------------------------------------------------------------------------------------------------------------------------|


User Story 4: New Accounts Disabled by Default

/*
I want new accounts to be disabled by default until I manually set them as enabled.
*/

Class           | Member/Attributes                       |  Method                     | Output
--------------------------------------------------------------------------------------------------------------------------------------------------|
User            | - isEnabled: bool	                      | EnableAccount()             |Manually enables the user account.                       |
                |                                         |                             |                                                         |           
                |                                         |                             |                                                         |
--------------------------------------------------------------------------------------------------------------------------------------------------|


User Story 5: Account Login Status
/*
I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
*/

Class           | Member/Attributes                       |  Method                     | Output
--------------------------------------------------------------------------------------------------------------------------------------------------|
User            | - isEnabled: bool	                      |  IsEnabled(): bool          |Checks if the account is enabled.                        |
                |                                         |                             |                                                         |           
                |                                         |                             |                                                         |
--------------------------------------------------------------------------------------------------------------------------------------------------|
