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

        public TodoItem(String title, String detail, String status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
        }

        public void setStatus(String status)
        {
            this._status = status;
        }

        public String getStatus()
        {
            return this._status;
        }

        public String getTitle()
        {
            return this._title;
        }

        public String getDetail()
        {
            return this._detail;
        }
    }
}
