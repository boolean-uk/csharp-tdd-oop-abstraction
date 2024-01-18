From Core:

Class	 | Members                       | Scenario	     | output
--------------------------------------
TodoItem |private DateTime _TimeStamp    |                   
		 |private string _status		 |
		 |public string TimeStamp{get;}  | get _TimeStamp       | string
         |public string Status {get; set}| get; set; _status    | string
		 | setDateTime()				 | gets DateTime Local	| string

Extension
User story:

As a system administrator,
I want my users to have to create a user account with an email address and a password.
=> User.createAccount()

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.


User class : Account
			public User(){setAdmin(false);}
Admin class : Account
			public Admin(){setAdmin(true);}

abstract class Account
			|string _username
			|string _password
			|bool _enabled = false;
			|bool _isAdmin														
			|protected void setAdmin(bool)				| set _isAdmin and _enabled = bool
			|createUser(string email, string password)	| ValidateUsername(), ValidatePassword() ==> set _username, password| void
			|private string ValidateUsername(string)	|check regex													| Message, string
			|private string ValidatePassword(string)	| check Length >= 8												| Message, string
			|public EnableAccount(string)				| if(_isAdmin) get user => set _enabled = true					| void
			|public	bool logIn()						| return _enabled												| bool
			





