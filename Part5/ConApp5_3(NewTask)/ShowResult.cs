using LibraryForConsole4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConApp5_3_NewTask_
{
    class ShowResult
    {

        public static void Show(int num,string path)
        {

            LinqWorkerForCustumers linqWorker = new LinqWorkerForCustumers(path);

            switch (num)
            {
                case 1:
                    decimal prise;
                    ShowTask1(linqWorker.Task1(out prise));
                    Console.WriteLine("\nPrise: " + prise);
                    break;
                case 2: ShowTask2(linqWorker.Task2()); break;
                case 3: ShowTask3(linqWorker.Task3(ConsoleWorker.getIntegerValue("give me Prise "))); break;
                case 4: ShowTask4(linqWorker.Task4()); break;
                case 5: ShowTask5(linqWorker.Task5()); break;
                case 6: ShowTask6(linqWorker.Task6()); break;
                case 7: ShowTask7(linqWorker.Task7()); break;

            }
            Console.WriteLine();
        }

        public static void Show(int num, dynamic list)
        {
            switch (num)
            {
                case 1: ShowTask1(list); break;
                case 2: ShowTask2(list); break;
                case 3: ShowTask3(list); break;
                case 4: ShowTask4(list); break;
                case 5: ShowTask5(list); break;
                case 6: ShowTask6(list); break;
                case 7: ShowTask7(list); break;

            }
            Console.WriteLine();
        }       




        private static void ShowTask1(IEnumerable<XElement> list)
        {
            foreach (var t in list)
            {
                Console.WriteLine($"{t.Element("id").Value} {t.Element("orders").Elements("order").Sum(ord => Decimal.Parse(ord.Element("total").Value))}");
            }
        }

        private static void ShowTask2(IEnumerable<IGrouping<string, XElement>> list)
        {
            foreach (var cust in list)
            {
                Console.WriteLine(cust.Key + ":");

                foreach (var country in cust)
                {
                    Console.WriteLine("\t" + country.Element("id").Value);
                }
            }
        }

        private static void ShowTask3(IEnumerable<XElement> list)
        {
            foreach (var cust in list.Distinct())
            {
                var maxPrice = cust.Element("orders").Elements()
                    .Max(ord => Decimal.Parse(ord.Element("total").Value));

                Console.WriteLine($"{cust.Element("id").Value} {maxPrice}");
            }
        }

        private static void ShowTask4(IEnumerable<IGrouping<XElement, DateTime>> list)
        {

            foreach (var customer in list)
            {
                Console.Write($"{customer.Key.Element("id").Value}:\t");
                Console.WriteLine(customer.First());
            }
        }

        private static void ShowTask5(IEnumerable<dynamic> list)
        {
            foreach (var customer in list)
            {
                Console.Write($"{customer.CusId}:\t");
                Console.WriteLine(customer.data);
            }
        }

        private static void ShowTask6(IEnumerable<XElement> list)
        {
            foreach (var custumer in list)
            {
                Console.WriteLine($"Id = {custumer.Element("id").Value}\t" +
                                  $"region = { (string)custumer.Element("region")}\t" +
                                  $"phone = { (string)custumer.Element("phone")}\t" +
                                  $"postalcode = { (string)custumer.Element("postalcode")}\t");

            }
        }

        private static void ShowTask7(IEnumerable<dynamic> list)
        {
            foreach (var el in list)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"City: {el.city}");
                Console.WriteLine($"Average: {el.average}");
                Console.WriteLine($"Count: {el.number}");
            }
        }
    }
}
