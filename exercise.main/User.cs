namespace exercise.main;

public class User
{
    private string _email;
    private string _password;
    private string _status;

    public User(string email, string password)
    {
        _email = email.Trim();
        _password = password.Trim();
        _status = "Deactivated";
    }

    public void activate()
    {
        throw new NotImplementedException();
    }

    public bool canLogin()
    {
        throw new NotImplementedException();
    }
}
