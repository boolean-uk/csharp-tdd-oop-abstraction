
## User Stories Extension
## class User
PROPERTIES
	private string _email;
	private string _password;
	private Account _account;
	


METHODS
// List<UserAccount> userAccounts;
private string getEmail(); returns a message when email is correct or when @ is not used.
private string setEmail(); returns a message 
private bool isValidEmail(); returns true if (_email.contains("@")_)



## Account 
PROPERTIES
	private bool _isAnabled(); 

METHODS
	private bool getIsEnabled(); returns bool with a message if is enabled or is not enabled
	private bool setIsEnabled(); returns true when set as enabled
	public bool canLogIn(); returns bool when user is able to log in or not. 

```
I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.
```

```
I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.
```

```
I want new accounts to be disabled by default until I manually set them as enabled.
```

```
I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
```