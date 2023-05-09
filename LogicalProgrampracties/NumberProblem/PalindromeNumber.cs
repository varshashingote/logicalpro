using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class PalindromeNumber
    {
        public void palindrome()
        {
            int rev = 0;
          
            Console.WriteLine("Enter a Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while(temp > 0)
            {
                rev = rev*10 + temp % 10;
                temp = temp / 10;
            }
            if (rev == n)
            {
                Console.WriteLine("  number is {0} reverse number{1} number is palindrome",n,rev);
            }
            else
            {
                Console.WriteLine("number is{0} rev is{1} number is not palindrome",n,rev);
            }
        }
    }
}
