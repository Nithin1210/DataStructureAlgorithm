using System;

namespace DataStructuresAlgorithm
{
    class Program
    {
        static string searchFilePath = @"E:\BridgeLabz\DataStructureAlgorithm\DataStructuresAlgorithm\Search.txt";
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter option to get O/p :\n1.Binary Search\n2.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch(option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadTextFileAndSearch(searchFilePath);
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter the correct i/p ");
                        break;

                }
            }

        }


    }
}