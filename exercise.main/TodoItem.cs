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
        private bool _status;
        private DateTime _time;

        public TodoItem(String title, String detail, bool status)
        {
            this._time = DateTime.Now;
            this._title = title;
            this._detail = detail;
            this._status = status;
        }

        public DateTime Time { get; }


        //Setting status:
        public void setStatus(bool status)    // f.eks. setCompleted / setIncompleted
        {
            this._status = status;
        }

        //Getting statis
        public bool getStatus()
        {
            return this._status;
        }
    }
}
