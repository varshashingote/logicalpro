using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.StringLogicalProgram
{
    public class SortStringInAlphabiticalOrder
    {
        public void AlphabiticalOrder()

        {
          char temp;
            string mystr = "varsha";
            string str=mystr.ToLower();
            char[] arr=str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
                Console.WriteLine(arr);
            
            
        }

    }
}
