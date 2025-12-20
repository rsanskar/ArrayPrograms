using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern8
    {
        public static void PrintPattern8(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                //Spaces
                for(int j = 1; j <=n-i; j++)
                {
                    Console.Write(" ");
                }
                //Stars
                for(int j = 2 * i - 1; j>=1 ; j--)
                {
                    Console.Write("*");
                }
                //Spaces
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
