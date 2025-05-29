using System.Reflection;

namespace FindMissingAndRepeatingElement
{
    public class FindMissingAndRepeatingElementClass
    {
        public static List<int> FindMissingAndRepeatingNumbers(int[] array, int n)
        {
            List<int> result = new List<int>();
            int repeated = -1;
            for (int i = 1; i<=n; i++)
            {
                bool missing = true;
                for (int j = 0; j<n; j++)
                {
                    if(array[j] == i)
                    {
                        missing = false;
                    }
                }
                if (missing)
                {
                    result.Add(i);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i!=j && array[i] == array[j])
                    {
                        repeated = array[i];
                        break;
                    }
                }
            }
            result.Add(repeated);

            return result;
        }

        public static List<int> FindMissingAndRepeatingNumbersMethod2(int[] array, int n)
        {
            Array.Sort(array);
            List<int> result = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool missing = true;
                for (int j = 0; j < n; j++)
                {
                    if (array[j] == i)
                    {
                        missing = false;
                    }
                }
                if (missing)
                {
                    result.Add(i);
                }
            }

            for (int i = 0; i < n-1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    result.Add(array[i]); // Repeated
                    break;
                }
            }
            return result;
        }

        public static List<int> FindMissingAndRepeatingNumbersMethod3(int[] array, int n)
        {
            int missing = -1;
            int repeating = -1;
            List<int> result = new List<int>();
            int[] hashArray = new int[n+1];
            for(int i = 0; i < n; i++)
            {
                hashArray[array[i]]++;
            }

            for(int i = 1; i <= n; i++)
            {
                if (hashArray[i] == 0)
                {
                    missing = i; //missing
                }
                if (hashArray[i] > 1)
                {
                    repeating = i;  //repeating
                }            
                
            }
            result.Add(missing);
            result.Add(repeating);
            return result;
        }

    }
}
