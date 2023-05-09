using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class FoundNoinArray
    {
        public void Frequency()
        {
            Console.WriteLine("Hello, World!");
            int[,] arr = new int[3, 3] { { 3, 12, 9 }, { 5, 2, 89 }, { 90, 45, 22 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] == 90)
                    {
                        Console.WriteLine("Found element at {0} row and {1} column", i + 1, j + 1);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
