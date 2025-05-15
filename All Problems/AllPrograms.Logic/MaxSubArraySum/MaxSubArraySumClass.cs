namespace MaxSubArraySum
{
    public class MaxSubArraySumClass
    {
        public static int MaxSubArraySumMethod1(int[] nums) //Kadane's Algorithm
        {
            int currentsum = 0;
            int n = nums.Length;
            int maxSum = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                currentsum += nums[i];
                if (currentsum > maxSum)
                {
                    maxSum = currentsum;
                }
                if (currentsum < 0)
                {
                    currentsum = 0;
                }           

            }

            return maxSum;
        }

        public static int MaxSubArraySumMethod2(int[] nums) //Kadane's Algorithm
        {
            int maxSubArraySum = int.MinValue;
            int n = nums.Length;
            for(int i =0; i < n; i++)
            {
            int currentSum = 0;
                for(int j = i; j < n; j++)
                {
                    currentSum += nums[j];
                    if(currentSum > maxSubArraySum)
                    {
                        maxSubArraySum = currentSum;
                    }
                }
            }
            return maxSubArraySum;
        }
    }
}
