using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern17
    {
        public static void PrintPattern17(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2*i-1; j++)
                {
                    var chare = j>i? 'A' + (2 * i - j - 1) : ('A' + j - 1);

                    Console.Write((char)chare);
                }
                Console.WriteLine();
            }
        }
    }
}
