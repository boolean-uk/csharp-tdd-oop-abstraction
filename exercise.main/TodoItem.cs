using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string _title;
        private string _detail;
        private string _status;
        public readonly string _dateTime;
        public TodoItem(String title, String detail)
        {
            _title = title;
            _detail = detail;
            _status = "incomplete";
            _dateTime = DateTime.Now.ToString();
        }

        public void changeStatus()
        {
            if(_status == "incomplete" )
            {
                _status = "complete";
            }
            else if (_status == "complete" )
            {
                _status = "incomplete";
            }
        }

        public String getStatus()
        {
            return _status;
        }
        public string getTime()
        {
            return _dateTime;
        }
    }
}
