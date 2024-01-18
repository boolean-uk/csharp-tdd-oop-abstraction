# The user story:


1. As a system administrator,
I want my users to have to create a user account with an email address and a password.

2. I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

3. I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

4. I want new accounts to be disabled by default until I manually set them as enabled.

5. I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.


### Domain modelling: 
```
As a system administrator,
I want my users to have to create a user account with an email address and a password.
```

| Classes         | Methods									 | Scenario																		| Outputs									|
|-----------------|------------------------------------------|------------------------------------------------------------------------------|-------------------------------------------|
|`Account`		  |	`createAccount(string ID, string pass)`	 | set the userName and password. Then store user info in a dictionary			| bool: false if invalid true if yes        |



```
I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.
```
| Classes         | Methods									 | Scenario																		| Outputs									|
|-----------------|------------------------------------------|------------------------------------------------------------------------------|-------------------------------------------|
|`Account`		  |	`checkPassword()`						 | check if the password met criteries											| bool: false if invalid true if yes        |


```
I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.
```
| Classes         | Methods									 | Scenario																		| Outputs									|
|-----------------|------------------------------------------|------------------------------------------------------------------------------|-------------------------------------------|
|`Account`		  |	`checkUserName()`						 | check if the username met criteries											| bool: false if invalid true if yes        |


```
I want new accounts to be disabled by default until I manually set them as enabled.
```
| Classes				  | Methods											  | Scenario																	 | Outputs									 |
|-------------------------|---------------------------------------------------|------------------------------------------------------------------------------|-------------------------------------------|
|`Admin: Account`		  |	`setAccountStatus(string username, bool status)`  | If you are an admin, you can set the acc status (based on their username)	 | bool: false if invalid true if yes        |


```
I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
```
| Classes         | Methods									 | Scenario																		| Outputs									|
|-----------------|------------------------------------------|------------------------------------------------------------------------------|-------------------------------------------|
|`Account`		  |	`logIn(string userName, string password)`| if the status of the account is true, then valid.							| bool: false if invalid true if yes        |
