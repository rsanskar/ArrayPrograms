namespace Binary_Search_Algorithm
{
    public class BinarySearch
    {
        public static int SearchElement(int[] array, int target)
        {
            return BinarySearchInArray(array, 0, array.Length - 1, target);
        }
        private static int BinarySearchInArray(int[] array, int left, int right, int target)
        {
            if (left > right)
            {
                return -1;
            }
            int mid = (left + right) / 2;
            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] > target)
            {
                return BinarySearchInArray(array, left, mid - 1, target);
            }
            else
            {
                return BinarySearchInArray(array, mid + 1, right, target);
            }
        }

        public static int SearchElementMethod2(int[] nums, int target)
        {
            int n = nums.Length;
            int left = 0; int right = n - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }

    }
}
