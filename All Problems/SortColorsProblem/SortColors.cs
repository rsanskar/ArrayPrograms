namespace SortColorsProblem
{
    public class SortColors
    {
        public static void SortColorsMethod1(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
            }
            int count = 0;
            for (int i = 0; i <= 2; i++)
            {
                int value = 0;
                if (dict.ContainsKey(i))
                {
                    value = dict[i];
                }
                for (int j = 0; j < value; j++)
                {
                    nums[count] = i;
                    count++;
                }
            }
        }

        public static void SortColorsMethod2(int[] nums) // Dutch National flag algorithm
        {
            int low = 0, mid = 0, high = nums.Length - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    int temp = nums[mid];
                    nums[mid] = nums[low];
                    nums[low] = temp;
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = nums[high];
                    nums[high] = nums[mid];
                    nums[mid] = temp;
                    high--;
                }
            }
        }
    }
}
