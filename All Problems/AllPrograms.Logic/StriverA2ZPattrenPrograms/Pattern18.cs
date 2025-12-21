using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern18
    {
        public static void PrintPattern18(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j < n; j++)
                {
                    Console.Write((char)('A' + j));
                }
                Console.WriteLine();
            }
        }
    }
}
