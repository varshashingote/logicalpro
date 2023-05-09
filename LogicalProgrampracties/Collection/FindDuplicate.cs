using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class FindDuplicate
    {
        public void FindDuplicateElement()
        {
            List<int> dupli = new List<int>();
            dupli.Add(1);
            dupli.Add(2);
            dupli.Add(3);
            dupli.Add(4);
            dupli.Add(5);
            dupli.Add(4);
            dupli.Add(5);
            dupli.Add(6);
            dupli.Add(2);
            Console.WriteLine("integers in list");
            foreach (var item in dupli)
            {
                Console.WriteLine(item);
            }
            var names = new HashSet<int>();
            foreach (int item in dupli)
            {
                names.Add(item);
            }
            Console.WriteLine("Integers in HashSet");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
    