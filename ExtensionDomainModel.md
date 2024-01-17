Class: UserAccount

Properties:

Email (string): The email address of the user. It is private and can only be set during object creation.
Password (string): The password of the user. It is private and can only be set during object creation.
IsEnabled (bool): The status of the user account. It is private and can only be changed through the Enable and Disable methods.
Methods:

UserAccount(string email, string password): A constructor that creates a new UserAccount object with the given email and password. 
It validates the email and password and throws an exception if they are invalid.
Enable(): Enables the user account. Does not return a value.
Disable(): Disables the user account. Does not return a value.
CanLogin(): Checks if the user can log in based on whether their account is enabled or disabled. Returns true if the user can log in, false otherwise.