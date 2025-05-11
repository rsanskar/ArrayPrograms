namespace IntersectionOf2Arrays
{
    public class Intersection
    {
        public static int[] FindInterSectionMethod1(int[] arrayA, int[] arrayB)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> result = new List<int>();
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (dict.ContainsKey(arrayA[i]))
                {
                    dict[arrayA[i]]++;
                }
                else
                {
                    dict.Add(arrayA[i], 1);
                }
            }

            for (int j = 0; j < arrayB.Length; j++)
            {
                if (dict.ContainsKey(arrayB[j]) && dict[arrayB[j]]>0)
                {
                    result.Add(arrayB[j]);
                    dict[arrayB[j]]--;
                }                
            }
            return result.ToArray();
        }

        public static int[] FindIntersectionMethod2(int[] arrayA, int[] arrayB)
        {
            int[] visitedArray = new int[arrayB.Length];
            List<int> result = new List<int>();
            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j<arrayB.Length; j++)
                {
                    if (arrayA[i] == arrayB[j] && visitedArray[j] ==0)
                    {
                        result.Add(arrayA[i]);
                        visitedArray[j] = 1;
                        break;
                    }
                }
            }
            return result.ToArray();
        }

        public static int[] FindInterSectionMethod3(int[] arrayA, int[] arrayB)
        {
            List<int> result = new List<int>();
            int i = 0;
            int j = 0;
            while (i < arrayA.Length && j < arrayB.Length)
            {
                if(arrayB[j] == arrayA[i])
                {
                    result.Add(arrayA[i]);
                    i++;
                    j++;
                }
                else if(arrayB[j] > arrayA[i])
                {
                    i++;
                }
                else if (arrayB[j] < arrayA[i])
                {
                    j++;
                }
            }


            return result.ToArray();
        }
    }
}
