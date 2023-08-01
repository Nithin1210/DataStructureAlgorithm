using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.OrderedList
{
    public class OrderedOperation
    {
        public void ReadFileAndPerformOperation(string filepath)
        {
            OrderedList list = new OrderedList();
            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(",");

            foreach (var data in words)
            {
                list.Add(Convert.ToInt32(data));
            }
            Console.WriteLine("Before initialization of Text:");
            list.Display(words.Length);

            Console.WriteLine("\nAfter initialization of Text:");
            list.Operation(20, words.Length);
        }
    }
}
