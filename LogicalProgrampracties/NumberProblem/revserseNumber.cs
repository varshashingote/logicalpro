using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class revserseNumber
    { 
        public void Reverse()
        {
            int rev = 0;
            Console.WriteLine("enter the Number");
            int n =Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while(temp > 0)
            {
                rev = rev * 10 + temp % 10;
                temp = temp / 10;

            }
            Console.WriteLine("Number is{0} revserse is{1}",n,rev);
        }

    }
}
