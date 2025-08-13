namespace MedianOf2SortedArrays
{
    public class MedianOf2SortedArraysClass
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int l1 = nums1.Length;
            int l2 = nums2.Length;
            int l3 = l1 + l2;
            if (l3 == 0)
            {
                return -1;
            }
            int[] nums3 = new int[l3];
            int l = 0;
            int r = 0;
            int i = 0;
            while (l < l1 && r < l2)
            {
                if (nums1[l] < nums2[r])
                {
                    nums3[i] = nums1[l];
                    l++;
                    i++;
                }
                else
                {
                    nums3[i] = nums2[r];
                    r++;
                    i++;
                }
            }
            while (l < l1)
            {
                nums3[i] = nums1[l];
                l++;
                i++;
            }
            while (r < l2)
            {
                nums3[i] = nums2[r];
                r++;
                i++;
            }
            if (nums3.Length % 2 == 1)
            {
                return nums3[l3 / 2];
            }
            else
            {
                return Math.Round((nums3[l3 / 2 - 1] + nums3[l3 / 2]) / 2.0, 2);
            }
        }
        public static double FindMedianSortedArraysMethod2(int[] nums1, int[] nums2)
        {
            int l1 = nums1.Length;
            int l2 = nums2.Length;
            int l3 = l1 + l2;
            int l = l1 - 1;
            int r = 0;
            if (l3 == 0)
            {
                return -1;
            }
            if (l1 == 0)
            {
                int mid = l2 / 2;
                if (l2 % 2 == 1)
                    return Math.Round(nums2[mid] * 1.0, 2);
                else
                    return Math.Round((nums2[mid - 1] + nums2[mid]) / 2.0, 2);
            }

            if (l2 == 0)
            {
                int mid = l1 / 2;
                if (l1 % 2 == 1)
                    return Math.Round(nums1[mid] * 1.0, 2);
                else
                    return Math.Round((nums1[mid - 1] + nums1[mid]) / 2.0, 2);
            }

            while (l >= 0 && r < l2 && nums1[l] > nums2[r])
            {
                Swap(nums1, nums2, l, r);
                l--;
                r++;
            }
            Array.Sort(nums1);
            Array.Sort(nums2);

            if (l3 % 2 == 1)
            {
                int mid = l3 / 2;
                if (mid >= l1)
                {
                    return Math.Round((nums2[mid - l1]) / 1.0, 2);
                }
                else
                {
                    return Math.Round(nums1[mid] / 1.0, 2);
                }
            }
            else
            {
                int mid1 = l3 / 2 - 1;
                int mid2 = l3 / 2;
                double val1 = (mid1 < l1) ? nums1[mid1] : nums2[mid1 - l1];
                double val2 = (mid2 < l1) ? nums1[mid2] : nums2[mid2 - l1];
                return Math.Round((val1 + val2) / 2.0, 2);
            }
        }
        private static void Swap(int[] nums1, int[] nums2, int l, int r)
        {
            int temp = nums1[l];
            nums1[l] = nums2[r];
            nums2[r] = temp;
        }

        public static double FindMedianSortedArraysMethod3(int[] nums1, int[] nums2)
        {
            int l3 = nums1.Length + nums2.Length;
            int ele1 = -1, ele2 = -2;
            int l = 0, r = 0;
            int mid = l3 / 2;
            int count = 0;
            int index2 = l3 / 2;
            int index1 = index2 - 1;


            while (l < nums1.Length && r < nums2.Length)
            {
                if (nums1[l] < nums2[r])
                {
                    if (count == index1) ele1 = nums1[l];
                    if (count == index2) ele2 = nums1[l];
                    count++;
                    l++;
                }
                else
                {
                    if (count == index1) ele1 = nums2[r];
                    if (count == index2) ele2 = nums2[r];
                    count++;
                    r++;
                }
            }
            while (l < nums1.Length)
            {
                if (count == index1) ele1 = nums1[l];
                if (count == index2) ele2 = nums1[l];
                count++;
                l++;
            }

            while (r < nums2.Length)
            {
                if (count == index1) ele1 = nums2[r];
                if (count == index2) ele2 = nums2[r];
                count++;
                r++;
            }
            if (l3 % 2 == 1)
            {
                return Math.Round(ele2 * 1.0, 2);
            }
            else
            {
                return Math.Round((ele1 + ele2) / 2.0, 2);
            }
        }
    }
}
