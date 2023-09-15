using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem {
        
        private string _title;
        private string _details;
        //public string detail;
        private string _status;
        private DateTime _created;


        public TodoItem(string title, string details, string status) {
            this._title = title;
            this._details = details;
            this._status = status;
            this._created = DateTime.Now;
        }

        public string Title { get { return _title; } }
        public string Details { get { return _details; } }
        public string Status { get { return _status; } }
        public DateTime Created { get { return _created; } }
    }
}
