using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class FactorialNumber
    {
        public void Fact()
        {
            int fact = 1;
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of Number is"+fact);
        }
    }
}
