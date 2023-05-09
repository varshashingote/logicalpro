using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class CopyArray
    {
        public void Copy()
        {
            int[] arr2 = new int[10];
            int[] arr = { 1, 2, 3, 5, 6, 2 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    arr2[i] = arr[i];
                }
            }
            Console.WriteLine("Array is copied");
            for (int i = 0; i < arr.Length; i++)
            { 
                Console.WriteLine(arr2[i]);
            }
        }

    }
}
