
```
I want to see a Date and Time the task was created but I do not want it changed.   
```


| Classes    | Methods         | Scenario | Outputs  |
|------------|-----------------|----------|----------|
| `TodoItem` | `getDateTime()` |          | DateTime |

```
I want new accounts to be disabled by default until I manually set them as enabled.
```

| Classes    | Methods                                   | Scenario | Outputs                  |
|------------|-------------------------------------------|----------|--------------------------|
| `TodoItem` | `TodoItem(string email, string password)` |          | Item(status == "Disabled |

```
As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.
```

| Classes       | Members            |Methods                                         | Scenario                                  | Outputs     |
|---------------|--------------------|------------------------------------------------|-------------------------------------------|-------------|
| `UserManager` |`List<User> Users`  | `CreateAccount(string email, string password)` | password length *is not* longer than 8    | Console.out |
|               |                    |                                                | email *does not* contain @                | Console.out |
|               |                    |                                                |                                           | User        |

```
I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
```

| Classes       | Members            |Methods                   | Scenario                 | Outputs |
|---------------|--------------------|--------------------------|--------------------------|---------|
| `UserManager` |`List<User> Users`  | `CanLogin(string email)` | User staus is *Enabled*  | true    |
|               |                    |                          | User staus is *Disabled* | false   |

