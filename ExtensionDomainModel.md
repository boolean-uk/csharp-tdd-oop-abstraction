| Classes       | Methods							|  Returns  | Scenario               | Outputs					   | 
|---------------|-----------------------------------|-----------|------------------------|-----------------------------|
| `AdminUser`	| `toggleUser(User user)`			| string	| valid mail given and user is disabled | enables user and returns a confirmation|
| 				| 									| string	| valid mail given and user is enabled	| disables user and returns a confirmation|
| `User`		| `setPassword(string password)` 	| string 	| password is 8 char or longer			| sets new password |
|				|								 	| string 	| password is shorter than 8 char		| returns invalid password message	 |
|				| `setEmail(string email)` 			| string 	| email contains @						| sets new password |
|				| `checkStatus()`					| bool	 	|										| returns User's enabled state	 |