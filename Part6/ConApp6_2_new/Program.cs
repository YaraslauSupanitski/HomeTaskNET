using ConApp6_2.CommandsClasses;
using ConApp6_2.Objects.Recirvers;
using LibraryForConsole4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string messForPerson = "Number is prime: Input 1\n" +
                "Distanse between Points: Input 2\n" +
                "Count number in Numeral: Input 3\n" +
                "Exit: Input 0";


            bool flagToExit = false;

            while (!flagToExit)
            {
                Console.WriteLine(messForPerson);
                int numberFlag = ConsoleWorker.getIntegerValue();
                MathCommandAbstract command = null;
                IBaseRecirver recirver;
                if (numberFlag == 0) { flagToExit = true; continue; }
                switch (numberFlag)
                {
                    case 1:
                        recirver = new NumberInfoRecirver(ConsoleWorker.getIntegerValue("Input number "));
                        command = new NumberInfo((NumberInfoRecirver)recirver);
                        break;
                    case 2:
                        recirver = new PointRecirver(ConsoleWorker.getIntegerValue("Input x1 "),
                                                     ConsoleWorker.getIntegerValue("Input y1 "),
                                                     ConsoleWorker.getIntegerValue("Input x2 "),
                                                     ConsoleWorker.getIntegerValue("Input y2 "));
                        command = new PointsWorker((PointRecirver)recirver);
                        break;
                    case 3:
                        recirver = new CounterNumberInNumeralRecirver(ConsoleWorker.getIntegerValue("Input number "));
                        command = new CounterNumberInNumeral((CounterNumberInNumeralRecirver)recirver);
                        break;
                }
                command.Execute();
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}