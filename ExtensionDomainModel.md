### Requirements
As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

#### Class
- User

#### Properties
- private string _password;
- private string _email;
- private bool _status = false;


#### Methods
- public string passWordCreate(string password) : return success if pw length over 8, otherwise invalid
- public string EmailCreate(string email) : return success if email contains @ otherwise invalid
- getStatus() : get account status - also functions as a way to check if user can login
- setAccountEnabled() : set _status to true
- setAccountInabled() : set _status to false