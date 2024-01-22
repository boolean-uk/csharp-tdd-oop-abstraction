As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.




|Class:				|Methods:												|Scenarios
---------------------------------------------------------------------------------------------------
|`IUserOps`			|`EnableAccount(Account account)`						|Wrong password			|`"Wrong password"`
|`Manager`			|`Inherited:` `EnableAccount(Account account)`			|Password too short		|`"Wrong password"`
|					|														|No @ in email creation	|`"Wrong email"`
|					|														|						|
|`Account`			|`getEnabled()`											|						|
|					|`Internal protected` `EnableAccount(bool enable)`		|						|
|					|														|						|
|`AccountManager`	|`CreateAccount(string, string)`						|						|