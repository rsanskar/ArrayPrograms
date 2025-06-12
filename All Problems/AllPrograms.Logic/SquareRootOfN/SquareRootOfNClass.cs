namespace SquareRootOfN
{
    public class SquareRootOfNClass
    {
        public static int FindSquareRootOfn(int num)
        {
            int squareRoot = 1;
            for (int i = 1; i < num; i++)
            {
                if(i*i<=num)
                {
                    squareRoot = i;
                }
            }
            return squareRoot;
        }
        public static int FindSquareRootOfnUsingBS(int num)
        {
            int squareRoot = 1;
            int low = 1;
            int high = num;
            if (num == 0 || num == 1) return num;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (mid * mid <= num)
                {
                    squareRoot = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return squareRoot;
        }
    }
}
