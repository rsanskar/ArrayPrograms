namespace UnionOf2Arrays
{
    public class Union
    {
        public static int[] FindUnionMethod1(int[] arrayA, int[] arrayB)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arrayA.Length; i++)
            {
                set.Add(arrayA[i]);
            }
            for (int i = 0; i < arrayB.Length; i++)
            {
                set.Add(arrayB[i]);
            }

            return set.ToArray();
        }

        public static int[] FindUnionMethod2(int[] arrayA, int[] arrayB) // works only if both the arrays are sorted
        {
            List<int> list = new List<int>();
            int i = 0;
            int j = 0;
            while (i < arrayA.Length && j < arrayB.Length)
            {
                if (arrayA[i] < arrayB[j])
                {
                    if (list.Count == 0|| list.Last() != arrayA[i])
                    {
                        list.Add(arrayA[i]);
                    }
                    i++;
                }
                else
                {
                    if (list.Count == 0 || list.Last() != arrayB[j])
                    {
                        list.Add(arrayB[j]);
                    }
                    j++;
                }
            }
            while (i < arrayA.Length)
            {
                if (list.Last() != arrayA[i])
                {
                    list.Add(arrayA[i]);
                }
                i++;
            }
            while (j < arrayB.Length)
            {
                if (list.Last() != arrayB[j] )
                {
                    list.Add(arrayB[j]);
                }
                j++;
            }
            return list.ToArray();
        }
    }
}
