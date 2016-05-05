using ConApp6_2.CommandsClasses;
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
            string messForPerson = "Number is prime: Input 1 and 1 parameters\n" +
                "Distanse between Points: Input 2 and 4 parameters Point1(x1,y1) Point2(x2,y2)\n" +
                "Count number in Numeral: Input 3 and 1 parameters\n"+
                "Exit: Input 0"; 


            Dictionary<int, MathCommandAbstract> dicWithCommand = new Dictionary<int, MathCommandAbstract>();
            
            dicWithCommand.Add(1, new NumberInfo());
            dicWithCommand.Add(2, new PointsWorker());
            dicWithCommand.Add(3, new CounterNumberInNumeral());




            bool flagToExit = false;

            while (!flagToExit)
            {
                Console.WriteLine(messForPerson);
                int numberFlag = ConsoleWorker.getIntegerValue();

                if (numberFlag == 0) { flagToExit = true; continue; }
                else {

                    MathCommandAbstract command = dicWithCommand[numberFlag];

                    List<int> parametersList = new List<int>();
                    //command.GetType().GetFields().Length <<== count of fields in class
                    for (int i = 0; i < command.GetType().GetFields().Length; i++)
                    {
                        int param = ConsoleWorker.getIntegerValue("Input Parameter: ");
                        parametersList.Add(param);
                    }


                    command.SetParams(parametersList.ToArray());
                    command.Execute();
                    Console.WriteLine();
                }
            }
            Console.ReadLine();

        }
    }
}
