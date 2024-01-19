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
        public bool IsDone;
        private DateTime _date;

        public DateTime Date { get { return _date; }}

        public string Title { get { return _title; }}
        public string Detail { get { return _detail; }}


        public TodoItem(String title, String detail, bool isDone)
        {
            this._title = title;
            this._detail = detail;
            this.IsDone = isDone;
            this._date = DateTime.Now;
        }
    }
}
