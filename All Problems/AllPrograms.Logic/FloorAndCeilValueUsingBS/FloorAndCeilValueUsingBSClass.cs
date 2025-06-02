namespace FloorAndCeilValueUsingBS
{
    public class FloorAndCeilValueUsingBSClass
    {
        public static List<int> FindFloorAndCeilValue(int[] array, int target)
        {
            List<int> result = new List<int>();
            int n = array.Length;
            int low = 0;
            int high = n - 1;
            int floor = -1;
            int ceil = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if(array[mid] == target)
                {
                    floor = array[mid];
                    ceil = array[mid];
                    break;
                }
                else if(array[mid] > target)
                {
                   ceil = array[mid];
                    high = mid - 1;
                }
                else
                {
                    floor = array[mid];
                    low = mid + 1;
                }
            }
            result.Add(floor);
            result.Add(ceil);
            return result;
        }
    }
}
