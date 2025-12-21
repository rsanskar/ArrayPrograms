using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern12
    {
        public static void PrintPattern12(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int j = 1; j <= 2*n-2*i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
