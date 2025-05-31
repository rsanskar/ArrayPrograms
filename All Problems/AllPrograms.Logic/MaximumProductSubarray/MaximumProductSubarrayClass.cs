namespace MaximumProductSubarray
{
    public class MaximumProductSubarrayClass
    {
        public static int FindMaxProduct(int[] array)
        {
            int n = array.Length;
            int maxProd = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int prod = 1;
                for (int j = i; j < array.Length; j++)
                {
                    prod *= array[j];
                    maxProd = Math.Max(prod,maxProd);
                }
            }
            return maxProd;
        }

        public static int FindMaxProductMethod1(int[] nums)
        {
            int n = nums.Length;
            int prefix = 1;
            int suffix = 1;
            int maxProd = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (prefix == 0)
                {
                    prefix = 1;
                }
                if (suffix == 0)
                {
                    suffix = 1;
                }
                prefix = prefix * nums[i];
                maxProd = Math.Max(prefix, maxProd);
                suffix = suffix * nums[n - i - 1];
                maxProd = Math.Max(maxProd, suffix);
            }
            return maxProd;
        }

    }
}
