namespace SearchInsertPosition
{
    public class SearchInsertPositionClass
    {
        public static int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        private static int BinarySearch(int[] nums, int low, int high, int target)
        {

            int index = nums.Length;
            if (low > high)
            {
                return -1;
            }
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    index = mid;
                    return index;
                }
                else if (nums[mid] > target)
                {
                    index = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return index;
        }

    }
}
