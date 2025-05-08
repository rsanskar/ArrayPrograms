namespace ArraySortingChecker
{
    public class SortChecker
    {
        public static bool IsSorted(int[] array)
        {
            int ascCount = 1;
            int dscCount = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    ascCount++;
                }
                if (array[i] <= array[i + 1])
                {
                    dscCount++;
                }
            }
            if (ascCount == array.Length || dscCount == array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
