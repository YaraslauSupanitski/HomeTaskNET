using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            string meesage = String.Empty;
            string result = String.Empty;

            while (!meesage.Equals(exit))
            {
                //dont use space " ". If u r use space, i split it for 2 value
                Console.Write("give me our number or write exit and.... exit: ");
                result = Console.ReadLine();
                meesage = result.TrimEnd();
                WorkerWithInfo.JustDoIt(meesage);
            }
            WorkerWithInfo.ShowIt();
            Console.Read();
        }



        class WorkerWithInfo
        {
            //information
            //int info
            private static string allIntegers = String.Empty;
            private static int integersSum = 0;
            private static int integersCount = 0;
            //real info
            private static string allReals = String.Empty;
            private static double realSum = 0;
            private static double realCount = 0;
            //string info
            private static string OtherSymbol = String.Empty;



            //create info
            public static void JustDoIt(string mes)
            {
                double DoubleResult = 0;
                int IntResult = 0;

                if (Int32.TryParse(mes, out IntResult))
                {
                    IntegersValueCount(IntResult);
                }
                else if (Double.TryParse(mes, out DoubleResult))
                {
                    RealsValueCount(DoubleResult);
                }
                else
                {
                    OthersSymbol(mes);
                }
            }
            //show information
            public static void ShowIt()
            {
                Console.WriteLine();
                ShowIntegersAndAverageValue();
                ShowRealsAndAverageValue();
                ShowOtherSymbol();
            }



            //create some info
            private static void IntegersValueCount(int number)
            {
                allIntegers += number + " ";
                integersSum += number;
                integersCount++;
            }
            private static void RealsValueCount(double number)
            {
                allReals += String.Format("{0:0.00}", number) + " ";
                realSum += number;
                realCount++;
            }
            private static void OthersSymbol(string message)
            {
                OtherSymbol += message + " ";
                OtherSymbol.TrimEnd();
            }

            //show some info
            private static void ShowIntegersAndAverageValue()
            {
                Console.WriteLine(("All Integers: " + allIntegers));
                Console.WriteLine(("Count Integers: " + integersCount).PadLeft(50));
                Console.WriteLine(("AverageIntegers: " + (integersSum / integersCount)).PadLeft(50));
            }
            private static void ShowRealsAndAverageValue()
            {
                Console.WriteLine("All Real: " + allReals);
                Console.WriteLine(("Average Real: " + (realSum / realCount)).PadLeft(50));
                Console.WriteLine(("Count Real: " + realCount).PadLeft(50));
               
            }
            private static void ShowOtherSymbol()
            {
                Console.Write("Other Symbols: ");
                string[] separators = { " " };
                string[] sortSymbols = OtherSymbol.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(sortSymbols);
                Console.WriteLine(String.Join(" ", sortSymbols));
            }

        }
    }
}
