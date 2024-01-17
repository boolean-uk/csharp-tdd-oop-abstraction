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

        private int date;
        private int time;

        public TodoItem(String title, String detail, String status, int date, int time)
        {
            this.title = title;
            this.detail = detail;
            this.status = status;

            this.date = date;
            this.time = time;
        }

        public void SetTaskComplete()
        {
            status = "Complete";
        }

        public void SetTaskIncomplete()
        {
            status = "Incomplete";
        }

        public void PrintDataAndTime()
        {
            Console.WriteLine("Day " + date.ToString() + "\nTime " + time.ToString());
        }
    }
}