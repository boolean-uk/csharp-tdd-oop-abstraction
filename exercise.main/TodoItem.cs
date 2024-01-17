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

        private string name;
        private string email;
        private string password;
        private bool enabled = false;

        User(string name, string email, string password)
        {
            this.name = name;
            this.email = SetEmail(email);
            password = SetPassword(password);
        }

        public string SetPassword(String newPassword)
        {
            if(newPassword.Length < 8) { return "Invalid Password"; }
            
            return password;
        }

        public string SetEmail(string email)
        {
            if(!email.Contains("@") { return "Invalid email"; }


            return email;
        }
    }
}
