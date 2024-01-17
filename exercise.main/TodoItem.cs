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
        private string status;
        private readonly DateTime creationDateTime;

        public TodoItem(String title, String detail, String status, DateTime creationDateTime)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
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


        public string getStatus()
        {
            return this.status;
        }


        public string getTitle()
        {
            return this.title;
        }

        /*public void setDetail(String status)
        {
            this.detail = detail;
        }*/
      

        public string getDetail()
        {
            return this.detail;
        }

    }
}
