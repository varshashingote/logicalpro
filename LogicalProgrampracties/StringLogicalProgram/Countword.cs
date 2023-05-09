using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.StringLogicalProgram
{
    public class Countword
    {
        public void word()
        {
            string str = "varsha Bhima Gunjal";
            int l=0;
            int wrd = 1;
            while (l <=str.Length - 1)
            {
                if (str[l]== ' ' || str[l]=='\t' || str[l]=='\n') 
                {
                    wrd++;
                }
                l++;
            }
            Console.WriteLine("Total Number of word"+wrd);
        }
    }
}
