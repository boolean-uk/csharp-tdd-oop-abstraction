As a system administrator,
I want my users to have to create a user account with an email address and a password.
| Classes | Methods                                 | Scenario                                       | Outputs  |
|---------|-----------------------------------------|------------------------------------------------|----------|
|`User`   | `create(string email, string password`  | Create user account with email and password    | void     |

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.
| Classes | Methods                     | Scenario                                                     | Outputs  |
|---------|-----------------------------|--------------------------------------------------------------|----------|
|`User`   | `validPassword(User user)`  | Check password length and possibly return "invalid password" | boolean  |

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.
| Classes | Methods                  | Scenario                                            | Outputs  |
|---------|--------------------------|-----------------------------------------------------|----------|
|`User`   | `validEmail(User user)`  | Check email adress and possibly return "missing @"  | boolean  |

I want new accounts to be disabled by default until I manually set them as enabled.
| Classes | Methods                         | Scenario                                  | Outputs  |
|---------|---------------------------------|-------------------------------------------|----------|
|`User`   | `disabledByDefault(User user)`  | Check if accounts are disabled by default | boolean  |

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
| Classes | Methods                | Scenario                                                          | Outputs |
|---------|------------------------|-------------------------------------------------------------------|---------|
|`User`   | `canLogin(User user)`  | Check if user can login based on whether their account is enabled | boolean |