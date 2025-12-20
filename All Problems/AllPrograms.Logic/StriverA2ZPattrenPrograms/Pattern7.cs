using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern7
    {
        public static void PrintPattern7(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                //Spaces
                for(int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                //stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                //Spaces
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
