using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4_2
{
    static class MathClassForTask
    {
        public static int Fibonacci(int quantityOfNumber)
        {
            int previousNumber = 0;
            int nextNumber = 1;
            int number = 0;

            for (int i = 0; i < quantityOfNumber; i++)
            {
                number = nextNumber;
                nextNumber += previousNumber;
                previousNumber = number;
            }
            return number;
        }

        public static int Factorial(int number)
        {
            int result = 1;
            for(int i = 1; i<number+1; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
