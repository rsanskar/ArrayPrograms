using System.Linq;

namespace CountSubArrayWithGivenSum
{
    public class CountSubArrayWithGivenSumClass
    {
        public static int CountSubArraysCount(int[] array, int k)
        {
            int n = array.Length;
            int subArrayCount = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += array[j];
                    if (sum == k)
                    {
                        subArrayCount++;
                    }
                }

            }
            return subArrayCount;
        }

        public static int CountSubArraysCountMethod2(int[] array, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            int n = array.Length;
            int prefixSum = 0;
            int subArrayCount = 0;
            for (int i = 0; i < n; i++)
            {
                prefixSum += array[i];
                int remaining = prefixSum - k;
                if (map.ContainsKey(remaining))
                {
                    subArrayCount += map[remaining];
                }
                if (map.ContainsKey(prefixSum))
                {
                    map[prefixSum]++;
                }
                else
                {
                    map[prefixSum] = 1;
                }
            }
            return subArrayCount;
        }
    }
}
