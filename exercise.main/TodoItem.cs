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
        private DateTime _created;

        public TodoItem(String title, String detail, bool status)
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
            this._created = DateTime.Now;
        }

        public void PrintDateCreated()
        {
	        Console.WriteLine($"Item: {_title}, created: {_created}");
        }

        //Not as user friendly??
        //public void changeStatus()
        //{
	       // this._status = !_status;
        //}
		public void changeStatusComplete()
        {
            this._status = true;
        }
        public void changeStatusIncomplete()
        {
	        this._status = false;
        }

		public bool getStatus()
        {
            return this._status;
        }

        public void setTitle(String newTitle)
        {
            _title = newTitle;
        }
        public String getTitle()
        {
	        return _title;
        }

        public void setDetail(String newDetail)
        {
	        _detail = newDetail;
        }
        public String getDetail()
        {
	        return _detail;
        }
	}
}
