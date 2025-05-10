namespace UnionOf2Arrays
{
    public class Union
    {
        public static int[] FindUnion(int[] arrayA, int[] arrayB)
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

    }
}
