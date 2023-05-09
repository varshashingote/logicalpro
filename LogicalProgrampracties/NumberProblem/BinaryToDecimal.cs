using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class BinaryToDecimal
    {
        public void ConvertBinaryToDecimal()
        {
            int i;
            int[] arr=new int[10];
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for( i = 0; n>0; i++)
            {
                arr[i] = n % 2;
                n = n / 2;

            }
            Console.WriteLine("Binary of Given Number is");
            for( i=i-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
