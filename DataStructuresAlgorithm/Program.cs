using System;

namespace DataStructuresAlgorithm
{
    class Program
    {
        static string searchFilePath = @"E:\BridgeLabz\DataStructureAlgorithm\DataStructuresAlgorithm\Search.txt";
        private static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n Enter option to get O/p :\n1.Binary Search\n2.Anagram\n3.StringReplace \n4.Exit");
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