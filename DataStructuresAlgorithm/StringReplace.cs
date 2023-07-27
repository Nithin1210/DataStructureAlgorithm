using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class StringReplace
    {
        public void stringReplace()
        {
            string line = "Hell0 <<name>>, we have your fullname as <<full name>>, and your number as <<xxxxxxxxxx>> ";

            Console.WriteLine("Enter Your Full name :");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter Your Short name :");
            string shorName = Console.ReadLine();
            Console.WriteLine("Enter Your PhoneNumber :");
            string number = Console.ReadLine();

            line = line.Replace("<<name>>", shorName);
            line = line.Replace("<<full name>>", fullName);
            line = line.Replace("<<xxxxxxxxxx>>", number);

            Console.WriteLine("Final Result :" + line);
        }
        
    }
}
