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
        //I regard status as either completed or incomplete
        private bool _status;
        private string _creationTime;

        public string Title { get => _title; }
        public string Detail { get => _detail; }

        public bool Status { get => _status; set => _status = value; }

        public string CreationTime { get => _creationTime;}

        public TodoItem(string title, string detail, bool status)
        {
            _title = title;
            _detail = detail;
            Status = status;
            _creationTime = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
        }

    }
}
