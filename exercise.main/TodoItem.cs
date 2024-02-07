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
        private string _dateTimeCreated;

        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public string Detail 
        {
            get => _detail; 
            set => _detail = value; 
        }
        public bool Status => _status;

        public string DateTimeCreated => _dateTimeCreated;

        public TodoItem(String title, String detail)
        {
            _title = title;
            _detail = detail;
            _status = false;
            _dateTimeCreated = GetDateTimeCreated();
        }

        public string GetDateTimeCreated()
        {
            return "DateTime.Now.ToString(\"yyyy-MM-dd HH:mm:ss\")";
        }

        public void SetComplete()
        {
            _status = true;
        }

        public void SetIncomplete()
        {
            _status = false;
        }
    }
}
