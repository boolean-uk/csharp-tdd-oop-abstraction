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
        private readonly DateTime _creationdatetime;


        public TodoItem(String title, String detail, String status)
        {
            Title = title;
            Detail = detail;
            Status = status;
            _creationdatetime = DateTime.Now;
            
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public DateTime Creationdatetime
        {
            get { return _creationdatetime; }
        }
        public void SetStatus(String status)
        {
            Status = status;
        }

        public String SetStatus()
        {
            return Status;
        }
    }
}
