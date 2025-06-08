namespace MergeOverLappingSubIntervals
{
    public class MergeOverLappingSubIntervalsClass
    {
        public static List<int[]> FindMergeOverLappingSubIntervals(int[][] subIntervals)
        {
            List<int[]> result = new List<int[]>();
            Array.Sort(subIntervals, (a, b) => a[0].CompareTo(b[0]));
            int n = subIntervals.Length;
            if (n == 0) return result;
            for (int i = 0; i < n; i++)
            {
                int start = subIntervals[i][0];
                int end = subIntervals[i][1];
                // Skip all merged intervals:
                if (result.Count > 0 && end <= result[result.Count - 1][1])
                {
                    continue;
                }

                for (int j = i + 1; j < n; j++)
                {
                    if (subIntervals[j][0]<=end)
                    {
                        end = Math.Max(end, subIntervals[j][1]);
                    }
                    else
                    {
                        break;
                    }
                }
                result.Add(new int[] { start, end });
            }
            return result;
        }

        public static List<int[]> FindMergeOverLappingSubIntervalsMethod2(int[][] subIntervals)
        {
            List<int[]> result = new List<int[]>();
            int n = subIntervals.Length;

            if (n == 0) return result; // Handle empty input

            // Step 1: Sort intervals by start time
            Array.Sort(subIntervals, (a, b) => a[0].CompareTo(b[0]));

            // Step 2: Initialize merged interval
            int[] mergedInterval = subIntervals[0];

            for (int i = 1; i < n; i++)
            {
                if (subIntervals[i][0] <= mergedInterval[1])
                {
                    // Merge overlapping intervals
                    mergedInterval[1] = Math.Max(mergedInterval[1], subIntervals[i][1]);
                }
                else
                {
                    // Add merged interval to result
                    result.Add(mergedInterval);
                    //reset merged interval to next sub interval
                    mergedInterval = subIntervals[i];
                }
            }

            // Step 3: Add the last merged interval
            result.Add(mergedInterval);

            return result;
        }


    }
}
