namespace FindMaxConsecutiveOnes
{
    public class MaxConsecutiveOnes
    {
        public static int FindMax1sMethod1(int[] nums)
        {
            int max1s = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = i; j < nums.Length && nums[j] == 1; j++)
                {
                    count++;
                }
                if (count > max1s)
                {
                    max1s = count;
                }
                i += count > 0 ? count - 1 : 0;
            }
            return max1s;
        }

        public static int FindMax1sMethod2(int[] nums)
        {
            int j = 0;
            int i = 0;
            int max1s = 0;
            while (i < nums.Length && j < nums.Length)
            {
                if (nums[i] == 1)
                {
                    j++;
                }
                else
                {
                    j = 0;
                }
                if (j > max1s)
                {
                    max1s = j;
                }
                i++;
            }
            return max1s;
        }
    }
}
