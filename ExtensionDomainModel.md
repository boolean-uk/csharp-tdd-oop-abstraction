```C#
Extension
public class User {
    public string userName;
    public string email;
    private string password;
    private bool state;
}

class UserAccountManagement {
    
    private List<User> users;

    public UserAccountManagement() {
        users = new List<User>();
        CreateAdmin(string adminusername, string adminemail, string adminpassword);
    }

    public void CreateAccount(stirng userName, stirng email, string password) {
        // create a new User
    }

    private void CreateAdmin() {
        //set
    }

    private bool isValidEmail(string email); // is called in CreateAccount returns true if valid, throw new exeption if not
    private bool isValidPassword(string password); // is called in CreateAccount returns true if valid, throw new exeption if not
    public bool isAccountActive(string userName); // return true if the users account is activated, false if not, userName works as _id  
    public void ChangeAccountState(string userName, bool state); //  changes the state on a given users acocunt based on state
    private void SetOrRemoveAdminFlag(string username, bool state); // changes the status on an admin isAdmin property to tur or false
    public bool isAdmin(stirng username); // returns true if user is admin, false if not.
     
}
```