namespace ImplementLowerBound
{
    public class ImplementLowerBoundUsingBS
    {
        public static int FindLowerBound(int[] array, int target)
        {
            int n = array.Length;
            int low = 0;
            int high = n - 1;
            int lowerBound = n;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] >= target)
                {
                    lowerBound = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return lowerBound;
        }

        public static int FindLowerBoundRecursive(int[] array, int low, int high, int target, int lowerBound)
        {
            if (low > high)
                return lowerBound;

            int mid = low + (high - low) / 2;

            if (array[mid] >= target)
            {
                lowerBound = mid;
                return FindLowerBoundRecursive(array, low, mid - 1, target, lowerBound); 
            }
            else
            {
                return FindLowerBoundRecursive(array, mid + 1, high, target, lowerBound);
            }
        }

        public static int FindLowerBoundMethod1(int[] array, int target)
        {
            return FindLowerBoundRecursive(array, 0, array.Length - 1, target, array.Length);
        }

    }
}
