namespace exercise.main;

public class User
{
    private string _email;
    private string _password;
    private string _status;

    public User(string email, string password)
    {
        _email = email;
        _password = password;
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
