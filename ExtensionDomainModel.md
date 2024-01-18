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

Users class : Account
			|bool _enabled = false; 
			|EnabledStatus {get; set;}
			|createUser(string email, string password)	| Validate + set +  addto Admin.AllUsers		|
			
Admin class : Account
			| _enabled = true
			| _userAccountCapacity, int = 0			|
			| List<Users> AllUsers					| 
			| private void enableUserAccount(User)	| User.Enable = true 
			| public void EnableMoreUsers(int num)	| set _userAccountCapacity = num, get first users from AllUsers => enableUserAccount(user) 

abstract class Account
			|string _username
			|string _password
			|string _enabled
			|createUser(string email, string password)	| ValidateUsername(), ValidatePassword() ==> set _username, password| void
			|<string, bool> ValidateUsername(string)	| Regex()															| Message, bool
			|public bool ValidatePassword(string)		| Regex()															| Message, bool
			|Username{get;}								|	get _username													| string
			|public	bool logIn()						| if _enabled != true												| false
			|public bool login()						| if _enabled == true												| true



I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

