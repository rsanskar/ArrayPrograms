namespace MajorityElement
{
    public class MajorityElementClass
    {
        public static int FindMajorityElementMethod1(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                if (count > n / 2)
                {
                    return nums[i];
                }
            }
            return -1;
        }

        public static int FindMajorityElementMethod2(int[] nums)
        {
            int n = nums.Length;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map.Add(nums[i], 1);
                }

            }
            foreach (KeyValuePair<int, int> pair in map)
            {
                if (pair.Value > n / 2)
                {
                    return pair.Key;
                }
            }
            return -1;
        }

        public static int FindMajorityElementMethod3(int[] nums)
        {
            int count = 0;
            int majorityEle = int.MinValue;
            for(int i = 0; i< nums.Length; i++)
            {
                if(count == 0)
                {
                    majorityEle = nums[i];
                }
                count = (majorityEle == nums[i])?count+1: count-1;
            }
            count = 0;
            foreach (int num in nums)
            {
                if (num == majorityEle) count++;
            }

            return count > nums.Length / 2 ? majorityEle : -1;
        }

    }
}
