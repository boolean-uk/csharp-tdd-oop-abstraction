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
        private string _status;
        private DateTime _creation;

        public TodoItem(string title, string detail, string status)
        {
            _title = title;
            _detail = detail;
            _status = status;
            _creation = DateTime.Now;
        }

        public void Complete()
        {

            _status = "Complete";
        }

        public void Uncomplete()
        {

            _status = "Uncomplete";
        }

        public string GetStatus()
        {
            return _status;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetDetail()
        {
            return _detail;
        }

        public DateTime GetDateCreated()
        {
            throw new NotImplementedException();
        }
    }
}

