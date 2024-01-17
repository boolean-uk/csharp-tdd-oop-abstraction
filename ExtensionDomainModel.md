```C#
class UserAccountManagement {
    private string userName;
    private string email;
    private string password;
    private bool state;

    public void CreateAccount(stirng userName, stirng email, string password) {
        //set
    }

    private bool isValidEmail(string email); // is called in CreateAccount returns true if valid, throw new exeption if not
    private bool isValidPassword(string password); // is called in CreateAccount returns true if valid, throw new exeption if not
    public bool isAccountActive(string userName); // return true if the users account is activated, false if not, userName works as _id  
}
```