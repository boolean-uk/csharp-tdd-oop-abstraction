
1. As a system administrator, '/
I want my users to have to create a user account with an email address and a password.

2. I want them to receive an "invalid password" message if they provide a '/
password less than 8 characters in length.

3. I want them to receive an "invalid email" message if they provide an email '/
address without an @ symbol in it.

4. I want new accounts to be disabled by default until I manually set them as enabled. '/

5. I want users to know if they are able to log in or not based on whether their 
account is enabled or disabled. '/

Class: Admin
Properties:

Methods:
bool enableAccount(User user) // sets provided user to enabled 
return: true when enabled

Class: User
Properties:
private string password
private string email
public bool enabled

Methods:
bool canLogin()

Class: System
Properties:

Methods:
bool createUser(string password, string email)
runs checkPassword & checkEmail
return: true if user created

bool checkPassword(string password)
return: true if password is "good"

bool checkPassword(string email)
return: true of email is "good"