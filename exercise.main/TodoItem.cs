using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string _title;
        private string _detail;
        private string _status;
        private DateTime _created;

        public TodoItem(String title, String detail, string status)
        {
            _title = title;
            _detail = detail;
            _status = status;
            _created = DateTime.Now;
        }

        public string Title { get => _title; }
        public string Detail { get => _detail; }
        public string Status { get => _status; }
        public DateTime Created { get => _created; }

        public void SetComplete()
        {
            _status = "Complete";
        }

        public void SetIncomplete()
        {
            _status = "Incomplete";
        }
        public void SetTitle()
        {
            _title = "A title";
        }

        public void SetDetails()
        {
            _detail = "Some details";
        }

    }
   
}
