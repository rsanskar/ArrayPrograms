namespace MajorityElementNby3
{
    public class MajorityElementNby3Class
    {
        public static IList<int> MajorityElement(int[] nums)
        {
            List<int> list = new List<int>();
            int n = nums.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;

                }
                else
                {
                    dict.Add(nums[i], 1);
                }
                if (dict[nums[i]] == (n / 3) + 1)
                {
                    list.Add(nums[i]);
                }
            }
            //foreach (KeyValuePair<int, int> pair in dict)
            //{
            //    if (pair.Value > n / 3)
            //    {
            //        list.Add(pair.Key);
            //    }
            //}
            return list;
        }

        public static IList<int> MajorityElementMethod1(int[] nums)
        {
            List<int> list = new List<int>();
            int n = nums.Length;
            int ele1 = int.MinValue, count1 = 0;
            int ele2 = int.MinValue, count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (count1 == 0 && ele2 != nums[i])
                {
                    ele1 = nums[i];
                    count1 = 1;
                }
                else if (count2 == 0 && ele1 != nums[i])
                {
                    ele2 = nums[i];
                    count2 = 1;
                }
                else if (ele1 == nums[i])
                {
                    count1++;
                }
                else if (ele2 == nums[i])
                {
                    count2++;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }
            count1 = 0;
            count2 = 0;
            foreach (int ele in nums)
            {
                if (ele == ele1)
                {
                    count1++;
                }
                else if (ele == ele2)
                {
                    count2++;
                }
            }
            if (count1 > (n / 3))
            {

                list.Add(ele1);
            }
            if (count2 > (n / 3))
            {

                list.Add(ele2);
            }
            return list;
        }
    }
}
