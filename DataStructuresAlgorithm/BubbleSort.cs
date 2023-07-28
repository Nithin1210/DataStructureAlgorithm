using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class BubbleSort
    {
        public void BubbleSortAlgorithm()
        {
            Console.WriteLine("Enter the Length of array : ");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[l];
            Console.WriteLine("Enter the numbers !! ");
            for (int i = 0; i < l; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < l - 1; i++)
            {
                for (int j = 0; j < l - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                   
                    }

                }
                
            }
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
