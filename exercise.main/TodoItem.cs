namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        private AccountStatus _accountStatus;

        public User(string email, string password)
        {
            CreatePassword(password);
            SetEmail(email);
            _accountStatus = AccountStatus.DISABLED;
        }

        public string CreatePassword(string password)
        {
            if (password.Length >= 8)
            {
                _password = password;
                return "success";
            }
            else return "invalid password, must be more than 7 characters";
        }

        public string SetEmail(string email)
        {
            if (email.Contains('@'))
            {
                _email = email;
                return "success";
            }
            else return "invalid email, does not contain @";
        }

        public AccountStatus AccountEnabled()
        {
            return _accountStatus;
        }

        public void EnableAccount()
        {
            if (_email != null && _password != null)
            {
                _accountStatus = AccountStatus.ENABELD;
            }
        }

        public void DisableAccount()
        {
            _accountStatus = AccountStatus.DISABLED;
        }
        public enum AccountStatus
        {
            DISABLED,
            ENABELD
        }
    }



    public class TodoItem
    {

        private string _title;
        private string _detail;
        private bool _status;
        private DateTime _created;

        public TodoItem(String title, String detail)
        {
            this._title = title;
            this._detail = detail;
            this._status = false;
            this._created = DateTime.Now;
        }

        public void setStatusDone()
        {
            this._status = true;
        }
        public void setStatusNotDone()
        {
            this._status = false;
        }

        public string getStatus()
        {
            if (_status)
            {
                return "Done";
            }
            else
            {
                return "Not done";
            }
        }

        public DateTime getCreated()
        {
            return this._created;
        }
    }
}