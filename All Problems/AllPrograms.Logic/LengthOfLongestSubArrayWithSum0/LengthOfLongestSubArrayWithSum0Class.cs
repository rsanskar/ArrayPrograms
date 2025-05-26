namespace LengthOfLongestSubArrayWithSum0
{
    public class LengthOfLongestSubArrayWithSum0Class
    {
        public static int FindLongestSubArrayLength(int[] array)
        {
            int n = array.Length;
            int longestSubArray = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                int length = 0;
                for (int j = i; j < n; j++)
                {
                    sum += array[j];
                    length++;
                    if (sum == 0)
                    {
                        longestSubArray = Math.Max(longestSubArray, length);
                    }
                }
            }
            return longestSubArray;
        }

        public static int FindLongestSubArrayLengthMethod2(int[] array)
        {
            int n = array.Length;
            int longestSubArray = 0;
            int length = 0;
            int prefixSum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                prefixSum += array[i];
                if (prefixSum == 0)
                {
                    longestSubArray = Math.Max(i + 1, length);
                }
                int remaining = prefixSum - 0;
                if (map.ContainsKey(remaining))
                {
                    length += map[remaining];
                    longestSubArray = Math.Max(i - map[remaining],length);
                }
                if(!map.ContainsKey(remaining))
                {
                    map[prefixSum] = i;
                }
            }
            return longestSubArray;
        }
    }
}

