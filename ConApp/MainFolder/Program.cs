using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryTask1;
using System.Configuration;

namespace ConApp
{
    class Program
    {
        static int num1;
        static int num2;

        static void Main(string[] args)
        {

            bool useResourseFile = Boolean.Parse(ConfigurationManager.AppSettings["resourse"]);
            bool result = useResourseFile ? generateNumberFromResourse() : generateNumberFromConsole();

            /*
            if (useResourseFile) { generateNumberFromResourse();
            } else
            {
                generateNumberFromConsole();
            }*/

            string methodName = ConfigurationManager.AppSettings["methodName"];
            doMethod(methodName);
        }


        //TaskMethods
        private static void TaskA(int num1, int num2)
        {

            Console.WriteLine("Result = " + (num1 + num2) + "\nGood bay");
            Console.ReadLine();
        }
        private static void TaskE(int num1, int num2)
        {
            CalculatorClass.DoAllOperations(num1, num2);
        }

        //HelpMethods
        private static bool generateNumberFromConsole()
        {
            Console.Write("Give me number 1: ");
            Program.num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Give me number 2: ");
            Program.num2 = Int32.Parse(Console.ReadLine());
            return true;
        }
        private static bool generateNumberFromResourse()
        {
            Program.num1 = Int32.Parse(Resource1.ResourceManager.GetString("num1"));
            Program.num2 = Int32.Parse(Resource1.ResourceManager.GetString("num2"));
            return true;
        }
        private static void doMethod(string nameMethod)
        {
            if (nameMethod.Equals("TaskA"))
            {
                TaskA(Program.num1, Program.num1);
            }
            else if (nameMethod.Equals("TaskE"))
            {
                TaskE(Program.num1, Program.num1);
            }
        }
    }
}

