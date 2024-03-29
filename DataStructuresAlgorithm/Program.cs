﻿using DataStructureAlgorithm.UnOrderedList;
using DataStructuresAlgorithm.BlancedParanthesis;
using DataStructuresAlgorithm.OrderedList;
using DataStructuresAlgorithm.Simulate_Banking_Cash_Counter;
using System;
using System.Net;

namespace DataStructuresAlgorithm
{
    class Program
    {
        static string searchFilePath = @"E:\BridgeLabz\DataStructureAlgorithm\DataStructuresAlgorithm\Search.txt";
        static string unOrderedFilePath = @"E:\BridgeLabz\DataStructureAlgorithm\DataStructuresAlgorithm\UnOrderedList\UnOrdered.txt";
        static string OrderedFliePath = @"E:\BridgeLabz\DataStructureAlgorithm\DataStructuresAlgorithm\OrderedList\Order.txt";
        static string BalancedFilePath = @"E:\BridgeLabz\DataStructureAlgorithm\DataStructuresAlgorithm\BlancedParanthesis\Balanced.txt";
        private static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n Enter option to get O/p :\n1.Binary Search\n2.Anagram\n3.StringReplace \n4.Insertion sort \n5.Bubble sort " +
                                    "\n6.PrimeNumberRange \n7.PrimePalandrome \n8.UnOrdered List \n9.Ordered List \n10.BlancedParanthesis \n11.Banking Cash \n12.Exit !!");
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
                    case 7:
                        PrimePalandrome prime = new PrimePalandrome();
                        prime.CheckPrimePalandrome();
                        break;

                    case 8:
                        UnOrderedOpertion unorderListProblem = new UnOrderedOpertion();
                        unorderListProblem.ReadFileAndPerformOperation(unOrderedFilePath);
                        break;
                    case 9:
                        OrderedOperation OrderedOperation = new OrderedOperation();
                        OrderedOperation.ReadFileAndPerformOperation(OrderedFliePath);
                        break;
                    case 10:
                        BalancedOperation BalancedOperation = new BalancedOperation();
                        BalancedOperation.ReadFileAndPerformOperation(BalancedFilePath);
                        break;
                    case 11:
                        Bank bank = new Bank();
                        bank.Balance(0);
                        bank.AddPersonsInQueue();
                        break;
                    case 12:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter the Correct i/p : ");
                        break;

                }
            }

        }


    }
}