namespace _4SumProblem
{
    public class FourSumClass
    {
        public static IList<IList<int>> FindFourSumMethod1(int[] nums, int target)
        {
            int n = nums.Length;
            IList<IList<int>> listOfLists = new List<IList<int>>();
            for(int i = 0;i<n-3;i++)
            {
                HashSet<string> set = new HashSet<string>();
                for(int j = i+1; j < n; j++)
                {
                    for(int k = j+1; k < n; k++)
                    {
                        for (int l = k+1; l < n; l++)
                        {
                            if (nums[i] + nums[j] + nums[k] + nums[l] == target)
                            {
                                List<int> list = new List<int> { nums[i], nums[j], nums[k], nums[l]};
                                list.Sort();
                                set.Add(string.Join(",", list));
                                if(!set.Contains(string.Join(",", list)))
                                {
                                    listOfLists.Add(list);
                                    set.Add(string.Join(",", list));
                                }
                            }
                        }
                    }
                }

            }

            return listOfLists;
        }
    }
}
