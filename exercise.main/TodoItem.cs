using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class User
    {
        private string _email;
        private string _password;
        private bool _accountStatus;

        public User(string email, string password)
        {
            CreatePassword(email);
            SetEmail(email);
            _accountStatus = false;
        }

        public string CreatePassword(string password)
        {
            if (password.Length >= 8)
            {
                _password = password;
                return "success";
            }
            else return "invalid password";
        }
        public string SetEmail(string email)
        {
            //throw new NotImplementedException();
            if (email.Contains('@'))
            {
                _email = email;
                return "success";
            }
            else return "invalid email";
        }
        public bool AccountEnabled()
        {
            return _accountStatus;
        }
        public void EnableAccount()
        {
            _accountStatus = true;
        }
        public void DisableAccount()
        {
            _accountStatus = false;
        }

    }

    public class TodoItem
    {

        private string _title;
        private string _detail;
        private string _status;
        private DateTime _created;

        public TodoItem(String title, String detail, String status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._created = DateTime.Now;
        }

        public void setStatus(String status)
        {
            this._status = status;
        }

        public String getStatus()
        {
            return this._status;
        }

        public DateTime getCreated()
        {
            return this._created;
        }
    }
}