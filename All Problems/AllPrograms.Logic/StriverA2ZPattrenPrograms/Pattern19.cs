using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern19
    {
        public static void PrintPattern19(int n)
        {
            var spaces = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <=spaces ; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("*");
                }
                spaces += 2;
                Console.WriteLine();
            }
            spaces -=2;
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
        }
    }
}
