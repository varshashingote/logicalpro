using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.StringLogicalProgram
{
    public  class RemoveSpecialChar
    {
        public void removespecialchar()
        {
            string str = "varsgaj@#%@@w";
            string[] ch= new string[]{ "!","@","#","$","%","^","&","*",".","?","<",">","~" };
            for(int i=0;i<ch.Length;i++)
            {
                if (str.Contains(ch[i]))
                {
                    str = str.Replace(ch[i],"");
                }
            }

            Console.WriteLine(str);
           
          
        }

    }
}
