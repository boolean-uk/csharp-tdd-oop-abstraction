using exercise.main;

public class Program
{ 
    static public void Main(string[] args)
    {
        Extension extension = new Extension();
        User testUser = extension.addUser("password","email@email.uk");
        Admin admin = new Admin();
        admin.enableUser(testUser);
        Console.WriteLine("");
    }
}