using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class DateAndTime
    {
        public DateAndTime() { 
        
        }

        public string GetDate()
        {
            return DateTime.Now.ToString("dd.MM.yyyy");
        }
        public string GetTime()
        {
            return DateTime.Now.ToString("t");
        }
    }
}
