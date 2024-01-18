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
        private bool status = false;
        private DateTime dateTime;

        public TodoItem(String title, String detail)
        {
            this.title = title;
            this.detail = detail;
            dateTime = DateTime.Now;
        }

        public string getStatus()
        {
            if (status == true) { return "Complete"; }
            else { return "Incomplete"; }
        }
        public void setComplete()
        {
            status = true;
        }
        public string getDateCreated()
        {
            return dateTime.ToString();
        }
    }
}
