using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class Dictionary11
    {
        public void FindDictionary()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("vasu", 2);
            dic.Add("shiv", 3);
            dic.Add("varsha", 4);
            Console.WriteLine("Key present in dictionary");
            var key =new List<string>(dic.Keys);
            foreach(var keys in key)
            {
                Console.WriteLine(keys);
            }

            Console.WriteLine("value present in dictionary");
            var value = new List<int>(dic.Values);
            foreach (var val in value)
            {
                Console.WriteLine(val);
            }
        }
    }
}
