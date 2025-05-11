namespace SingleNumberInArray
{
    public class Solution
    {
        public static int SingleNumberMethod1(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (pair.Value == 1)
                {
                    return pair.Key;
                }
            }
            return -1;
        }

        public static int SingleNumberMethod2(int[] nums)
        {
            int xor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i];
            }
            return xor;
        }
    }
}
