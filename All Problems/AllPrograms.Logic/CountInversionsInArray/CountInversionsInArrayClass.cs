namespace CountInversionsInArray
{
    public class CountInversionsInArrayClass
    {
        public static int CountInversionsInArrayMethod1(int[] array)
        {
            int n = array.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int MergeSort(int[] array, int low, int high)
        {
            int count = 0;
            if (low >= high)
            {
                return count;
            }

            int mid = (low + high) / 2;

            count += MergeSort(array, low, mid);  // Accumulate left half count
            count += MergeSort(array, mid + 1, high); // Accumulate right half count
            count += MergeArray(array, low, mid, high); // Accumulate merging count

            return count;
        }

        private static int MergeArray(int[] array, int low, int mid, int high)
        {
            List<int> list = new List<int>();
            int left = low, right = mid + 1;
            int count = 0;

            while (left <= mid && right <= high)
            {
                if (array[left] <= array[right])
                {
                    list.Add(array[left]);
                    left++;
                }
                else
                {
                    count += mid - left + 1;  // Count inversions
                    list.Add(array[right]);
                    right++;
                }
            }

            while (left <= mid)
            {
                list.Add(array[left]);
                left++;
            }

            while (right <= high)
            {
                list.Add(array[right]);
                right++;
            }

            for (int i = 0; i < list.Count; i++)
            {
                array[low + i] = list[i];
            }

            return count;
        }
    }
}
