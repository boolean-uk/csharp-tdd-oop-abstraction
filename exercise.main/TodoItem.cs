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
        private bool isDone;

        private int date;
        private int time;

        public TodoItem()
        {
            this.title = "";
            this.detail = "";
            this.date = 0;
            this.time = 0;
            this.isDone = false;
        }

        public bool AddTask(String title, String detail, int date, int time, bool isDone = false)
        {
            if (title == "")
                return false;

            if (detail == "")
                return false;

            if (date > 31)
                return false;

            if (time > 12)
                return false;

            this.title = title;
            this.detail = detail;
            this.date = date;
            this.time = time;
            this.isDone = isDone;
            return true;
        }

        public bool SetTaskComplete()
        {
            isDone = true;
            return isDone;
        }

        public bool SetTaskIncomplete()
        {
            isDone = false;
            return isDone;
        }

        public bool IsTaskDone()
        {
            return isDone;
        }

        public bool AddDetails(string message)
        {
            if (message == "")
                return false;

            message += detail;
            return true;
        }

        public void PrintDataAndTime()
        {
            Console.WriteLine("Day " + date.ToString() + "\nTime " + time.ToString());
        }
    }
}