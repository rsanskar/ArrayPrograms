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
using SingleNumberInArray;
using LongestSubArrayWithSumK;
using TwoSumProblem;
using SortColorsProblem;
using MajorityElement;
using MaxSubArraySum;
using MaxSubArraySumReturnSubArray;
using BestTimetoBuyandSellStock;
using System.Xml.Linq;
using RearrangeArrayElementsBySign;
using LeaderElementsInArray;
using LongestConsecutiveSequence;
using System.Collections.Generic;
using SetMatrixZeroes;
using Rotate90DegreeClockWise;
using Rotate90DegreeAntiClockWise;
using SpiralTraversalofMatrix;
using CountSubArrayWithGivenSum;
using MajorityElementNby3;
using _3SumProblem;
using PascalTriangle;
using _4SumProblem;
using LengthOfLongestSubArrayWithSum0;
using CountSubarraysWithGivenXORK;
using FindMissingAndRepeatingElement;
using CountInversionsInArray;
using MergeSortAlogorithm;
using CountReversePairs;
using MaximumProductSubarray;
using Binary_Search_Algorithm;
using ImplementLowerBound;
using ImplementUpperBound;
using SearchInsertPosition;
using FloorAndCeilValueUsingBS;
using FirstAndLastPositionOfElement;
using CountOccurrencesInSortedArray;
using MergeOverLappingSubIntervals;
using SquareRootOfN;
using Search_in_Rotated_Sorted_Array_I;
using StriverA2ZPattrenPrograms;
using StriversA2ZBasicMathPrograms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AllPrograms.Console;
using System.Linq;
using RecurssionPrograms;

namespace AllArrayPrograms
{
    public class Program
    {
        private const int PageSize = 10;
        private static string GetProgramDescription(int index)
        {
            // You can hardcode or map descriptions here
            return index switch
            {
                0 => "Largest Element in an array",
                1 => "Second Largest Element in an array",
                2 => "Check if an Array is Sorted",
                3 => "Remove Duplicates in-place from Sorted Array",
                4 => "Left Rotate Array by K Places",
                5 => "Move All K values to the end",
                6 => "Linear Search",
                7 => "Union Of 2 Arrays",
                8 => "Intersection Of 2 Arrays",
                9 => "Find missing element",
                10 => "Find Max Consecutive 1s",
                11 => "Find Single Number In Array",
                12 => "Longest Subarray with given Sum K(Positives)",
                13 => "Two Sum Problem returns the indices of the given target",
                14 => "Sort an array of 0's 1's and 2's",
                15 => "Find the Majority Element that occurs more than N/2 times",
                16 => "Maximum Sub Array Sum Kadane's Algorithm",
                17 => "Maximum Sub Array Sum and return sub array",
                18 => "Best Time to Buy and Sell Stock",
                19 => "Rearrange Array Elements by Sign",
                20 => "Leader Elements in array",
                21 => "Longest Consecutive Sequence In Array",
                22 => "Set Matrix Zero",
                23 => "Rotate Image by 90 degree(Clock wise)",
                24 => "Rotate Image by 90 degree(Anti Clock wise)",
                25 => "Spiral Traversal of Matrix",
                26 => "find number of subarrays with given sum k",
                27 => "Majority element more than N/3 times",
                28 => "Three Sum Problem (Find Triplets)",
                29 => "PascalTriangle",
                30 => "Four sum problem",
                31 => "length of longest sub array with sum 0",
                32 => "Count subarrays with given xor K",
                33 => "find missing and repeating number in array from 1 to n",
                34 => "find number of inversions in the given array",
                35 => "Merge sort algorithm",
                36 => "Count Reverse pairs",
                37 => "Maximum Product Subarray in an Array",
                38 => "Binary Search",
                39 => "Find Lower Bound using Binary search",
                40 => "Find Upper Bound using Binary search",
                41 => "Find Insert Position using Binary search",
                42 => "Find floor and ceil values using Binary search",
                43 => "Find First and Last Position of Element in Sorted Array using Binary Search",
                44 => "Count Occurrences in Sorted Array",
                45 => "Merge Over Lapping intervas",
                46 => "Find Square root of N ",
                47 => "Find the element in rotated sorted Array ",
                49 => "Print Pattren1 ",
                50 => "Print Pattren2 ",
                51 => "Print Pattren3 ",
                52 => "Print Pattren4 ",
                53 => "Print Pattren5 ",
                54 => "Print Pattren6 ",
                55 => "Print Pattren7 ",
                56 => "Print Pattren8 ",
                57 => "Print Pattren9 ",
                58 => "Print Pattren10 ",
                59 => "Print Pattren11 ",
                60 => "Print Pattren12 ",
                61 => "Print Pattren13 ",
                62 => "Print Pattren14 ",
                63 => "Print Pattren15 ",
                64 => "Print Pattren16 ",
                65 => "Print Pattren17 ",
                66 => "Print Pattren18 ",
                67 => "Print Pattren19 ",
                68 => "Print Pattren20 ",
                69 => "Print Pattren21 ",
                70 => "Count Number of Digits in Given Number",
                71 => "Reverse Of a Given Number",
                72 => "Palindrome Number",
                73 => "ArmStrong Number",
                74 => "Print All Divisors",
                75 => "Print the Given Number is Prime Or Not",
                76 => "Recurssion: Print Name N Times",
                77 => "Recurssion: Print 1 to N",
                78 => "Recurssion: Print N to 1",
                79 => "Recurssion: Print 1st N tersms Sum",
                _ => "Unknow Program"//Default Program
            };
        }
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
            { 10, FindMaxConsecutiveOnes},
            { 11, SingleNumberInArray},
            { 12, LongestSubArrayWithSumK },
            { 13, TwoSumWithTarget },
            { 14, Sort0s1sAnd2s },
            { 15, MajorityElement },
            { 16, MaximumSUbArraySum_KadanesAlgorithm },
            { 17, MaximumSUbArraySum_KadanesAlgorithm_ReturnSubArray },
            { 18, BestTimetoBuyandSellStock },
            { 19, RearrangeArrayElementsBySign },
            { 20, LeaderElementsInArray },
            { 21, LongestConsecutiveSequence },
            { 22, SetMatrixZeroes },
            { 23, Rotate90DegreeClockWise},
            { 24, Rotate90DegreeAntiClockWise},
            { 25, SpiralTraversalofMatrix},
            { 26, CountSubArrayWithGivenSum},
            { 27, MajorityElementNby3},
            { 28, ThreeSumProblem},
            { 29, PascalTriangle},
            { 30, FourSumProblem},
            { 31, LengthOfLongestSubArrayWithSum0},
            { 32, CountSubarraysWithGivenXORK},
            { 33, FindMissingAndRepeatingElement},
            { 34, CountInversionsInArray},
            { 35, MergeSort},
            { 36, CountReversePairs},
            { 37, MaximumProductSubarray},
            { 38, FindBinarySearch},
            { 39, FindLowerBoundUsingBS},
            { 40, FindUpperBoundUsingBS},
            { 41, SearchInsertPosition},
            { 42, FloorAndCeilValueUsingBS},
            { 43, FirstAndLastPositionOfElement},
            { 44, CountOccurrencesInSortedArray},
            { 45, MergeOverLappingSubIntervals},
            { 46, SquareRootOfN},
            { 47, FindElementInRotatedSortedArrayI},
            { 48, FindElementInRotatedSortedArrayII},
            { 49, Pattren1},
            { 50, Pattren2},
            { 51, Pattren3},
            { 52, Pattren4},
            { 53, Pattren5},
            { 54, Pattren6},
            { 55, Pattren7},
            { 56, Pattren8},
            { 57, Pattren9},
            { 58, Pattren10},
            { 59, Pattren11},
            { 60, Pattren12},
            { 61, Pattren13},
            { 62, Pattren14},
            { 63, Pattren15},
            { 64, Pattren16},
            { 65, Pattren17},
            { 66, Pattren18},
            { 67, Pattren19},
            { 68, Pattren20},
            { 69, Pattren21},
            { 70, CountNumbers},
            { 71, ReverseNumbers},
            { 72, PalindromeNumber},
            { 73, ArmstrongNumbers},
            { 74, PrintAllDivisors},
            { 75, IsPrime},
            { 76, RecurssionPrintNameNTimes},
            { 77, RecurssionPrint1ToN},
            { 78, RecurssionPrintNTo1},
            { 79, Recusrssive1stNSum},

        };

        private static void Recusrssive1stNSum()
        {
            Console.WriteLine("Enter a number to find Sum Of N terms");
            int n = InputNumber();
            int sum = RecursiveSumOfFirstN.PrintRecursiveSumOfFirstN(n, 0);
            Console.WriteLine("Sum of 1st N numbers is: "+sum);
        }

        private static void RecurssionPrintNTo1()
        {
            Console.WriteLine("Enter a number to print N to 1");
            int n = InputNumber();
            //PrintNto1.PrintNto1Function(n);
            PrintNto1.PrintNto1Function2(n,1);

        }

        private static void RecurssionPrint1ToN()
        {
            Console.WriteLine("Enter a number to print 1 to N");
            int n = InputNumber();
            //Print1toN.print1toNFunction(n);
            Print1toN.Print1toNFuncton2(n, 1);
        }

        private static void RecurssionPrintNameNTimes()
        {
            Console.WriteLine("Enter a name to Print");
            string name = Console.ReadLine();
            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Enter a valid Name");
                name = Console.ReadLine();
            }
            Console.WriteLine("Enter a number to print name N Times");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter a valid Number");
            }
            PrintNameNTimes.PrintName(name,n);
        }

        private static void IsPrime()
        {
            Console.WriteLine("Enter a number to check Prime or Not");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter a valid Number");
            }
            string prime = PrimeNumber.IsPrimeNumber(n) ? "Prime" : "Not Prime";
            Console.WriteLine($"The Given Number is {prime}");
        }

        private static void PrintAllDivisors()
        {
            Console.WriteLine("Enter a number to find Divisors");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter a valid Number");
            }
            var divisors = PrintAllDivisorsOfANumber.PrintDivisors(n);
            Console.WriteLine(string.Join(",", divisors));
        }

        private static void ArmstrongNumbers()
        {
            Console.WriteLine("Enter a number to check Palindrome");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter a valid Number");
            }
            if (ArmstrongNumber.IsArmSTrongNumber(n))
            {
                Console.WriteLine("Given Number is a Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong Number");
            }
        }

        private static void PalindromeNumber()
        {
            Console.WriteLine("Enter a number to check Palindrome");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter a valid Number");
            }
            if (PalindromNumber.IsPalindrome(n)) 
            {
                Console.WriteLine("Given Number is a palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }

        private static void ReverseNumbers()
        {
            Console.WriteLine("Enter a number to count the digits");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter a valid Number");
            }
            int reveserNumber = ReverseOfNumber.Reverse(n);
            Console.WriteLine("Reverse Of a Number is:"+reveserNumber);
        }

        private static void CountNumbers()
        {
            Console.WriteLine("Enter a number to count the digits");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter a valid Number");
            }
            int count = CountNumberOfDigitsInGivenNumber.CountDigits(n);
            Console.WriteLine("Number of digits in given number is: " + count);
        }

        private static void Pattren21()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern21.PrintPattern21(n);
        }

        private static void Pattren20()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern20.PrintPattern20(n);
        }

        private static void Pattren19()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern19.PrintPattern19(n);
        }

        private static void Pattren18()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern18.PrintPattern18(n);
        }

        private static void Pattren17()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern17.PrintPattern17(n);
        }

        private static void Pattren16()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern16.PrintPattern16(n);
        }

        private static void Pattren15()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern15.PrintPattern15(n);
        }

        private static void Pattren14()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern14.PrintPattern14(n);
        }

        private static void Pattren13()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern13.PrintPattern13(n);
        }

        private static void Pattren12()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern12.PrintPattern12(n);
        }

        private static void Pattren11()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern11.PrintPattern11(n);
        }

        private static void Pattren10()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern10.PrintPattern10(n);
        }

        private static void Pattren9()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern9.PrintPattern9(n);
        }

        private static void Pattren8()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern8.PrintPattern8(n);
        }

        private static void Pattren7()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern7.PrintPattern7(n);
        }

        private static void Pattren6()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern6.PrintPattern6(n);
        }

        private static void Pattren5()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern5.PrintPattern5(n);
        }

        private static void Pattren4()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern4.PrintPattern4(n);
        }

        private static void Pattren3()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern3.PrintPattern3(n);
        }

        private static void Pattren2()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern2.PrintPattren2(n);
        }
        private static void Pattren1()
        {
            Console.WriteLine("Enter the value to print Stars");
            int.TryParse(Console.ReadLine(), out int n);
            Pattern1.PrintPatteren1(n);
        }

        private static void FindElementInRotatedSortedArrayII()
        {
            int[] inpArray = InputArray();
            Console.WriteLine("Enter Target value to search in an array");
            int.TryParse(Console.ReadLine(), out int target);
            int index = SearchInRotatedSortedArrayI.FindIndex(inpArray, target);
            Console.WriteLine("Element Found at index: " + index);
        }

        private static void FindElementInRotatedSortedArrayI()
        {
            int[] inpArray = InputArray();
            Console.WriteLine("Enter Target value to search in an array");
            int.TryParse(Console.ReadLine(), out int target);
            int index = SearchInRotatedSortedArrayI.FindIndex(inpArray, target);
            Console.WriteLine("Element Found at index: " + index);
        }

        private static void SquareRootOfN()
        {
            Console.WriteLine("Enter a number to find the floor square root of N");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("Square Root of N is : " + SquareRootOfNClass.FindSquareRootOfn(n));
            Console.WriteLine("Square Root of N using BS is : " + SquareRootOfNClass.FindSquareRootOfnUsingBS(n));
        }

        private static void MergeOverLappingSubIntervals()
        {
            int[][] arr = { new int[] { 1, 3 }, new int[] { 8, 10 }, new int[] { 2, 6 }, new int[] { 15, 18 } };
            List<int[]> ans = MergeOverLappingSubIntervalsClass.FindMergeOverLappingSubIntervals(arr);

            Console.WriteLine("The merged intervals are:");
            foreach (var interval in ans)
            {
                Console.Write($"[{interval[0]}, {interval[1]}] ");
            }
            Console.WriteLine();

        }

        private static void CountOccurrencesInSortedArray()
        {
            int[] array = InputArray();
            Console.WriteLine("Enter target value: ");
            int.TryParse(Console.ReadLine(), out int target);
            int occurrrences = CountOccurrencesInSortedArrayClass.CountOccurrences(array, target);
            Console.WriteLine($"Ther target element is repeated for {occurrrences}");

            int occurrrences1 = CountOccurrencesInSortedArrayClass.CountOccurrencesMethod2(array, target);
            Console.WriteLine($"Ther target element is repeated for {occurrrences1}");
        }

        private static void FirstAndLastPositionOfElement()
        {
            int[] array = InputArray();
            Console.WriteLine("Enter target value: ");
            int.TryParse(Console.ReadLine(), out int target);
            int[] ans = FirstAndLastPositionOfElementClass.SearchRange(array, target);
            Console.WriteLine($"First Position is {ans[0]} and Last Position is {ans[1]}");
        }

        private static void FloorAndCeilValueUsingBS()
        {
            int[] array = InputArray();
            Console.WriteLine("Enter target value: ");
            int.TryParse(Console.ReadLine(), out int target);
            List<int> list = FloorAndCeilValueUsingBSClass.FindFloorAndCeilValue(array, target);
            Console.WriteLine("Floor value is : " + list[0]);
            Console.WriteLine("ceil value is : " + list[1]);

        }


        public static void Main(string[] args)
        {
            DisaplayPrograms();
        }
        private static void DisaplayPrograms()
        {
            int totalPrograms = ProgramActions.Count;
            int totalPages = (totalPrograms + PageSize - 1) / PageSize;
            int currentPage = totalPages - 1;  // Start from last page (0-based index)

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Select a program to run (Page {currentPage + 1} of {totalPages}):\n");

                // Calculate start and end indices for the current page
                int startIndex = currentPage * PageSize;
                int endIndex = Math.Min(startIndex + PageSize, totalPrograms);

                // Display programs for current page
                for (int i = startIndex; i < endIndex; i++)
                {
                    Console.WriteLine($"{i} : {GetProgramDescription(i)}");
                }

                Console.WriteLine("\nn : Next page, p : Previous page, -1 : Exit");
                Console.Write("\nEnter choice: ");

                string? input = Console.ReadLine();

                if (input == "-1")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else if (input == "n")
                {
                    if (currentPage < totalPages - 1)
                        currentPage++;
                    else
                        Console.WriteLine("Already at last page.");
                }
                else if (input == "p")
                {
                    if (currentPage > 0)
                        currentPage--;
                    else
                        Console.WriteLine("Already at first page.");
                }
                else if (int.TryParse(input, out int choice))
                {
                    if (ProgramActions.TryGetValue(choice, out var action))
                    {
                        Console.Clear();
                        action.Invoke();

                        Console.WriteLine("\nPress any key to return to menu...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
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
            for (int i = 0; i < n; i++)
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
            int[] opArray = LeftRotate.RotateMethod2(array, k);
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
            PrintArray(array, array.Length);
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
        private static void FindMaxConsecutiveOnes()
        {
            int[] inpArray = InputArray();
            //int max1s = MaxConsecutiveOnes.FindMax1sMethod1(inpArray);
            int max1s = MaxConsecutiveOnes.FindMax1sMethod2(inpArray);
            Console.WriteLine($"max consecutiveOnes in the given array is : {max1s}");
        }
        private static void FindMissingElementInArray()
        {
            int[] inpArray = InputArray();
            //int missingElement = FindMissingElement.FindMethod1(inpArray);
            //int missingElement = FindMissingElement.FindMethod2(inpArray);
            int missingElement = FindMissingElement.FindMethod3(inpArray);
            Console.WriteLine($"Missing Element in an array is : {missingElement}");
        }
        private static void Sort0s1sAnd2s()
        {
            Console.WriteLine("Enter the 0's 1's and 2's in an array");
            int[] inpArray = InputArray();
            //SortColors.SortColorsMethod1(inpArray);
            SortColors.SortColorsMethod2(inpArray);
            Console.WriteLine("Sorted Array is:");
            PrintArray(inpArray, inpArray.Length);

        }
        private static void TwoSumWithTarget()
        {
            int[] inpArray = InputArray();
            Console.WriteLine("Enter the target value to find the indices ");
            int.TryParse(Console.ReadLine(), out int target);
            //int[] result = TwoSumProblemClass.TwoSumMethod1(inpArray, target);
            int[] result = TwoSumProblemClass.TwoSumMethod2(inpArray, target);
            Console.WriteLine($"indices are {result[0]} {result[1]}");

        }
        private static void LongestSubArrayWithSumK()
        {
            int[] inpArray = InputArray();
            Console.WriteLine("Enter the K value to find the length of longest sub array");
            int.TryParse(Console.ReadLine(), out int K);
            //int lsaLength = LongestSubArrayWithSumKSolution.FindLongestSubArrayWithSumKMethod1(inpArray,K);
            //int lsaLength = LongestSubArrayWithSumKSolution.FindLongestSubArrayWithSumKMethod2(inpArray,K);
            int lsaLength = LongestSubArrayWithSumKSolution.FindLongestSubArrayWithSumKMethod3(inpArray, K);
            Console.WriteLine($"length of longest sub array with given sum {K} is : {lsaLength} \n");

        }
        private static void SingleNumberInArray()
        {
            int[] inpArray = InputArray();
            int singleNumber = Solution.SingleNumberMethod1(inpArray);
            //int singleNumber = Solution.SingleNumberMethod2(inpArray);
            Console.WriteLine($"Single number in the give array is : {singleNumber}");
        }
        private static void RearrangeArrayElementsBySign()
        {
            int[] array = InputArray();
            //int[] result = RearrangeArrayElementsBySignClass.RearrangeArray(array);
            //int[] result = RearrangeArrayElementsBySignClass.RearrangeArrayMethod2(array);
            //int[] result = RearrangeArrayElementsBySignClass.RearrangeArrayMethod3(array);
            int[] result = RearrangeArrayElementsBySignClass.RearrangeArrayMethod4(array);
            PrintArray(result, result.Length);
        }
        private static void BestTimetoBuyandSellStock()
        {
            int[] array = InputArray();
            int maxProfit1 = BestTimetoBuyandSellStockClass.MaxProfitMethod1(array);
            int maxProfit2 = BestTimetoBuyandSellStockClass.MaxProfitMethod1(array);
            Console.WriteLine($"Max profit using Method1 is: {maxProfit1}");
            Console.WriteLine($"Max profit is using Method2 is: {maxProfit2}");
        }
        private static void MaximumSUbArraySum_KadanesAlgorithm_ReturnSubArray()
        {
            int[] array = InputArray();
            int[] maxSumUsingMethod1 = MaxSubArraySumReturnSubArrayClass.MaxSubArraySumReturnSubArrayMethod1(array);
            int[] maxSumUsingMethod2 = MaxSubArraySumReturnSubArrayClass.MaxSubArraySumReturnSubArrayMethod1(array);
            Console.WriteLine("Output using method1");
            PrintArray(maxSumUsingMethod1, maxSumUsingMethod1.Length);
            Console.WriteLine("Output using method2");
            PrintArray(maxSumUsingMethod2, maxSumUsingMethod2.Length);
        }
        private static void MaximumSUbArraySum_KadanesAlgorithm()
        {
            int[] array = InputArray();
            int maxSumUsingMethod1 = MaxSubArraySumClass.MaxSubArraySumMethod1(array);
            int maxSumUsingMethod2 = MaxSubArraySumClass.MaxSubArraySumMethod2(array);
            Console.WriteLine($"Max SubArray Sum is : {maxSumUsingMethod1}");
            Console.WriteLine($"Max SubArray Sum is : {maxSumUsingMethod2}");
        }
        private static void MajorityElement()
        {
            int[] inpArray = InputArray();
            int majorityElement1 = MajorityElementClass.FindMajorityElementMethod1(inpArray);
            int majorityElement2 = MajorityElementClass.FindMajorityElementMethod2(inpArray);
            int majorityElement3 = MajorityElementClass.FindMajorityElementMethod3(inpArray);
            Console.WriteLine($"Majority element in given array is {majorityElement1}");
            Console.WriteLine($"Majority element in given array is {majorityElement2}");
            Console.WriteLine($"Majority element in given array is {majorityElement3}");
        }
        private static void SpiralTraversalofMatrix()
        {
            int[][] array =
           {
                new int[] { 1, 2, 3, 2, 1 },
                new int[] { 4, 5, 6, 5, 4 },
                new int[] { 7, 8, 9, 8, 7 }
            };
            SpiralTraversalofMatrixClass.PrintSpiralMatrix(array);
        }
        private static void Rotate90DegreeAntiClockWise()
        {
            int[][] array =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            Rotate90DegreeAntiClockWiseClass.RotateArray(array);
            Rotate90DegreeAntiClockWiseClass.RotateArray(array);
        }
        private static void Rotate90DegreeClockWise()
        {
            int[][] array =
            {
                new int[] { 1, 2, 3,4 },
                new int[] { 5, 6, 7,8 },
                new int[] { 9, 10, 11,12 },
                new int[] { 13, 14, 15, 16 }
            };
            Rotate90DegreeClockWiseClass.RotateArray(array);
            Rotate90DegreeClockWiseClass.RotateArrayMethod2(array);
        }
        private static void SetMatrixZeroes()
        {
            int[][] array =
            {
                new int[] { 0, 2, 3 },
                new int[] { 6, 1, 6 },
                new int[] { 7, 8, 9 }
            };
            //SetMatrixWithZeroes.SetZeroes(array);
            //SetMatrixWithZeroes.SetZerosMethod1(array);
            SetMatrixWithZeroes.SetZerosMethod2(array);
        }
        private static void LongestConsecutiveSequence()
        {
            int[] inpArray = InputArray();
            int maxEle = LongestConsecutiveSequenceInArray.FindLongestConsecutiveSequenceInArray(inpArray);
            int maxEle2 = LongestConsecutiveSequenceInArray.FindLongestConsecutiveSequenceInArrayMethod1(inpArray);
            int maxEle3 = LongestConsecutiveSequenceInArray.FindLongestConsecutiveSequenceInArrayMethod2(inpArray);
            int maxEle4 = LongestConsecutiveSequenceInArray.FindLongestConsecutiveSequenceInArrayMethod2(inpArray);
            Console.WriteLine($"Longest Consecutive Sequence In Array is Using Method1: {maxEle}");
            Console.WriteLine($"Longest Consecutive Sequence In Array is Using Method2: {maxEle2}");
            Console.WriteLine($"Longest Consecutive Sequence In Array is Using Method3: {maxEle3}");
            Console.WriteLine($"Longest Consecutive Sequence In Array is Using Method3: {maxEle4}");
        }
        private static void LeaderElementsInArray()
        {
            int[] inpArray = InputArray();
            //int[] result = LeaderElements.FindLeaderElements(inpArray);
            int[] result = LeaderElements.FindLeaderElementsMethod2(inpArray);
            PrintArray(result, result.Length);
        }
        private static void ThreeSumProblem()
        {
            int[] inpArray = InputArray();
            //var triplets = ThreeSumClass.FindTripletsMethod1(inpArray);
            //var triplets = ThreeSumClass.FindTripletsMethod2(inpArray);
            var triplets = ThreeSumClass.FindTripletsMethod3(inpArray);
            foreach (var innerList in triplets)
            {
                Console.WriteLine(string.Join(", ", innerList));
            }
        }
        private static void MajorityElementNby3()
        {
            int[] inpArray = InputArray();
            //IList<int> list = MajorityElementNby3Class.MajorityElement(inpArray);
            IList<int> list = MajorityElementNby3Class.MajorityElementMethod1(inpArray);
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
        }
        private static void CountSubArrayWithGivenSum()
        {
            int[] array = InputArray();
            Console.WriteLine("Please enter sub array sum to count no of sub arrays");
            int.TryParse(Console.ReadLine(), out int k);
            int subArrayCount = CountSubArrayWithGivenSumClass.CountSubArraysCount(array, k);
            int subArrayCount2 = CountSubArrayWithGivenSumClass.CountSubArraysCountMethod2(array, k);
            Console.WriteLine($"Number of sub arrays with given sum using Method1 is {subArrayCount}");
            Console.WriteLine($"Number of sub arrays with given sum using Method2 is {subArrayCount2}");
        }
        private static void CountInversionsInArray()
        {
            int[] inpArray = InputArray();
            int count = CountInversionsInArrayClass.CountInversionsInArrayMethod1(inpArray);
            Console.WriteLine("Number of inversions in array is: " + count);
            int count1 = CountInversionsInArrayClass.MergeSort(inpArray, 0, inpArray.Length - 1);
            Console.WriteLine("Number of inversions in array is: " + count1);
        }
        private static void FindMissingAndRepeatingElement()
        {
            int[] inpArray = InputArray();
            int n;
            Console.Write("Enter the value of n: ");
            int.TryParse(Console.ReadLine(), out n);
            List<int> list = FindMissingAndRepeatingElementClass.FindMissingAndRepeatingNumbers(inpArray, n);
            Console.WriteLine("Missing Number in array is: " + list[0]);
            Console.WriteLine("Repeating Number in array is: " + list[1]);
            Console.WriteLine("-------------------------------------------");
            List<int> list1 = FindMissingAndRepeatingElementClass.FindMissingAndRepeatingNumbersMethod2(inpArray, n);
            Console.WriteLine("Missing Number in array using Method2 is: " + list1[0]);
            Console.WriteLine("Repeating Number in array using Method2 is: " + list1[1]);
            Console.WriteLine("-------------------------------------------");
            List<int> list2 = FindMissingAndRepeatingElementClass.FindMissingAndRepeatingNumbersMethod3(inpArray, n);
            Console.WriteLine("Missing Number in array using Method3 is: " + list2[0]);
            Console.WriteLine("Repeating Number in array using Method3 is: " + list2[1]);
            Console.WriteLine("-------------------------------------------");
        }
        private static void CountSubarraysWithGivenXORK()
        {
            int[] inpArray = InputArray();
            int k;
            Console.Write("Enter the value of K: ");
            int.TryParse(Console.ReadLine(), out k);
            int count = CountSubarraysWithGivenXORKClass.CountSubArrays(inpArray, k);
            Console.WriteLine("Number of sub arrays with given xor k with method1 is " + count);
        }
        private static void LengthOfLongestSubArrayWithSum0()
        {
            int[] inpArray = InputArray();
            int maxLength = LengthOfLongestSubArrayWithSum0Class.FindLongestSubArrayLength(inpArray);
            int maxLength2 = LengthOfLongestSubArrayWithSum0Class.FindLongestSubArrayLengthMethod2(inpArray);
            Console.WriteLine("Longest SubArray with sum zeros using method1 is: " + maxLength);
            Console.WriteLine("Longest SubArray with sum zeros using method2 is: " + maxLength2);
        }
        private static void FourSumProblem()
        {
            int[] inpArray = InputArray();
            int.TryParse(Console.ReadLine(), out int target);
            IList<IList<int>> listOFList = FourSumClass.FindFourSumMethod1(inpArray, target);
            foreach (List<int> list in listOFList)
            {
                Console.WriteLine(string.Join(",", list));
            }

        }
        private static void PascalTriangle()
        {
            Console.WriteLine("Enter the row number: ");
            int.TryParse(Console.ReadLine(), out int r);
            Console.WriteLine("Enter the col number: ");
            int.TryParse(Console.ReadLine(), out int c);
            Console.WriteLine("Pascal triangle value at rth row and nth column is: ");
            PascalTriangleClass.PascalTriangleType1(r, c);
            Console.WriteLine("Pascal triange entire row for give r is:");
            PascalTriangleClass.PascalTriangleType2(r);
            Console.WriteLine("Pascal triange for r rows is:");
            PascalTriangleClass.pascalTriangleType3Method1(r);
            Console.WriteLine("Method2");
            PascalTriangleClass.pascalTriangleType3Method2(r);
        }

        private static void MergeSort()
        {
            int[] array = InputArray();
            MergeSortAlogorithmClass.MergeSort(array, 0, array.Length - 1);
            PrintArray(array, array.Length);
        }

        private static void CountReversePairs()
        {
            int[] array = InputArray();
            int count = CountReversePairsClass.CountReversePairsInArray(array);
            int count1 = CountReversePairsClass.MergeSort(array, 0, array.Length - 1);
            Console.WriteLine("Number of pairs using Method1 is: " + count);
            Console.WriteLine("Number of pairs using Method2 is: " + count1);
        }

        private static void FindUpperBoundUsingBS()
        {
            int[] inpArray = InputArray();
            Console.WriteLine("Enter target: ");
            int.TryParse(Console.ReadLine(), out int target);
            int lb = ImplementUpperBoundUsingBS.FindUpperBound(inpArray, target);
            Console.WriteLine("Ele found using Binary Search using method1(Lower bound) is: " + lb);
            int lb2 = ImplementUpperBoundUsingBS.FindUpperBoundMethod1(inpArray, target);
            Console.WriteLine("Ele found using Binary Search using method2(Lower bound) is: " + lb2);

        }

        private static void FindLowerBoundUsingBS()
        {
            int[] inpArray = InputArray();
            Console.WriteLine("Enter target: ");
            int.TryParse(Console.ReadLine(), out int target);
            int lb = ImplementLowerBoundUsingBS.FindLowerBound(inpArray, target);
            Console.WriteLine("Ele found using Binary Search using method1(Lower bound) is: " + lb);
            int lb2 = ImplementLowerBoundUsingBS.FindLowerBoundMethod1(inpArray, target);
            Console.WriteLine("Ele found using Binary Search using method2(Lower bound) is: " + lb2);
        }

        private static void FindBinarySearch()
        {
            int[] inpArray = InputArray();
            Console.WriteLine("Enter target: ");
            int.TryParse(Console.ReadLine(), out int target);
            int ele = BinarySearch.SearchElement(inpArray, target);
            int ele2 = BinarySearch.SearchElementMethod2(inpArray, target);
            Console.WriteLine("Ele found using Binary Search method1 is: " + ele);
            Console.WriteLine("Ele found using Binary Search method2 is: " + ele2);

        }

        private static void MaximumProductSubarray()
        {
            int[] array = InputArray();
            int maxProd = MaximumProductSubarrayClass.FindMaxProduct(array);
            Console.WriteLine("Max Product in sub array is: " + maxProd);
            int maxProd1 = MaximumProductSubarrayClass.FindMaxProductMethod1(array);
            Console.WriteLine("Max Product in sub array using method 2 is: " + maxProd1);

        }

        private static void SearchInsertPosition()
        {
            int[] array = InputArray();
            Console.WriteLine("Enter target: ");
            int.TryParse(Console.ReadLine(), out int target);
            int position = SearchInsertPositionClass.SearchInsert(array, target);
            Console.WriteLine("The position to insert the given element using method 1 is: " + position);
        }

        private static int InputNumber()
        {
            int n;
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("enter a valid Number");
            }
            return n;
        }

    }
}