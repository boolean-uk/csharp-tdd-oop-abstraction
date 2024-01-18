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
        private DateTime _created;

        public TodoItem(String title, String detail, String status)
        {
            _title = title;
            _detail = detail;
            _status = status;
            _created = DateTime.Now;
        }
        public DateTime Created
        {
            get { return _created; }
        }

        public string Detail
        {
            get=> _detail;
        }

        public string Status
        {
            get => _status; 
        }

        public string Title
        {
            get => _title;
        }

        public String Details
        {
            get => _detail;
        }

        public void StatusDeriving()
        {
            _status = "Deriving";
        }

        public void StatusParked()
        {
            _status = "Parked";
        }
    }
}
