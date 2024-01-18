| Classes			| Members							| Methods							| Scenario							| Outputs	|
|-------------------|-----------------------------------|-----------------------------------|-----------------------------------|-----------|
| `AccountSystem`	| `List<UserAcounts> _users`		| `createUser(string, string)`		| email without @					| "invalid email"				|
|					|									|									| password is not 8 characters long	| "invalid password"			|
|					|									|									| valid password and email			| "new user created"			|
| `Account`			|									| `EnableAccount(UserAccount)`		|									| false(not meant to be called)	|
| `BaseAccount`		| `string _email`					|									|									|			|
|					| `string _password`				| 									|									|			|
| `AdminAccount`	|									| `EnableAccount(UserAccount)`		|									| bool		|
| `UserAccount`		| `bool _enabled`					| `canLogIn()`						|									| bool		|
|					|									| `enable()`						|									| bool		|
|					|									|									|									|			|
|					|									|									|									|			|
|					|									|									|									|			|
