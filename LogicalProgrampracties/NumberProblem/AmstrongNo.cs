using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogicalProgrampracties
{
    public class AmstrongNo
    {
        public void findAmstrongNo()
        {
            int r = 0;
            int sum = 0;
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                r=n% 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp==sum)
            {
                Console.WriteLine("No is Amstrong");
            }
            else
            {
                Console.WriteLine("No is Not Amstrong");
            }
        }
    }
}
