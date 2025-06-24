namespace Search_in_Rotated_Sorted_Array_II
{
    public class SearchInRotatedSortedArrayII
    {
        public static bool FindIndex(int[] array, int k)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == k)
                {
                    return true;
                }
                if (array[mid] == array[low] && array[mid] == array[high])
                {
                    low += 1;
                    high -= 1;
                }
                
                if (array[low] <= array[mid])
                {
                    if (array[low] <= k && k < array[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else
                {
                    if (array[mid] < k && k <= array[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            return false;
        }
    }
}
