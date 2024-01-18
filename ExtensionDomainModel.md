As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

| Classes    | Members                            | Methods                                     | Scenario                     | Outputs       |
|------------|------------------------------------|---------------------------------------------|-------------------------    -|---------------|
| `User`     | string _password                   | `SetPassword(string pass)`                  | password is invalid          | false         |
|            |                                    |                                             | password is valid            | true          |
|            | string _email                      | `SetEmail(string email)`                    | email is invalid             | false         |
|		     |                                    |                                             | email is valid               | true          |
|            | -enabled                           | `EnableUser()`								|							   |               |
|            | _enabled                           | `Login(User user)`							| user is enabled			   | true          | 
|            |                                    |                                             | user is disabled             | false         |

//Could rewrite everything so that password and email is all done 
in the constructor of the User class, prints out error messages, 
and locks the user if anything is wrong right from the start, 
that would make more sense but given the task im gonna keep it simple stupid and visual like this i guess

