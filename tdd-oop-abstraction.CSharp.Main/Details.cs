using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class Details
    {
    public List<string> TodoDetails { get; set; } = new List<string>()
    {
        {"Reach lvl 60 in WoW Classic Hardcore"},
        {"Go to brother's birthday"},
        {"Vacuum the floor, water plants"},
        {"Paint Dracula bust"},
        {"Finish painting pile of shame"},
        {"Make lunch"},
        {"Go to Comedyclub"}
    };

    public bool GetItem(string details)
    {
        return TodoDetails.Contains(details);
    }
}
}
