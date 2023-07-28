using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class InsertionSort
    {
        public void InsertionSortAlgorithm()
        {
            Console.WriteLine("Enter the Length of array : ");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[l];
            Console.WriteLine("Enter the numbers !! ");
            for(int i=0; i<l; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < l; i++)
            {
                int j = i;

                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
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
