using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class RemoveDuplicate
    {
        public void RemoveDuplicateElement()
        {
            int[] arr = { 1, 7, 2, 3, 4, 5, 7, 4, 2, 3, 4, 4, 5, };
            int[] temp = new int[arr.Length];
            int j = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    temp[j++] = arr[i];
                }
            }
            temp[j++] = arr[arr.Length - 1];
            for(int i=0;i<j; i++)
            {
                Console.Write(temp[i]+" ");
            }
        }
    }
   
}
