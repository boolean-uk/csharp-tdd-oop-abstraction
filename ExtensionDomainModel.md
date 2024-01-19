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
- Account

#### Properties
- public bool _admin = false;
- public bool _status = false;
- public List<User> _users = new List<User>();


#### Methods
- User getAccount(string password, string email) : return User if exists, otherwise null
- public void setAccountEnabled(User user) : if admin status, set User status to enabled
- public void setAccountInabled(User user) : if admin status, set User status to inabled
- public bool canLogin() : true if status is true, else false
- public bool getStatus() : get status



#### Class
- User : Account

#### Properties
- private string _password {get};
- private string _email {get};



#### Class
- Admin : Account

#### Methods
- public bool approveAccount(string username, string email) : 
	* return true if password is over 8 characters and email contains @. 
	* Saves new user to _users List.
