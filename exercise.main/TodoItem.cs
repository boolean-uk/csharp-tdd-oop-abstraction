using Microsoft.VisualBasic;
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
        public string status { get; protected set; }
        private readonly DateTime creationDateTime;

        public TodoItem(String title, String detail, DateTime creationDateTime)
        {
            this.title = title;
            this.detail = detail;
            this.status = "incomplete";
            this.creationDateTime = creationDateTime;
        }

        public string toComplete()
        {
            return this.status = "complete";
        }

        public string toIncomplete()
        {
            return this.status = "incomplete";
        }

        public bool isComplete()
        {
            if (this.status == "complete")
            { return true; }
            else
            {
                return false;
            }
        }

        public string DateAndTime
        {
            get { return creationDateTime.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

  

        public string getTitle()
        {
            return this.title;
        }

      

        public string getDetail()
        {
            return this.detail;
        }

    }
}
