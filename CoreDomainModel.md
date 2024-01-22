
| Classes         | Members                                         | Methods                                                      | Scenario                            | Outputs					 |
|-----------------|-------------------------------------------------|--------------------------------------------------------------|-------------------------------------|---------------------------|
| `TodoItem`      | string title                                    |													   	       |			  			             | 						     |
|			      | string detail                                   |													   	       | 							         | 					         |
|			      | string status                                   |									   	           			   |			   				         |
|				  |													| 'taskStarted(dateTime time)'								   | set date and time a task i started  | void 
|                 |                                                 | 'getDateTime()'                                              | get the exact time and date         | DateTime object

| 'Account'(abstract) | string username								|                                                              |                                     |                             |
|                  | string password								|															   |                                     |							   |
|				   | string email									|															   |                                     |							   |
|				   | bool isEnabled									|															   |									 |							   |
|				   |                                                |                                                              |                                     |                             |
|                  |                                                | createAccount();											   |									 | void
|				   |												| checkPassword()											   |						             | void						   |
|				   |                                                |                                                              |					                 | void                        |
|				   |                                                | checkUserName												   |						             | void                        |
|				   |                                                |                                                              |					                 | void                        |





|'Administrator : Account' |  
|                  |                                                | createAccount();											   | Creates a account					 | Account
|				   |												| checkPassword()											   | is the password correct             | true						   |
|				   |                                                |                                                              | is the password wrong               | false                       |
|				   |                                                | checkUserName()											   | is the username correct             | true                        |
|				   |                                                |                                                              | is the username wrong               | false                       |
|				   |												| changeAccountStatus()										   | account is enabeled				 | true						   |
|				   |                                                |															   | account is not enabled			     | false					   |
|				   |												| sendMessage();											   |									 | string


|'User : Account'  |  
|                  |                                                | createAccount();											   | Creates a account					 | Account
|				   |												| checkPassword()											   | is the password correct             | true						   |
|				   |                                                |                                                              | is the password wrong               | false                       |
|				   |                                                | checkUserName()											   | is the username correct             | true                        |
|				   |                                                |                                                              | is the username wrong               | false                       |
|				   |												| changeAccountStatus()										   | account is enabeled				 | true						   |
|				   |                                                |															   | account is not enabled			     | false	

