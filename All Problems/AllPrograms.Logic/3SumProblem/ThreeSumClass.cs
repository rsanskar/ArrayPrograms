using System.Linq;

namespace _3SumProblem
{
    public class ThreeSumClass
    {
        public static IList<IList<int>> FindTripletsMethod1(int[] nums)
        {
            int n = nums.Length;
            IList<IList<int>> listOfLists = new List<IList<int>>();
            HashSet<string> listSet = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> triplet = new List<int> { nums[i], nums[j], nums[k] };
                            triplet.Sort();
                            string key = string.Join(",", triplet); // e.g., "-1,0,1"
                            if (!listSet.Contains(key))
                            {
                                listSet.Add(key);
                                listOfLists.Add(triplet);
                            }
                        }
                    }
                }
            }

            return listOfLists;

        }

        public static IList<IList<int>> FindTripletsMethod2(int[] nums)
        {
            IList<IList<int>> listOfLists = new List<IList<int>>();
            HashSet<string> hashstrings = new HashSet<string>();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                HashSet<int> set = new HashSet<int>();
                for (int j = i + 1; j < n; j++)
                {
                    if (set.Contains(-(nums[i] + nums[j])))
                    {
                        List<int> list = new List<int> { nums[i], nums[j], -(nums[i] + nums[j]) };
                        list.Sort();
                        string str = string.Join(",", list);
                        if (!hashstrings.Contains(str))
                        {
                            listOfLists.Add(list);
                            hashstrings.Add(str);
                        }
                    }
                    set.Add(nums[j]);
                }
            }
            return listOfLists;
        }

        public static IList<IList<int>> FindTripletsMethod3(int[] nums)
        {
            IList<IList<int>> listOfLists = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] == 0)
                    {
                        List<int> list = new List<int> { nums[i], nums[left], nums[right] };
                        listOfLists.Add(list);
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }
                    }
                    else if (nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;

                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return listOfLists;
        }
    }
}
