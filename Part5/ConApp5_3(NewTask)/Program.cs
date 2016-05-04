using LibraryForConsole4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConApp5_3_NewTask_
{
    class Program
    {
        static void Main(string[] args)
        {
            //need add Log For out information.
            //need shange void to list methods
            string path = $"{Environment.CurrentDirectory}\\Data\\Customers.xml";

            LinqWorkerForCustumers linqWorker = new LinqWorkerForCustumers(path);

            int i = 10;
            int CountOfTask = 7;
            while (i != 0)
            {
                i = ConsoleWorker.getIntegerValue("We have 7 tasks. Press number 1-7 for show some task. If you whant see all task press 8. 0 - exit\n");
                if (i == CountOfTask+1)
                {
                    for (int y = 1; y < CountOfTask+1; y++)
                    {
                        Console.WriteLine($"====================== Task {y} ======================");
                        ShowResult.Show(y, path);
                    }
                }
                else
                {
                    ShowResult.Show(i, path);
                }
            }


            //ShowResult.Show(1, linqWorker.Task1(20000));
            //ShowResult.Show(2, linqWorker.Task2());

            //ShowResult.Show(3, linqWorker.Task3(2000));
            //ShowResult.Show(4, linqWorker.Task4());
            //ShowResult.Show(5, linqWorker.Task5());
            //ShowResult.Show(6, linqWorker.Task6());
            //ShowResult.Show(7, linqWorker.Task7());



            //Nedd add to method. Its hardcode task8
            /*
            var tttw = 
                from cus in custs.Elements()
                      from order in cus.Element("orders").Elements()
                      let date = ((DateTime)order.Element("orderdate")).Month
                      let price = decimal.Parse((string)order.Element("total"))
                orderby date
                group price by date into gr
                    select new
                {
                    year = gr.Key,
                    average = gr.Average()
                };

            */
            /*
            foreach (var c in tttw)
            {
                Console.WriteLine("========================================");
                Console.WriteLine($"Year: {c.year}; Average: {c.average}");

            }
            */

            //foreach(var t in ttt)
            //{
            //    Console.Write(t.Key);
            //    foreach(var tt in t)
            //    {
            //    }
            //}



            /*
                      var wwww = from cus in custs.Elements()
                                 from order in cus. 
                                                  Element("orders").Elements()
                                 group order by cus into orderGroup  //kay = cus' orderЫ = value
                                          from yearGroup in
                                                      (from order in orderGroup //year <= order
                                                      group order by (DateTime.Parse(order.Element("orderdate").Value)).Year)
                                                      //kay = year value = orders
                                                      group yearGroup by orderGroup.Key;

                      foreach (var c in wwww)
                      {
                          Console.WriteLine("========================================");
                          Console.WriteLine($"Customer: {(string)c.Key.Element("id")}");
                          foreach (var item in c)
                          {
                              Console.WriteLine($"Year: {item.Key}");
                              Console.WriteLine($"Total: {item.Sum(el => ((decimal)el.Element("total")))}");
                          }
                      }

              */

            Console.Read();
            }
        }
    }


