using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriversA2ZBasicMathPrograms
{
    public class ReverseOfNumber
    {
        public static int Reverse(int x)
        {
            int reverse = 0, rem = 0;
            while (x != 0)
            {
                rem = x % 10;
                x = x / 10;
                if (reverse > int.MaxValue / 10 || (reverse == int.MaxValue / 10 && x > 7))
                {
                    return 0;
                }
                if (reverse < int.MinValue / 10 || (reverse == int.MinValue / 10 && x < -8))
                {
                    return 0;
                }
                reverse = reverse * 10 + rem;
            }
            return reverse;
        }
    }
}
