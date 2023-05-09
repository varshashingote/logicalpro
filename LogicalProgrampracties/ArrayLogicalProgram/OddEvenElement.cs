using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class OddEvenElement
    {
        public void EvenOdd()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 12, 32, 33, 54 };
            Console.WriteLine("Even number");
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine("Odd Number");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }




        }
    }
}
