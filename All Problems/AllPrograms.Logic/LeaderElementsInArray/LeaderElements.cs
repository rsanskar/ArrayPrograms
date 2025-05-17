namespace LeaderElementsInArray
{
    public class LeaderElements
    {
        public static int[] FindLeaderElements(int[] nums)
        {
            int n = nums.Length;
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                bool isLeader = true;
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        isLeader = false;
                        break;
                    }
                }
                if (isLeader)
                {
                    result.Add(nums[i]);
                }
            }
            return result.ToArray();
        }
        public static int[] FindLeaderElementsMethod2(int[] nums)
        {
            int n = nums.Length;
            List<int> result = new List<int>();
            int maxEle = int.MinValue;
            for (int i = n-1; i >= 0; i--)
            {
                if (nums[i] > maxEle)
                {
                    maxEle = Math.Max(maxEle, nums[i]);
                    result.Add(nums[i]);
                }
            }
            return result.ToArray();
        }

    }
}
