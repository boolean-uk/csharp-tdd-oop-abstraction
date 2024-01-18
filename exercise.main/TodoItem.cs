using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {

        private string title;
        private string detail;
        private bool status;
        DateTime created;

        public TodoItem(string title, string detail, bool status = false)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.created = DateTime.Now;
        }

        public void setComplete()
        {
            this.status = true;
        }

        public void setIncomplete()
        {
            this.status = false;
        }

        public bool isComplete() 
        {
            return this.status;
        }

        public DateTime createTime() 
        {
            throw new NotImplementedException();
        }
    }
}
