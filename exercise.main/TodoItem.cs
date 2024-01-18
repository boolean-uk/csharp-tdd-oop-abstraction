using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    //Class TodoItem
    public class TodoItem
    {
        //Properties
        private readonly string title;
        private readonly string detail;
        private readonly string CreationDateTime;
        private string status;

        //Constructor
        public TodoItem(string title, string detail, string status)
        {
            this.title = title;
            this.detail = detail;
            CreationDateTime = DateTime.Now.ToString();
            this.status = status;
        }

        //Setstatus
        public void setStatus(String status)
        {
            this.status = status;
        }

        //GetStatus
        public String getStatus()
        {
            return this.status;
        }

        //GetTime & Date
        public string getDateTime() 
        {
            string dateTimeValue = CreationDateTime;
            return dateTimeValue;
        }
    }
}
