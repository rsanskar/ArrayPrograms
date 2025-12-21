using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern20
    {
        public static void PrintPattern20(int n)
        {
            var spaces = 2 * n - 2;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = spaces; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                spaces -= 2;
                Console.WriteLine();
            }
            spaces = 2;
            for (int i = 1; i <= n-1; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("*");
                }
                spaces += 2;
                Console.WriteLine();
            }
        }
    }
}
