using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class PrimePalandrome
    {
        public void CheckPrimePalandrome()
        {
            int limit = 1000;
            int count = 0;
            Console.WriteLine("Prime numbers that are also palindromes:");
            for (int num = 2; num <= limit; num++)
            {
                if (Prime(num) && Palindrome(num))
                {
                    Console.Write(num + " ");
                    count++;
                }
            }
            Console.WriteLine("\n Number of Palindromes present above is:" + count);
        }
        public bool Prime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public bool Palindrome(int number)
        {
            string numString = number.ToString();
            int left = 0;
            int right = numString.Length - 1;

            while (left < right)
            {
                if (numString[left] != numString[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

    }
}

