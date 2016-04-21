using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask1
{
    public class CalculatorClass
    {
        public static double Add(int num1, int num2)
        {
            double result = num1 + num2;
            return result;
        }

        public static double Subtraction(int num1, int num2)
        {
            double result = num1 - num2;
            return result;
        }
 
        public static double Multiplication(int num1, int num2)
        {
            double result = num1 * num2;
            return result;
        }

        public static double Division(int num1, int num2)
        {
            double result = (num1 / num2);
            return result;
        }



        public static void DoAllOperations(int num1,int num2)
        {
            Console.WriteLine("Add = " + Add(num1, num2));
            Console.WriteLine("Subtraction = " + Subtraction(num1, num2));
            Console.WriteLine("Multiplication = " + Multiplication(num1, num2));
            Console.WriteLine("Division = " + Division(num1, num2));
            Console.Read();
        }
    }
}
