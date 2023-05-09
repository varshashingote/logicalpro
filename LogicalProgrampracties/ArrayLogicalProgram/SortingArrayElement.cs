using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class SortingArrayElement
    {
        public void sort()
        {
            int temp=0;
            int[] arr = { 6,4,3,2,1};
            for(int i=0;i<arr.Length;i++)
            {
                for (int j = i+1; j <arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {


                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    
                }
            }
            Console.WriteLine("Asending Array");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
      
            }
        }
        public void desending()
        {
            int temp = 0;
            int[] arr = { 6, 4, 3, 2, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {


                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            Console.WriteLine("desending Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }
    }
}
