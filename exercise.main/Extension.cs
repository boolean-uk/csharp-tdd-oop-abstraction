
namespace exercise.main {

    public enum Role {
        USER,
        ADMIN
    }
    public class User {
        private string _email;
        private string _password;
        private bool _isEnabled;
        private Role _role;

        public bool IsEnabled { get { return _isEnabled; }}
        public string Email { get { return _email; }}
        public string Password { get { return _password; }}
        public Role Role { get { return _role; }}

        public User(string email, string password,  Role role = Role.USER) {
            _email = email;
            _role = role;
            _password = password;
            _isEnabled = false;
            }

        public bool UpdateIsEnabled(bool isEnabled) {
            _isEnabled = isEnabled;
            return _isEnabled;
        }

    }

    public class Extension {
        private List<User> users;
        public Extension(User adminUser) {
            users = [adminUser];
        }

        public string CreateUser(string email, string password) {
            if(email == "" || password == "")
                return "Can Not Be Empty!";
            if(!email.Contains('@'))
                return "invalid email";
            if(password.Length < 8)
                return "invalid password";
            users.Add(new User(email, password));
            return "User Created!";
        }

        public bool CanLogIn(User user) {
            foreach (User u in users)
            {
                if(u == user) {
                    return u.IsEnabled;
                }
            }
            return false;
        }

        public bool EnableUser(User admin, string user, bool status) {
            if(admin.Role == Role.ADMIN) {
                foreach (User u in users)
                {
                    if(u.Email == user) {
                        u.UpdateIsEnabled(status);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}