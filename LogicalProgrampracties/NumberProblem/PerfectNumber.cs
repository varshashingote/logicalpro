using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class PerfectNumber
    {
        public void perferctNo()
        {
            int sum = 0;
            Console.WriteLine("Enter the Number");
            int temp = Convert.ToInt32(Console.ReadLine());
            int n= temp;   
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == temp)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not perfect Number");
            }
        }
    }
}
