namespace CountSubarraysWithGivenXORK
{
    public class CountSubarraysWithGivenXORKClass
    {
        public static int CountSubArrays(int[] array, int k)
        {
            int n = array.Length;
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                int xor = 0;
                for(int j = i; j < n; j++)
                {
                    xor = xor ^ array[j];
                    if(xor == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
