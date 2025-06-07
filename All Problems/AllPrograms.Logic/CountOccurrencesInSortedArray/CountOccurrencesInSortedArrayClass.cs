namespace CountOccurrencesInSortedArray
{
    public class CountOccurrencesInSortedArrayClass
    {
        public static int CountOccurrences(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int lb = LowerBound(nums, target);
            int up = UpperBound(nums, target);
            if (lb == nums.Length || nums[lb] != target)
            {
                return 0;
            }
            return up-lb;
        }

        private static int LowerBound(int[] nums, int target)
        {
            int low = 0;
            int ans = nums.Length;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] >= target)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }

        private static int UpperBound(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int ans = nums.Length;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] > target)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;
        }


        //Method 2

        public static int CountOccurrencesMethod2(int[] array, int target)
        {
            int n = array.Length;
            int low = 0;
            int high = array.Length - 1;
            int first = -1;
            int last = - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if(array[mid] == target)
                {
                    first = mid;
                    high = mid - 1;
                }
                else if(array[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            low = 0;
            high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == target)
                {
                    last = mid;
                    low = mid +1;
                }
                else if (array[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            if(first == -1)
            {
                return 0;
            }
            return last-first+1;
        }
    }
}
