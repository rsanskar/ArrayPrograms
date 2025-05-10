namespace RemoveDuplicatesInArray
{
    public class DistinctElements
    {
        public static int RemoveDuplicateElementsMethod1(int[] array)
        {
            int count = 0;
            HashSet<int> set = new HashSet<int>();
            for(int i = 0; i < array.Length; i++)
            {
                    set.Add(array[i]);
            }
            foreach(int i in set)
            {
                array[count] = i;
                count++;
            }
            return count;
        }

        public static int RemoveDuplicateElementsMethod2(int[] array) //Two pointer approch
        {
            int i = 0; int j = 1;
            while (j < array.Length)
            {
                if (array[i] != array[j])
                {
                    array[i+1] = array[j];
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }
            return i+1;
        }

    }
}
