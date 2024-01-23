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
        private string _description; 
        private bool _isDone;
        private DateTime _date;

        public string Title { get { return _title; } set { setTitle(value); } }
        public string Description { get { return _description; } set { setDescription(value); } }
        public bool IsDone { get { return _isDone; } }
        public string Date {get { return _date.ToString("yyyy-MM-dd HH:mm:ss"); } } 

        public TodoItem(String title, String detail, bool isDone)
        {
            _title = title;
            _description = detail;
            _isDone = isDone;
            _date = DateTime.Now;
        }
        private void setDescription(string description)
        {
            _description = description;
            
        }
        public void SetDone()
        {
            _isDone = true;
        }
        public void SetNotDone() {
            _isDone = false;
        }
        public void SetInCompleat(bool state) {
            _isDone = state;
        }

        private void setTitle(string title) {
            _title = title;
        }

        public void ChangeIsDone()
        {
            throw new NotImplementedException();
        }
    }
}
