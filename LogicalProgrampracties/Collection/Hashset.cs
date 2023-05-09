using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class Hashset
    {
        public void RemoveDuplicate()
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(2);

            hs.Add(3);
            hs.Add(4);
            hs.Add(5);
            hs.Add(3);
            hs.Add(4);
            foreach (var i in hs)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine("Remove Duplicate");
            //int[] arr = hs.ToArray();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for(int j = 0; j < arr.Length - 1; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            Console.WriteLine(arr[i]);
            //        }
            //    }
            //}

        }
    }
}
