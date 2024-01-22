using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {
        // private for better abstraction, can only be accessed within this class
        private string _title;
        private string _detail;
        private string _status;
        //  for the user story, tasks need a time and date created, but only to be read not modified
        private readonly DateTime _dateTimeCreated;

        public TodoItem(String title, String detail, String status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
           this. _dateTimeCreated = DateTime.Now;
        }

        public void setStatus(String status)
        {
            this._status = status;
        }

        public String getStatus()
        {
             return this._status;
        }

        public DateTime getDateTimeCreated()
        {
            return this._dateTimeCreated;
        }
    }
}
