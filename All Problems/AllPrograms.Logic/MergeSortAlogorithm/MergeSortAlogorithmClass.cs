namespace MergeSortAlogorithm
{
    public class MergeSortAlogorithmClass
    {
        public static void MergeSort(int[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int mid = (low + high) / 2;
            MergeSort(array, low, mid);
            MergeSort(array, mid+1, high);
            MergeArray(array, low, mid,high);

        }
        private static void MergeArray(int[] array, int low, int mid, int high)
        {
            int left = low;
            int right = mid+1;
            List<int> list = new List<int>();
            while (left <= mid && right<=high) 
            {
                if(array[left] < array[right])
                {
                    list.Add(array[left]);
                    left++;
                }
                else
                {
                    list.Add(array[right]);
                    right++;
                }
            }
            while (left <= mid)
            {
                list.Add(array[left]);
                left++;
            }
            while(right <= high)
            {
                list.Add(array[right]);
                right++;
            }
            for (int i = 0; i < list.Count; i++)
            {
                array[low+i] = list[i];
            }
        }

    }
}
