### Domain Model - Extension

| Classes      | Properties                        | Methods                                                                  | Returns                                          |   |
|--------------|-----------------------------------|--------------------------------------------------------------------------|--------------------------------------------------|---|
| private User | private string _username : Getter | public bool UpdateIsEnabled(bool status)                                 | Returns true if changed, otherwise false         |   |
|              | private string _email : Getter    |                                                                          |                                                  |   |
|              | private string _password : Getter |                                                                          |                                                  |   |
|              | private bool _isEnabled : Getter  |                                                                          |                                                  |   |
|              | private string _role : Getter     |                                                                          |                                                  |   |
| Extension    | List<User> users                  | public string CreateUser(string username, string email, string password) | Returns a string based on if the input is valid. |   |
|              |                                   | public string CanLogIn(string username, string email, string password)   |                                                  |   |
|              |                                   | public bool EnableUser(User admin, string userEmail, bool status)        | Returns true if changed, otherwise false         |   |
|              |                                   |                                                                          |                                                  |   |
