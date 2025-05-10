using LargestElementInArray;
using SecondLargestElementInArray;
using ArraySortingChecker;
using RemoveDuplicatesInArray;
using LeftRotateArrayByK;
using MoveKtoEnd;
using LinearSearch;
using UnionOf2Arrays;
using IntersectionOf2Arrays;
using FindMissingElementInArray;
using FindMaxConsecutiveOnes;

namespace AllArrayPrograms
{
    public class Program
    {
        private static readonly Dictionary<int, Action> ProgramActions = new Dictionary<int, Action>
        {
            { 0, RunLargestElementProgram },
            { 1, RunSecondLargestElementProgram },
            { 2, RunArraySortChecker},
            { 3, RemoveDuplicates},
            { 4, RotateArrayByK },
            { 5, MovAllKElementsToEnd },
            { 6, LinearSearch},
            { 7, UnionOf2Arrays},
            { 8, InterSectionOf2Arrays},
            { 9, FindMissingElementInArray},
            { 10, FindMaxConsecutiveOnes}
        };

        private static void FindMaxConsecutiveOnes()
        {
            int[] inpArray = InputArray();
            int max1s = MaxConsecutiveOnes.FindMax1s(inpArray);
            Console.WriteLine("abc");
        }

        private static void FindMissingElementInArray()
        {
            int[] inpArray = InputArray();
            //int missingElement = FindMissingElement.FindMethod1(inpArray);
            //int missingElement = FindMissingElement.FindMethod2(inpArray);
            int missingElement = FindMissingElement.FindMethod3(inpArray);
            Console.WriteLine($"Missing Element in an array is : {missingElement}");
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run:\n");
                Console.WriteLine("0: Largest Element in an array");
                Console.WriteLine("1: Second Largest Element in an array");
                Console.WriteLine("2: Check if an Array is Sorted");
                Console.WriteLine("3: Remove Duplicates in-place from Sorted Array");
                Console.WriteLine("4: Left Rotate Array by K Places");
                Console.WriteLine("5: Move All K values to the end");
                Console.WriteLine("6: Linear Search");
                Console.WriteLine("7: Union Of 2 Arrays");
                Console.WriteLine("8: Intersection Of 2 Arrays");
                Console.WriteLine("9: Find missing element");
                Console.WriteLine("-1: Exit");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == -1)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                if (ProgramActions.TryGetValue(choice, out var action))
                {
                    action.Invoke();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }

        }

        private static int[] InputArray()
        {
            Console.Write("Enter number of elements:");

            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer:");
                }
            }

            return array;
        }

        private static void PrintArray(int[] opArray, int n)
        {
            for(int i =0; i<n;i++)
            {
                Console.Write(opArray[i] + " ");
            }
            Console.WriteLine("\n");
        }
        private static void RunLargestElementProgram()
        {
            Console.WriteLine("\nFind Largest Element Program:");
            int[] array = InputArray();
            int largestElement = LargestElement.FindLargestElement(array);
            Console.WriteLine($"Largest element in the array: {largestElement}");
        }
        private static void RunSecondLargestElementProgram()
        {
            Console.WriteLine("\nFind Second Largest Element Program:");
            int[] array = InputArray();
            int secondLargestElement = SecondLargestElement.FindSecondLargestElement(array);
            Console.WriteLine($"Second largest element in the array: {secondLargestElement}");
        }
        private static void RunArraySortChecker()
        {
            Console.WriteLine("\nCheck If an Array is Sorted Program:");
            int[] array = InputArray();

            bool isSorted = SortChecker.IsSorted(array);
            Console.WriteLine($"Is the array sorted? {isSorted}");
        }

        private static void RemoveDuplicates()
        {
            int[] array = InputArray();
            //int opArrayLength = DistinctElements.RemoveDuplicateElementsMethod1(array);
            int opArrayLength = DistinctElements.RemoveDuplicateElementsMethod2(array);
            Console.WriteLine("Output Array with Distinct elements is:");
            PrintArray(array, opArrayLength);

        }
        private static void RotateArrayByK()
        {
            int[] array = InputArray();
            int k;
            Console.WriteLine("Enter the number K to LeftShit array by k times");
            int.TryParse(Console.ReadLine(), out k);
            //int[] opArray = LeftRotate.RotateMethod1(array,k);
            int[] opArray = LeftRotate.RotateMethod2(array,k);
            Console.WriteLine("Output Array after shifting left for k times:");
            PrintArray(opArray, opArray.Length);

        }

        private static void MovAllKElementsToEnd()
        {
            int[] array = InputArray();
            int k;
            Console.WriteLine("Enter the number K to move all K's to last");
            int.TryParse(Console.ReadLine(), out k);
            MoveKToLast.MoveElements(array, k);
            PrintArray(array,array.Length);
        }
        private static void LinearSearch()
        {
            int[] inpArray = InputArray();
            Console.WriteLine("Enter an element Key to find in an array");
            int Key;
            int.TryParse(Console.ReadLine(), out Key);
            int index = LinearSearching.Search(inpArray, Key);
            Console.WriteLine($"Given Key {Key} found at : {index} \n");


        }
        private static void UnionOf2Arrays()
        {
            int[] arrayA = InputArray();
            int[] arrayB = InputArray();
            int[] result = Union.FindUnionMethod1(arrayA, arrayB);
            //int[] result = Union.FindUnionMethod2(arrayA, arrayB);//works only for sorted arrays.
            Console.WriteLine("Union of 2 Arrays");
            PrintArray(result, result.Length);
        }
        private static void InterSectionOf2Arrays()
        {
            int[] arrayA = InputArray();
            int[] arrayB = InputArray();
            //int[] result = Intersection.FindInterSectionMethod1(arrayA, arrayB);
            //int[] result = Intersection.FindIntersectionMethod2(arrayA, arrayB);
            int[] result = Intersection.FindInterSectionMethod3(arrayA, arrayB);// Works only for sorted arrays
            Console.WriteLine("Intersection of 2 Arrays");
            PrintArray(result, result.Length);
        }

    }
}