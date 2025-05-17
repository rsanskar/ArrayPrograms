namespace RearrangeArrayElementsBySign
{
    public class RearrangeArrayElementsBySignClass
    {
        public static int[] RearrangeArray(int[] nums)
        {
            int n = nums.Length;
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    list1.Add(nums[i]);
                }
                else
                {
                    list2.Add(nums[i]);
                }
            }
            for (int i = 0; i < n / 2; i++)
            {
                nums[2*i] = list1[i];
                nums[2*i+1] = list2[i];
            }
            return nums;
        }
        public static int[] RearrangeArrayMethod2(int[] nums)
        {
            
            int n = nums.Length;
            int[] result = new int[n];
            int posStart = 0;
            int negStart = n / 2;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    result[posStart] = nums[i];
                    posStart++;
                }
                else
                {
                    result[negStart] = nums[i];
                    negStart++;
                }
            }
            int start = 0;
            int end = n / 2;
            for (int i = 0; i < n; i += 1)
            {
                if (i % 2 == 0)
                {

                    nums[i] = result[start];
                    start++;
                }
                else
                {
                    nums[i] = result[end];
                    end++;

                }

            }
            return nums;
        }

        public static int[] RearrangeArrayMethod3(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int pos = 0;
            int neg = 1;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    result[pos] = nums[i];
                    pos+=2;
                }
                else
                {
                    result[neg] = nums[i];
                    neg+=2;
                }
            }

            
            return result;
        }

        public static int[] RearrangeArrayMethod4(int[] nums)// postive numbers not equal to negitive numbers
        {
            int n = nums.Length;
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    list1.Add(nums[i]);
                }
                else
                {
                    list2.Add(nums[i]);
                }
            }
            int minLength = Math.Min(list1.Count, list2.Count);
            int index = 0;
            for (int i = 0; i < minLength; i++)
            {
                nums[index++] = list1[i];
                nums[index++] = list2[i];
            }
            if (list1.Count > list2.Count)
            {
                for (int i = minLength; i < list1.Count; i++)
                {
                    nums[index++] = list1[i];
                }
            }
            else
            {
                for (int i =minLength; i < list2.Count; i++)
                {
                    nums[index++] = list2[i];
                }
            }
            
            return nums;
        }

    }
}
