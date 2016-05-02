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

            //linqWorker.Task6();
            //linqWorker.Task7();
            //linqWorker.Task5();
            //linqWorker.Task4();
            //linqWorker.Task3(new decimal(2000));
            //linqWorker.Task2();
            //linqWorker.Task1();




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


