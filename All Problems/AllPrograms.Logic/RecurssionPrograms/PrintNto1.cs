using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurssionPrograms
{
    public class PrintNto1
    {
        public static void PrintNto1Function(int num)
        {
            if (num <= 0)
            {
                return;
            }
            Console.WriteLine(num);
            PrintNto1Function(num - 1);
        }
        /// <summary>
        ///This is using Backtracking
        /// </summary>
        /// <param name="num"></param>
        public static void PrintNto1Function2(int num, int i)
        {
            if(i>num)
            {
                return;
            }
            PrintNto1Function2(num, i + 1);
            Console.WriteLine(i);
        }
    }
}
