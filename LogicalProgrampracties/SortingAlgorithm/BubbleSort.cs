using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.SortingAlgorithm
{
    public class BubbleSort
    {
        public void B_sort()
        {
            int temp;
            int[] arr = { 1, 2, 34, 32, 22, 11 };

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }

            Console.WriteLine("Sorted Element are using Bubble sort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
        }


    }
}
