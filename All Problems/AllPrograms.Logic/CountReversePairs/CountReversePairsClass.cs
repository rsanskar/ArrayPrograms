namespace CountReversePairs
{
    public class CountReversePairsClass
    {
        public static int CountReversePairsInArray(int[] nums)
        {
            int count = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] > 2L * nums[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int MergeSort(int[] nums, int low, int high)
        {
            int count = 0;
            if (low >= high)
            {
                return count;
            }
            int mid = (low + high) / 2;
            count += MergeSort(nums, low, mid);
            count += MergeSort(nums, mid + 1, high);
            count += CountPairs(nums, low, mid, high);
            MergeArray(nums, low, mid, high);
            return count;
        }

        private static void MergeArray(int[] nums, int low, int mid, int high)
        {
            int left = low;
            int right = mid + 1;
            List<int> list = new List<int>();
            while (left <= mid && right <= high)
            {
                if (nums[left] <= nums[right])
                {
                    list.Add(nums[left]);
                    left++;
                }
                else
                {
                    list.Add(nums[right]);
                    right++;
                }
            }
            while (left <= mid)
            {
                list.Add(nums[left]);
                left++;
            }
            while (right <= high)
            {
                list.Add(nums[right]);
                right++;
            }
            for (int i = 0; i < list.Count; i++)
            {
                nums[low + i] = list[i];
            }
        }

        private static int CountPairs(int[] nums, int low, int mid, int high)
        {
            int count = 0;
            int right = mid + 1;
            for (int i = low; i <= mid; i++)
            {
                while (right <= high && nums[i] > 2 * nums[right])
                {
                    right++;
                }
                count += (right - (mid + 1));
            }
            return count;

        }
    }
}
