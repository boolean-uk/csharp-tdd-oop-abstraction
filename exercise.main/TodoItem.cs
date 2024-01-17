using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string title;
        private string detail;
        private string status;
        private DateTime creationDate;

        public TodoItem(String title, String detail, String status, DateTime? datetime = null)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.creationDate = datetime ?? DateTime.Now;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public String getStatus()
        {
            return this.status;
        }

        public string getCreationDate()
        {
            return creationDate.Date.ToString();
        }

        public string getCreationTime()
        {
            return string.Format("{0:t}", creationDate);
        }
    }


    public class User
    {

        private string _name;
        public string Name { get { return _name; } }
        private string _email;
        public string Email { get { return _email; } }

        private string _password;

        private bool _enabled = false;
        public bool Enabled { get { return _enabled; } }

        public User(string name, string email, string password)
        {
            this._name = name;
            this._email = SetEmail(email);
            _password = SetPassword(password);
        }

        public string SetPassword(String newPassword)
        {
            if (newPassword.Length < 8) { return ""; }

            _password = newPassword;

            return _password;
        }

        public string GetPasswordStatus()
        {
            if(_password.Length < 8) { return "Invalid password"; }
            return "Password is OK.";

        }

        public string SetEmail(string email)
        {
            if (!email.Contains("@") ){ return "Invalid email"; }


            return email;
        }

        public bool ToggleEnabled() { _enabled = !_enabled; return _enabled; }
        public string Login(string psw)
        {
            if (!_enabled) { return "Account is disabled."; }
            if (psw != this._password) { return "Wrong Password"; }
            return "Success!";


        }


    }
}
