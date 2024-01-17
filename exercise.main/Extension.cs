namespace exercise.main;

public class Extension
{
    List<User> _users;

    public Extension()
    {
        _users = new List<User>();
    }

    public bool createUser(string email, string password)
    {
        if (!validEmail(email) || !validPassword(password))
        {
            return false;
        }
        _users.Add(new User(email, password));
        return true;
    }

    private bool validEmail(string email)
    {
        if (email.Contains("@")) return true;
        Console.WriteLine("invalid email");
        return false;
    }

    private bool validPassword(string pasword)
    {
        if (pasword.Trim().Length >= 8) return true;
        Console.WriteLine("invalid email");
        return false;
    }
}
