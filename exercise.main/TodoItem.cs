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
        private bool status;
        private DateTime dateTime;

        public TodoItem(string title, string detail, bool status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.dateTime = DateTime.Now;
        }

        public void changeStatus()
        {
            if (status)
            {
                this.status = false;
            }
            this.status = true;
        }
        public DateTime getDateTime() { return dateTime; }

        public bool getStatus()
        {
            return this.status;
        }
    }
}