using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurssionPrograms
{
    public class Print1toN
    {
        /// <summary>
        /// This method is used Back Tracking
        /// </summary>
        /// <param name="num"></param>
        public static void print1toNFunction(int num)
        {
            if (num <= 0)
            {
                return;
            }
            print1toNFunction(num - 1);
            Console.WriteLine(num);

        }

        public static void Print1toNFuncton2(int num, int i)
        {
            if(i>num)
            {
                return;
            }
            Console.WriteLine(i);
            Print1toNFuncton2(num, i + 1);
        }
    }
}
