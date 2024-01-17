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
        private DateTime _date;

        public DateTime Date { get { return _date; }}

        public string Title { get { return _title; }}
        public string Detail { get { return _detail; }}

        public string Status { get { return _status; }}

        public TodoItem(String title, String detail, String status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._date = DateTime.Now;
        }

        public string SetStatus(bool status) {
            if(status == true) {
                _status = "Complete";
                return _status;
            } else {
                _status = "Not Complete";
                return _status;
            }
        }
    }
}
