using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem {
        
        private string _title;
        private string _detail;
        private string _status;
        private DateTime _creation;

        public TodoItem(String title, String detail, String status) {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._creation = DateTime.Now;
        }

        public void setStatus(String status) {
            this._status = status;
        }

        public String getStatus() {
            return this._status;
        }

        public string VisibleTitle { get { return _title; } set { _title = value; } }
        public string VisibleDetail { get { return _detail; } set { _detail = value; } }
        public string VisibleStatus { get { return _status; } set { _status = value; } }
        public DateTime VisibleCreation { get { return _creation; } }
    }
}
