using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class PrimeNumber
    {
        public void prime()
        {
            
            int count=0;
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
                if (count==2)
                {
                    Console.WriteLine("Prime Number");
                }
                else
                {
                    Console.WriteLine("number is Not prime");
                }

            
        }
    }
}
