# TDD

## user stories

As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

## domain model

class account
PROPERTIES
    private string _email
    private string _password
    private bool _enabled;
METHODS
    constructor()
        _enabled = false;
    public string createAccount(string email, string password)
        bool emailStatus = checkEmail(email)
        bool passwordStatus = checkPassword(password)

        if(!emailStatus) return "email needs @"
        if (!passwordStatus) return "password can not be less than 8"
        return "account created"
    public bool canLogIn()
        if _enabled return true else false
    public void setEnabled()
        _enabled = true
    private bool checkEmail(string email)
        returns true if email contains @
    private bool checkPassword(string password)
        returns true if password.Length >= 8 else false