using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class FrequencyofElement
    {
        public void feqword()
        {
            int[] arr = { 1, 2, 3, 4, 6 ,6,5,4,3,};
            bool[] visited = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (visited[i] == true)
                {
                    continue;
                }
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }


                }
                Console.WriteLine(arr[i] + " " + count);
            }
        }

    }
}
