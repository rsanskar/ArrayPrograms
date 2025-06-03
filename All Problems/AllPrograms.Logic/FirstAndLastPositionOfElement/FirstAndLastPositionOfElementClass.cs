namespace FirstAndLastPositionOfElement
{
    public class FirstAndLastPositionOfElementClass
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return [-1, -1];
            }
            int lb = LowerBound(nums, target);
            int up = UpperBound(nums, target);
            if (lb == nums.Length || nums[lb] != target)
            {
                return [-1, -1];
            }
            return [lb, up - 1];
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

    }
}
