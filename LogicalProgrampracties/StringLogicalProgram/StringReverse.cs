using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.StringLogicalProgram
{
    public class StringReverse
    {
        public void stringRev()
        {
            string str = "varshagunjal";
            string rev=" ";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev+str[i].ToString();
            }
            Console.WriteLine("Reverse String is"+rev);
        }
    }
}
