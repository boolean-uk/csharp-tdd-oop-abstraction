using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{

    public enum TodoStatus {
        DONE,
        NOT_DONE
    }
    public class TodoItem
    {
        private string _title;
        private string _detail;
        public TodoStatus Status;
        private DateTime _date;

        public DateTime Date { get { return _date; }}

        public string Title { get { return _title; }}
        public string Detail { get { return _detail; }}


        public TodoItem(String title, String detail, TodoStatus status)
        {
            this._title = title;
            this._detail = detail;
            this.Status = status;
            this._date = DateTime.Now;
        }

        public bool UpdateTitle(string NewTitle) {
            _title = NewTitle;
            return true;
        }
        public bool UpdateDescription(string NewDescription) {
            _detail = NewDescription;
            return true;
        }
    }
}
