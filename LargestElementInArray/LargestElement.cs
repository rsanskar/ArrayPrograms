namespace LargestElementInArray
{
    public class LargestElement
    {
        public static int FindLargestElement(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("There are no elements in an array");
                return int.MinValue;
            };
            int largest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
            }
            return largest;
        }

    }
}
