using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.StringLogicalProgram
{
    public class SeprateIndiviualCharacter
    {
        public void SeprateIndiviualChar()
        {
            string str = "varsha";
            int l = 0;
            while(l <=str.Length - 1)
            {
                Console.WriteLine("{0}",str[l]);
                l++;
            }
        }
    }
}
