using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class TodoItem
    {
        //private, meaning it can only be accessed within the TodoItem class.

        private string title;
        private string detail;
        private string status;

        //readonly, indicating that its value can only be assigned in the constructor
        private readonly DateTime creationDateTime;

        public TodoItem(String title, String detail, String status)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;
            this.creationDateTime = DateTime.Now;

        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public String getStatus()
        {
            return this.status;
        }

        //calling the getCreationDateTime method to retrieve the value of
        //creationDateTime from the TodoItem instance. 
        public DateTime getCreationDateTime()
        {
            return this.creationDateTime;
        }
    }
}
