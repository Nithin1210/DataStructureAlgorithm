using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class PrimeNumberRange
    {
        public void CheckPrime()
        {
            int num = 1000;
            Console.WriteLine("Prime numbers ");
            for (int i = 2; i < num; i++)
            {
                int count = 0;


                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

    
    }
}
