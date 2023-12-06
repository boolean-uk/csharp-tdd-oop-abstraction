## Extension Domain Model

```
As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
```

| Class		 | Method/Property												      | Scenario										| Output	|
|------------|--------------------------------------------------------------------|-------------------------------------------------|-----------|
| Account.cs |Object <Account>	with email, password, status					  | Object that holds accounts						|			|
| UserList.cs|`New(string emailaddress, string password)` to create new <Account> | Create new account (disabled by default)		| Account	|
| UserList.cs|List <Account>													  | Store the existing accounts						|			|
| Account.cs |`SetPassword(string password)` inside the New() method			  | if pw < 8 chars return "invalid password"		| string	|
| Account.cs |`SetEmail(string emailadrress)` inside the New() method			  | if email contains no @ return "invalid email"	| string	|
| UserList.cs|`CheckStatus(string email)`										  | user can check if they can log in				| string	|

 
