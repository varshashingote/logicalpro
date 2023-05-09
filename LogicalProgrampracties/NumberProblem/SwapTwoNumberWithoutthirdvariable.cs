using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class SwapTwoNumberWithoutthirdvariable
    {
        public void swap()
        {
            Console.WriteLine("Enter first number");
            int n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Second Number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("after swapping  n1is{0} and n2 is{1}",n1,n2);
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine ("before swapping  n1is{0} and n2 is{1}", n1, n2);



        }
    }
}
