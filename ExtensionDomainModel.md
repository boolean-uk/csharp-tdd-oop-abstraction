As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.


public class Account

Properties

private string _userPassword;
private string _userEmailAddress;

private enum roll = User; 
-can be User or Admin, is user by default.

private bool IsEnabled = false;

Account(string userPassword, string userEmail)
{
	setts private variabels to provided values
	setts roll to user;
	setts enabeled to false;
}

Account(string userPassword, string userEmail, string AdminVerification)
{
	setts private variabels to provided values
	if(AdminVerification == "ADMIN")
	{
		setts roll to Admin;
		setts enabeled to true;
	}
	
}

public string UserPassword {get{return _userPassword}}
public string UserEmailAddress {get{return _userEmailAddress}}
public roll AcountRoll {get{return _roll}}
public Bool AccountEnabeled {get{return IsEnabeled} set;} needs to be read/write to be abel to be changed


Class WebbPage
Dictionary <string email, Account>



Methods

public string createAcount(string userPassword, string email) 
creates account if userPassword is longer than 8 characters or if email does contain a @.
-returns that an account has been created.
- or returns coresponding error message.


public string LogIn(string userPassWord, string email)
returns a message if log in was possible.
returns an error if account is not enabeled or if password or email is incorrect. 

public enableAccount(Acount toEnable, email ForVerification ) provide account to enable and an email to verify you are an Admin.
returns message if account was enabeled 
returns error if acount was not found or if non admin account tries to enable.


public Account GetAccount(string email) returns acount based on provided email
