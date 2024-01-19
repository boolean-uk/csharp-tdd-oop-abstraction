# Domain Model: User Account
## Entities
### Account (Abstract)
#### Fields
* email : string - Email of the account.
* password: string - Password of the account.
* isEnabled: bool - Determines whether the given account is enabled.
#### Methods
* IsCorrectPassword(string) : bool - Returns whether input string is the correct password for this account.
* MeetsEmailPolicy(string) : bool - Email must contain '@'.
* MeetsPasswordPolicy(string) : bool - Password must be 8 or more characters in length.
* Enable(Login): void - Enables the account. Requires an administrator Login.
* Disable(Login): void - Enables the account. Requires an administrator Login.

### UserAccount: Account
Is disabled by default.

### AdministratorAccount: Account
Is enabled by default.

#### Methods
* EnableAccount(Account): void - Enables an account 

### Login
#### Fields
* account : Account - Is set to the logged in account if password for that account is correct.
#### Methods
* Login(Account, string) : void - Sets account if valid email and password.
* IsAdmin(): bool - Returns whether the logged in account is an administrator.

### Accounts
#### Fields
* accounts : List\<Account> - Container that holds all accounts.
#### Methods
* Create(string, string) : void - Adds a new Account to accounts if email and password policies are met in input.
* Get(string) : Account - Returns Account with email equals to string input.