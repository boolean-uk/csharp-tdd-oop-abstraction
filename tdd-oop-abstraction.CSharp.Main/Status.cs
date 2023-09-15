using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class Status
    {
        public Dictionary<string, bool> TaskStatus = new Dictionary<string, bool>()
        {
            {"React", false},
            {"C#", true},
            {"Python", false},
            {"CSS", false},
            {"HTML", false}
        };
    }
}
