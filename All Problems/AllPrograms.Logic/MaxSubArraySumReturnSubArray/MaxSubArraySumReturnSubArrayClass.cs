namespace MaxSubArraySumReturnSubArray
{
    public class MaxSubArraySumReturnSubArrayClass
    {
        public static int[] MaxSubArraySumReturnSubArrayMethod1(int[] array)
        {
            List<int> list = new List<int>();
            List<int> maxList = new List<int>();
            int currentSum = 0;
            int maxSubArraySum = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
                currentSum += array[i];
                if (currentSum > maxSubArraySum)
                {
                    maxSubArraySum = currentSum;
                    maxList.Clear();
                    maxList.AddRange(list);
                }
                if(currentSum < 0)
                {
                    currentSum = 0; 
                    list.Clear();
                }
            }
            return maxList.ToArray();
        }
        public static int[] MaxSubArraySumReturnSubArrayMethod2(int[] array)
        {
            List<int> list = new List<int>(); 
            int start = 0;
            int ansStart = 0, ansEnd = 0;
            int currentSum = 0;
            int maxSubArraySum = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if(currentSum == 0)
                {
                    start = i;
                }
                currentSum += array[i];
                if (currentSum > maxSubArraySum)
                {
                    maxSubArraySum = currentSum;
                    ansStart = start;
                    ansEnd = i;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }
            for(int i = ansStart; i<= ansEnd; i++)
            {
                list.Add(array[i]);
            }
            return list.ToArray();
        }
    }
}
