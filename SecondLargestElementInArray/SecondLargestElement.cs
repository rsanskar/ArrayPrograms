using LargestElementInArray;

namespace SecondLargestElementInArray
{
    public class SecondLargestElement
    {
        public static int FindSecondLargestElement(int[] array)
        {
            if (array.Length < 2)
            {
                Console.WriteLine("Array should have atleast 2 elements");
                return -1;
            }
            if (array.Length == 2 && array[0] == array[1]) 
            {
                Console.WriteLine("There is no second largest because array contains simmilar 2 elements");
                return -1;
            }
            int firstLargestElement = int.MinValue;
            int secondLargest = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > firstLargestElement)
                {
                    secondLargest = firstLargestElement;
                    firstLargestElement = array[i];
                }
                else if (array[i] != firstLargestElement && array[i] > secondLargest)
                {
                    secondLargest = array[i];
                }
            }
            return secondLargest;
        }

    }
}
