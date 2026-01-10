using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurssionPrograms
{
    public class RecursiveSumOfFirstN
    {
        //Paramterized Way
        public static int PrintRecursiveSumOfFirstN(int n, int sum)
        {
            if(n <= 0)
            {
                return sum;
            }
            return PrintRecursiveSumOfFirstN(n-1, sum+n);
        }

        //Functional Way
        public static int PrintRecursiveSumOfFirstNFunctional(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            return n + PrintRecursiveSumOfFirstNFunctional(n - 1);
        }
    }
}
