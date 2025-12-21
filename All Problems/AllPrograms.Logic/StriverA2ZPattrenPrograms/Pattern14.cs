using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern14
    {
        public static void PrintPattern14(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)('A' + j - 1)+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
