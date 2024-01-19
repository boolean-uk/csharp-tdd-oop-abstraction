As a system administrator,
I want my users to have to create a user account with an email address and a password.
fields: string email, string password

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled
method: string LogIn()

-------------------------

Different users: administrator, user



| Classes                  | Members                             | Methods                                                | Scenario                                              | Outputs   |
|--------------------------|-------------------------------------|--------------------------------------------------------|-------------------------------------------------------|-----------|
|  `ComputerSystem  `      | List<Account> accounts              |  CreateUser(string, string)                            | Everything is okay      	                          |  string   |
|            	           |                                     |                                                        | Email is wrong  format   				              |  string   |
|            	           |                                     |                                                        | Password is wrong format     			              |  string   |
|            	           |                                     |                                                        | Able to log in						                  |  string   |
|            	           |                                     |                                                        | NOT able to log in						              |  string   |
|  `abstract Account `     | string _email                       |                                                        |  	                                                  |  string   |
|            	           | string _password                    |                                                        |  		                                              |  string   |
|            	           | bool _isLoggedIn                    |                                                        | 						                              |           |
|            	           | bool _isEnabled                     |                                                        | 						                              |           |
|            	           | bool _isAdmin                       |                                                        | 						                              |           |
|  `User : Account `       |                                     |                                                        |                          	                          |           |
|  `Admin : Account `      |                                     |  SetEnabled(User, bool)                                | User became enabled                                   |  string   |
|                          |                                     |                                                        | User became disabled                                  |  string   |
