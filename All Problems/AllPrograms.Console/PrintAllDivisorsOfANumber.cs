using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms.Console
{
    public class PrintAllDivisorsOfANumber
    {
        public static List<int> PrintDivisors(int num)
        {
            List<int> result = new List<int>();
            for (int i = 1; i*i <= num; i++)
            {
                if (num % i == 0)
                {
                    result.Add(i);
                    if (num / i != i)
                        result.Add(num / i);
                }
            }
            return result;
        }
    }
}
