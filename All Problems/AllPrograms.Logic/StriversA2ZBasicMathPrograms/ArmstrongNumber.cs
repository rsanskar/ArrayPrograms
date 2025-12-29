using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriversA2ZBasicMathPrograms
{
    public class ArmstrongNumber
    {
        public static bool IsArmSTrongNumber(int num)
        {
            int count = CountDigits(num);

            return num == CalculateArmstrong(num, count);

        }

        private static int CalculateArmstrong(int num, int count)
        {
            int sum = 0;
            while(num != 0)
            {
                int digit = num % 10;
                sum = (int)(Math.Pow(digit, count)) + sum;
                num = num / 10;
            }
            return sum;
        }

        private static int CountDigits(int num)
        {
            int count = 0;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }
    }
}
