using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class FindDuplicateArray
    {
        public void FindDuplicateElement()
        {
            int count=0;
            int[] arr = { 1, 2, 3, };
            for(int i=0;i<arr.Length;i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]== arr[j])
                    {
                        count++;
                        Console.WriteLine(arr[j]);
                    }
                }

            }
            Console.WriteLine("Count Duplicate Element:"+count);

        }
    }
}
