using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {
        private string _title;
        private string _detail;
        private bool _status;
        private DateTime _dateTime;

        public TodoItem(string title, string detail, bool status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._dateTime = DateTime.Now;
        }
        public void changeStatus() 
        {
            if(_status)
            {
                this._status = false;
            }
            this._status = true;
        }

        public DateTime getDateTime()
        {
            return _dateTime;
        }

        public bool getStatus()
        {
            return this._status;
        }
    }
}
