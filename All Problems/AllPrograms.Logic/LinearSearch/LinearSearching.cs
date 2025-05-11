namespace LinearSearch
{
    public class LinearSearching
    {
        public static int Search(int[] nums, int k)
        {
            for(int i = 0;i< nums.Length; i++)
            {
                if(nums[i] == k)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
