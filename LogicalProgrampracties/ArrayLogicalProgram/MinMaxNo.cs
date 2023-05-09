using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.ArrayLogicalProgram
{
    public class MinMaxNo
    {
        public void MinMax()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int min=array[0];
            int max = array[0];
            for(int i=0;i<array.Length;i++)
            {
                if (max < array[i])
                {
                    max = array[i];
            
                }
                if (min > array[i])
                {
                    min = array[i];
                   
                }

            }
            Console.WriteLine("Maximum is"+max);
            Console.WriteLine("Minimum is"+min);

        }
    }
}
