using System;
using LargestElementInArray;
using SecondLargestElementInArray;

namespace AllArrayPrograms
{
    public class Program
    {
        private static readonly Dictionary<int, Action> ProgramActions = new Dictionary<int, Action>
        {
            { 0, RunLargestElementProgram },
            { 1, RunSecondLargestElementProgram }
        };
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a program to run:\n");
                Console.WriteLine("0: Largest Element in an array");
                Console.WriteLine("1: Second Largest Element in an array");
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
            Console.WriteLine("Enter number of elements:");

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
    }
}