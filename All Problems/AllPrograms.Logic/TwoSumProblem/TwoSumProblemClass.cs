namespace TwoSumProblem
{
    public class TwoSumProblemClass
    {
        public static int[] TwoSumMethod1(int[] nums, int target)
        {
            int[] result = new int[2];
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
        public static int[] TwoSumMethod2(int[] nums, int target) 
        {
            int[] result = new int[2];
            int n = nums.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int resultt = target - nums[i];
                if (dict.ContainsKey(resultt))
                {
                    result[0] = i;
                    result[1] = dict[resultt];
                    return result;
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}
