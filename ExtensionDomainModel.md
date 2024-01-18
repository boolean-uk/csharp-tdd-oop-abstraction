As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.

| Class | Method                                                    | Scenario                                                                                                    | Output |
|-------|-----------------------------------------------------------|-------------------------------------------------------------------------------------------------------------|--------|
| User  | create(string email, string password, string out message) | Creates a new used and checks validity of email and password Message indicates what caused the false output | bool   |
|       | Login(string email, string password, string out message)  | Tries to login with credentials Message indicates why you can or cannot login                               | bool   |
| Admin | EnableUser(User user)                                     | Enables user to login                                                                                       | void   |