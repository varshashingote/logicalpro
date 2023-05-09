using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class FibonacciSeries
    {
        int n1 = 1, n2 = 1, n3;
        public void Fibonacci()
        {
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1+"\n"+n2);
            for(int i=1;i<=n;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(""+n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
