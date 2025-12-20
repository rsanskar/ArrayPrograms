using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZPattrenPrograms
{
    public class Pattern3
    {
        public static void PrintPattern3(int n)
        {
            for(int i = 1; i<=n;i++)
            {
                for(int j = 1; j<=i;j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
