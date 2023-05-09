using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class EvenOddArrayElement
    {
        public void FindEvenOddArrayPositionElement()
        {
            int[] arr =new int[10];
            Console.WriteLine("Enter the Array Element");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("",i);
                arr[i] =Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Array element are");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("odd position array Element are");
            for (int i = 0; i < arr.Length; i = i + 2)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Even position array Element are");
            for (int i = 1; i < arr.Length; i = i + 2)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
