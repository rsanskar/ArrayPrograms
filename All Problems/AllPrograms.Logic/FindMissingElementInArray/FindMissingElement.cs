namespace FindMissingElementInArray
{
    public class FindMissingElement
    {
        public static int FindMethod1(int[] array)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == array[j])
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int FindMethod2(int[] array)
        {
            int[] hashArray = new int[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                hashArray[array[i]] = 1;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (hashArray[i] == 0)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int FindMethod3(int[] array)
        {
            int n = array.Length;
            int sum = (n*(n+1))/2;
            return sum - array.Sum();
        }
    }
}
