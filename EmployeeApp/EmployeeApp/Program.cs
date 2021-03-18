using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApplication;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorLibrary calc;
            calc = new CalculatorLibrary();

            int firstValue = 10, secondValue = 20;
            calc.SetValues(firstValue, secondValue);
            calc.Calculate();
            int outputValue = calc.GetResult();

            Console.WriteLine(outputValue);
            Console.ReadLine();
        }
        
    }

    public class CalculatorLibrary
    {
        private int num1, num2;
        public int result;

        public void SetValues(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
        }

        public void Calculate()
        {
            result = num1 + num2;
        }

        public int GetResult()
        {
            int output = result;
            return output;
        }

        private void TestMethod()
        {

        }
    }
}
