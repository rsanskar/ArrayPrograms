using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern10
    {
        //public static void PrintPattern10(int n)
        //{
        //    for (int i = 1; i <= 2*n-1; i++)
        //    {
        //        if(i<=n)
        //        {
        //            for (int j = 1; j <= i; j++)
        //            {
        //                Console.Write("*");
        //            }
        //        }
        //        else
        //        {
        //            for (int j = 2*n-i; j >= 1; j--)
        //            {
        //                Console.Write("*");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

        public static void PrintPattern10(int n)
        {
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                var stars = i <= n ? i : 2 * n - i;
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
