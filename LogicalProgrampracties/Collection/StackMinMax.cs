using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class StackMinMax
    {
        public void MinMaxno()
        {
            Stack<int>sc=new Stack<int>();
            sc.Push(10);
            sc.Push(20);
            sc.Push(30);
            sc.Push(40);
            foreach(var i in sc)
            {
                Console.WriteLine(i);
            }
          
            int[] arr=sc.ToArray();
            int max = arr[0];
            int min = arr[0];

            for(int i = 0; i <arr.Length; i++)
            {
      
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                
            }
            Console.WriteLine("maximum no is"+max);
            Console.WriteLine("Minimum no is"+min);

        }
    }
}
