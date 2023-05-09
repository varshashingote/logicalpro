using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class SumArrayElement
    {
        public void SumOfArry()
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            for(int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];

            }
            Console.WriteLine("Sum Of Array Element:"+sum);
        }
    }
}
