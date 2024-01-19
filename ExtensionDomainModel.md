```

Class                | Method                            | Behavior                                  | Case                                                                           
---------------------|-----------------------------------|-------------------------------------------|--------------------------------------------------------------------------------
UserAccount          | Create(email, password)           | Create account with email and password    | As a system administrator, I want my users to create a user account.           
UserAccount          | ValidatePassword(password)        | Validate password length                  | Invalid password message if password is less than 8 characters.                
UserAccount          | ValidateEmail(email)              | Validate email format                     | Invalid email message if email lacks an @ symbol.                              
UserAccount          | IsEnabled()                       | Check if account is enabled               | Users should know if they can log in based on whether their account is enabled.
SystemAdministrator  | EnableAccount(userAccount)        | Enable a user account                     | New accounts should be disabled by default until manually enabled.             
SystemAdministrator  | DisableAccount(userAccount)       | Disable a user account                    | Manually set accounts as disabled.                                             
LoginService         | Login(email, password)            | Attempt login with email and password     | Users try to log in with their credentials.                                    

```