using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConApp5_3_NewTask_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $"{Environment.CurrentDirectory}\\Data\\Customers.xml";

            XDocument xmlDoc = XDocument.Load(path);
            var custs = xmlDoc.Element("customers");
            
            Random rnd = new Random();
            var maxOrder = custs.Elements("customer")
                    .Max(cust => cust.Element("orders").Elements("order").Count());

            decimal x = rnd.Next(10000, 100000);
            
            Console.WriteLine($"Max Sum {x}");
            var a = custs.Elements("custome").
                Where(cus => cus.Element("order").Elements("order").
                Sum(ord => Decimal.Parse(ord.Attribute("total").Value)) > x).
                Select(cus => cus);

            foreach(var t in a)
            {
                Console.WriteLine(t);
            }

            /*
            a.ToList().ForEach(cus => Console.WriteLine($"{cus.CustomerID} {cus.Orders.Sum(ord => ord.Total)}"));
            */
            Console.Read();


        }
    }
}
