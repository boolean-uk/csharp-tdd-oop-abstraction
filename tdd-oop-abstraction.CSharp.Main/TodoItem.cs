using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem {
        
        private string _title;
        private string _detail;
        private bool _status;
        private DateTime _created;

        public TodoItem(string title, string detail, bool status) {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._created = DateTime.Now;
        }



        public string Title { get { return _title; } }
        public string Detail { get { return _detail; } }
        public bool Status { get { return _status; } }

        public DateTime Created { get { return _created; } }




    }
}
