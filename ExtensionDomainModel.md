As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

// class User

// properties
    private string _name;
    public string Name { get { return _name; } }

    private string _email;
    public string Email { get { return _email; } }

    private string password;

    private bool _enabled = false;
    public bool Enabled { get { return _enabled; } }

// methods
    public User(string name, string email, string password)
    public string SetPassword(string newPassword)
    public string SetEmail(string email)
    public bool ToggleEnabled()
    public string Login(string psw)
