using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public enum StatusState
    {
        Complete,
        Incomplete
    }
    public class TodoItem
    {
        
        protected string title { get; set; }
        protected string detail { get; set; }
        protected string status { get; set; }

        // NOTE: Alternatively "public string status { get; protected set; }" could be used instead, in order to remove the need for methods

        public TodoItem(String title, String detail, StatusState state = StatusState.Incomplete)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
        }

        public void SetStatus(StatusState newStatus)
        {
            this.status = newStatus.ToString();
        }

        public String GetStatus()
        {
            return this.status;
        }

        public String GetDetail()
        {
            return this.detail;
        }

        public String GetTitle()
        {
            return this.title;
        }
    }
}
