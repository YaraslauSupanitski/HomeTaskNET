using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5_2_2
{
    class Program
    {
        static void Main(string[] args)
        {


            TasksWorker taskWorker = new TasksWorker();
            Console.WriteLine("====================================================Task 1====================================================");
            taskWorker.refreshDataList(20);
            ////1
            var a = taskWorker.SimpleNumbers();
            a.ForEach(num => Console.WriteLine(num));
            //2
            taskWorker.refreshDataList(200);
            Console.WriteLine("====================================================Task 2====================================================");
            var list = taskWorker.DividedBySumOfNumbers();

            foreach (var ll in list)
            {
                Console.WriteLine(ll);
            }

            //3
            Console.WriteLine("====================================================Task 3====================================================");

            Console.WriteLine("IsDividedFive " + taskWorker.IsDividedFive());

            Console.WriteLine("====================================================Task 4====================================================");

            var list3 = taskWorker.SquareRoots(2);
            foreach (var i in list3)
            {
                Console.Write(i.Key + " ");
                foreach (var aww in i)
                {
                    Console.WriteLine(aww);
                }

            }
            Console.WriteLine("====================================================Task 5====================================================");
            //5
            var list5 = taskWorker.SortBySecondNumber();
            foreach (var i in list5)
            {
                Console.WriteLine(i);

            }
            taskWorker.task6().ForEach(num => Console.WriteLine(num));

            Console.WriteLine("====================================================Task 6====================================================");
            taskWorker.task6().ForEach(num => Console.WriteLine(num));
            Console.WriteLine("====================================================Task 7====================================================");
            //7

            var list7 = taskWorker.DividedBySquareOfNumbers();
            Console.WriteLine(list7);
            Console.WriteLine("====================================================Task 8====================================================");
            Console.WriteLine(taskWorker.ZeroCounter());
                Console.ReadKey();
            }

        }
    }
