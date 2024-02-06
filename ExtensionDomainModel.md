Class User

// USER STORY
As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

//PROPERTIES
	private string email;
	private string password;
	private bool isEnabled;

//METHODS
	public string getEmail() // returns a string of the email.
	public string setEmail() // returns a message whether the email is set correctly. 
	public string getPassword() // returns a string of the password.
	public bool getIsEnabled() // returns a boolean whether the account is enabled or disabled.
	public void setIsEnabled() // sets the account to enabled.
	public bool isAbleToLogin() // returns whether the user is able to login. 
