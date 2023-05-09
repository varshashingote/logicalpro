using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.StringLogicalProgram
{
    public class RemoveDuplicateinstring
    {
        public void RemoveDuplicateChar()
        {
            int j, i;
            string ans=" ";
            string str = "varsha";
            for( i=0;i<str.Length;i++)
            {
                for(j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        break;
                    }

                }
                if (j == i)
                {
                    ans += str[i];
                }
            }
            Console.WriteLine(ans);
        }
    
    }
}
