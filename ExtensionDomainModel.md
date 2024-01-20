As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

## public class User
### PROPERTIES:
   private string _email
   private string _password
   private AccountStatus _accountStatus // Initialize as false

### METHODS:
   public string CreatePassword(string pass)
        // If password length is greater than 7 accept it

   public string AddEmail(string email)
       If email contains @ set the email & return "success"
       if email invalid return string "invalid email"

   public AccountStatus AccountEnabled()
       return _accountStatus
   public void EnableAccount()
   public void DisableAccount()

   public enum AccountStatus
       disabled
       enabled


## public class TodoItem
### PROPERTIES:
   private string title
   private string detail
   private bool status
   private DateTime createdAt

### METHODS:
   public TodoItem(String title, String detail)
       Intialize the TodoItem and set createdAt to the current time

   public void setStatusDone()

   public void setStatusNotDone()

   public string getStatus
       outputs string depending on status

   public DateTime getTimeCreated()
       outputs createdAt