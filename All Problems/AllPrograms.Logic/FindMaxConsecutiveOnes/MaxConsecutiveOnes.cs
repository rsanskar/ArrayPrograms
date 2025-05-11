namespace FindMaxConsecutiveOnes
{
    public class MaxConsecutiveOnes
    {
        public static int FindMax1s(int[] nums)
        {
            int max1s = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                if (nums[i] == 1)
                {
                    for (int j = i; j < nums.Length && nums[j] == 1; j++)
                    {
                        count++;
                    }
                }
                if(count> max1s)
                {
                    max1s = count;
                }
            }
            return max1s >0? max1s+ 1: 0;
        }
    }
}
