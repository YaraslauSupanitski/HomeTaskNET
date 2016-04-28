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
            taskWorker.refreshDataList(200);
            ////1
            //var a = taskWorker.SimpleNumbers();
            ////2
            //var list = taskWorker.DividedBySumOfNumbers();

            //foreach (var ll in list)
            //{
            //    Console.WriteLine(ll);
            //}
            ////3
            //Console.WriteLine(taskWorker.IsDividedFive());
            //4
            //var list = taskWorker.SquareRoots();
            //foreach (var i in list)
            //{
            //    Console.Write(i.Key + " ");
            //    foreach(var a in i)
            //    {
            //        Console.WriteLine(a);
            //    }

            //}
            ////5
            //var list5 = taskWorker.SortBySecondNumber();
            //foreach (var i in list5)
            //{
            //    Console.WriteLine(i);

            //}
            //7
            var list7 = taskWorker.DividedBySquareOfNumbers();
            //foreach (var i in list7)
            //{
            //    Console.Write(i.Key + " ");
            //    foreach (var a in i)
            //    {
            //        Console.WriteLine(a);
            //    }

            //}
            Console.WriteLine(list7);
            Console.WriteLine(taskWorker.ZeroCounter());
            Console.ReadKey();
        }

    }
}
