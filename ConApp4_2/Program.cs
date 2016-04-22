using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForConsole4;

namespace ConApp4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesForFactorial = "Hello. I show to you Factorial. Give me number: ";
            string mesForFibonacci = "Now we see Fibonachi numbers. What number from Fibonacci bumbers do you whant:";

            int numForFactorial = ConsoleWorker.getIntegerValue(mesForFactorial);
            Console.WriteLine($"Factorial {numForFactorial}=" +MathClassForTask.Factorial(numForFactorial));

            int numForFibonachi = ConsoleWorker.getIntegerValue(mesForFibonacci);
            Console.WriteLine($"{numForFibonachi} number in fibonacci sequence=" + MathClassForTask.Fibonacci(numForFibonachi));

            Console.Read();
        }
    }
}
