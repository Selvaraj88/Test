using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeApplication
{
    class PersonalInfo
    {
        static void Main(string[] args)
        {
            string firstValue, secondValue, output;
            firstValue = Console.ReadLine();
            secondValue = Console.ReadLine();
            output = firstValue + secondValue;
            Console.WriteLine("Hello World " + output);
            Console.ReadLine();
        }
    }
}
