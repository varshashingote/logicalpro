using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.StringLogicalProgram
{
     public class FindDuplicateElement
     {
        public void FindDuplicate()
        {
            string str = "varsha";
            char[] arr = str.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        Console.WriteLine("Element is Found:" +arr[j]);
                    }
                }

            }

        }

        
    }
}
