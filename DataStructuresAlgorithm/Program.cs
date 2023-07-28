using DataStructureAlgorithm.UnOrderedList;
using System;
using System.Net;

namespace DataStructuresAlgorithm
{
    class Program
    {
        static string searchFilePath = @"E:\BridgeLabz\DataStructureAlgorithm\DataStructuresAlgorithm\Search.txt";
        static string unOrderedFilePath = @"E:\BridgeLabz\DataStructureAlgorithm\DataStructuresAlgorithm\UnOrderedList\UnOrdered.txt";
        private static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n Enter option to get O/p :\n1.Binary Search\n2.Anagram\n3.StringReplace \n4.Insertion sort \n5.Bubble sort " +
                                    "\n6.PrimeNumberRange\n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadTextFileAndSearch(searchFilePath);
                        break;
                    case 2:
                        Anagram output = new Anagram();
                        output.CheckAnagram();
                        break;
                    case 3:
                        StringReplace replace = new StringReplace();
                        replace.stringReplace();
                        break;
                    case 4:
                        InsertionSort insertion = new InsertionSort();
                        insertion.InsertionSortAlgorithm();
                        break;
                    case 5:
                        BubbleSort bubble = new BubbleSort();
                        bubble.BubbleSortAlgorithm();
                        break;
                    case 6:
                        PrimeNumberRange range = new PrimeNumberRange();
                        range.CheckPrime();
                        break;
                    case 9:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter the  i/p : ");
                        break;

                }
            }

        }


    }
}