User Stories

As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

Classs			Properties			Methods
UserAccount		private string email		string SetEmail(string email) 				private string password		string SetPassword(string password)			private bool status		void DisableAccount()
							void EnableAccount()
							bool CanLogIn()

			


Scenario				Output
Sets the email				A string message if action was successful or not
Sets the password			A string message if action was successful or not
Sets the account as disabled		No output
Sets the account as enabled		No output
Checks if the account is enabled		Returns true or false depending on if it is enabled or or disabled				not
