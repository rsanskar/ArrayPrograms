using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriversA2ZBasicMathPrograms
{
    public class PalindromNumber
    {
        public static bool IsPalindrome(int num)
        {
            return num == revNumber(num);
        }
        public static int revNumber(int num)
        {
            int rev = 0;
            while(num!=0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            return rev;
        }
    }
}
