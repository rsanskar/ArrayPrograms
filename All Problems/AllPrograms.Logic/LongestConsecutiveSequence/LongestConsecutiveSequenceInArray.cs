using System;

namespace LongestConsecutiveSequence
{
    public class LongestConsecutiveSequenceInArray
    {
        public static int FindLongestConsecutiveSequenceInArray(int[] array)
        {
            int n = array.Length;
            int maxLength = 1;
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                int ele = array[i];
                for (int j = 0; j<n; j++)
                {
                    if(i!=j && ele+1 == array[j])
                    {
                        count++;
                        ele++;
                        j = -1;  // reset inner loop to start over to find next consecutive
                    }
                }
                if(count > maxLength)
                {
                    maxLength = count;
                }
            }
            return maxLength;
        }

        public static int FindLongestConsecutiveSequenceInArrayMethod1(int[] array)
        {
            if (array == null || array.Length == 0) 
                return 0;
            int n = array.Length;
            int maxLength = 1;
            int count = 1;
            Array.Sort(array);
            for (int i = 0; i < n-1; i++)
            {
                if(array[i] == array[i+1])
                {
                    continue;
                }
                if (array[i]+1 == array[i+1] )
                {
                    count++;
                }
                else
                {
                    maxLength = Math.Max(maxLength,count);
                    count = 1;
                }
            }

            return Math.Max(maxLength, count);
        }

        public static int FindLongestConsecutiveSequenceInArrayMethod2(int[] array)
        {
            SortedSet<int> set = new SortedSet<int>();
            int count = 1;
            int maxLength = 1;
            for(int i = 0; i < array.Length; i++)
            {
               set.Add(array[i]);
            }
            foreach(int i in set)
            {
                if (set.Contains(i+1))
                {
                    count++;
                }
                else
                {
                    maxLength = Math.Max(maxLength,count);
                    count = 1;
                }
            }
            return Math.Max(maxLength, count);
        }

        public static int FindLongestConsecutiveSequenceInArrayMethod3(int[] array)
        {
            HashSet<int> set = new HashSet<int>(array);
            int maxLength = 1;
           
            foreach (int i in set)
            {
                if (!set.Contains(i -1))
                {
                    int count = 1;
                    //int currentNum = num;
                    //int currentLength = 1;

                    //while (set.Contains(currentNum + 1))
                    //{
                    //    currentNum++;
                    //    currentLength++;
                    //}

                    // Use a for loop to count consecutive numbers
                    for (int j = i + 1; set.Contains(j); j++)
                    {
                        count++;
                    }
                    maxLength = Math.Max(maxLength, count);
                }
            }
            return maxLength;
        }
    }
}
