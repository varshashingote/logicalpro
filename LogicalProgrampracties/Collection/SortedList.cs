using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class SortedList
    {
        public void sortedList()
        {
            SortedList<String ,int>sl= new SortedList<String ,int>();
            sl.Add("vasu", 2);
            sl.Add("shiv", 3);
            sl.Add("suraj", 4);
            sl.Add("varsha", 5);
            sl.Add("rani", 6);
            foreach(var pair in sl)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
