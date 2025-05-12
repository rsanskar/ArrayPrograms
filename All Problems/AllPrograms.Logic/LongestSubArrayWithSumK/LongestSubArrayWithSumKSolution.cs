namespace LongestSubArrayWithSumK
{
    public class LongestSubArrayWithSumKSolution
    {
        public static int FindLongestSubArrayWithSumKMethod1(int[] nums, int k)
        {
            int lsalength = 0;
            int salength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (sum == k)
                        salength = j - i + 1;
                }
                lsalength = Math.Max(lsalength, salength);
            }

            return lsalength;
        }

        public static int FindLongestSubArrayWithSumKMethod2(int[] nums, int k) // works for positives and negitives
        {
            int n = nums.Length;
            long prefixSum = 0;
            int maxLength = 0;
            Dictionary<long, int> map = new Dictionary<long, int>();
            for (int i = 0; i < n; i++)
            {
                prefixSum += nums[i];

                if (prefixSum == k)
                {
                    maxLength = Math.Max(i + 1, maxLength);
                }

                long remaining = prefixSum - k;
                if (map.ContainsKey(remaining))
                {
                    maxLength = Math.Max(i - map[remaining], maxLength);
                }

                if (!map.ContainsKey(prefixSum))
                {
                    map.Add(prefixSum, i);
                }
            }

            return maxLength;
        } 

        public static int FindLongestSubArrayWithSumKMethod3(int[] nums, int k) // Works only for positives
        {
            int i = 0;
            int j = 0;
            int sum = 0;
            int maxLength = 0;
            while (j < nums.Length)
            {
                sum += nums[j];

                while (sum > k && i <= j)
                {
                    sum -= nums[i];
                    i++;
                }

                if (sum == k)
                {
                    maxLength = Math.Max(j - i + 1,maxLength);
                }
                j++;
            }

            return maxLength;
        }

    }
}
