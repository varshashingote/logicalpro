using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    public class FibonaacciSeriresTriangle
    {
        int n1 = 0, n2 =1, n3;
        public void FibTraingle()
        {


            Console.WriteLine("Enter the limit");
            int n = Convert.ToInt32(Console.ReadLine());
           for(int i=0;i<=n;i++)
            {
                n1 = 0;
                n2 = 1;
                Console.Write(n2+"\t");
                for(int j = 1; j <= i; j++)
                {
                    n3 = n1 + n2;
                    Console.Write(n3+"\t");
                    n1 = n2;
                    n2 = n3;
                }
                Console.WriteLine("\n");
            }
        }
        }
    }
