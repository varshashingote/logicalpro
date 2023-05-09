using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.StringLogicalProgram
{
    public class StringPalindrom
    {
        public void palindromestring()
        {
            string rev=" ";
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            for(int i = str.Length; i >= 0; i++)
            {
                rev = rev +str[i].ToString();
            }
            if(rev== str)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
    }
}
