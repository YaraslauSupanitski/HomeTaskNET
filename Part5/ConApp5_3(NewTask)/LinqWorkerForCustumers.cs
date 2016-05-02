using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConApp5_3_NewTask_
{
    class LinqWorkerForCustumers
    {
        private string _path;

        private XDocument _xmlDoc;
        private XElement _rootElement;



        public LinqWorkerForCustumers(string path)
        {
            this._path = path;
            this._xmlDoc = XDocument.Load(_path);
            this._rootElement = _xmlDoc.Root;
        }
        
        public void Task1()
        {
            Random rnd = new Random();
            var maxOrder = _rootElement.Elements("customer")
                    .Max(cust => cust.Element("orders").Elements("order").Count());

            //decimal x = rnd.Next(10000, 100000);
            decimal x = 20000;

            Console.WriteLine($"Max Sum {x}");

            var a = _rootElement.Elements("customer").
                Where(cus => cus.Element("orders").Elements("order").
                Sum(ord => Decimal.Parse(ord.Element("total").Value)) > x).
                Select(cus => cus);

            int o = 0;
            foreach (var t in a)
            {

                Console.WriteLine(o++ + " " + t.Element("id").Value + " " + t.Element("orders").Elements("order").Sum(ord => Decimal.Parse(ord.Element("total").Value)));
            }

        }
        
        public void Task2()
        {
            var custByCountry = from customer in _rootElement.Elements("customer")
                    group customer by customer.Element("country").Value;

            foreach (var cust in custByCountry)
            {
                Console.WriteLine(cust.Key + ":");

                foreach (var country in cust)
                {
                    Console.WriteLine("\t" + country.Element("id").Value);
                }
            }
        }
        
        public void Task3(decimal price)
        {
            var custListWithPriceHighPrice = (from customer in _rootElement.Elements("customer")
                    from order in customer.Element("orders").Elements()
                    where Decimal.Parse(order.Element("total").Value) >= price
                    select customer);


            Console.WriteLine($"Prise: {price}");
            foreach (var cust in custListWithPriceHighPrice.Distinct())
            {
                var maxPrice = cust.Element("orders").Elements()
                    .Max(ord => Decimal.Parse(ord.Element("total").Value));

                Console.WriteLine($"{cust.Element("id").Value} {maxPrice}");
            }
        }
        
        public void Task4()
        {
            var customerList = (from customer in _rootElement.Elements()
                                from order in customer.Element("orders").Elements()
                                group DateTime.Parse(order.Element("orderdate").Value) by customer
                            );

            foreach (var customer in customerList)
            {
                Console.Write($"{customer.Key.Element("id").Value}:\t");
                Console.WriteLine(customer.First());
            }
        }
        
        public void Task5()
        {
            var customerList = from customer in _rootElement.Elements()
                               from order in customer.Element("orders").Elements()
                               orderby DateTime.Parse(order.Element("orderdate").Value),
                                       customer.Element("id").Value
                               group DateTime.Parse(order.Element("orderdate").Value) by customer into gr
                               select new
                               {
                                   CusId = gr.Key.Element("id").Value,
                                   data = gr.First(),
                               };

            foreach (var customer in customerList)
            {
                Console.Write($"{customer.CusId}:\t");
                Console.WriteLine(customer.data);

            }
        }       
        
        public void Task6()
        {
            int i;
            var resultListWithCus = from cus in _rootElement.Elements()
                                    where String.IsNullOrEmpty((string)cus.Element("region"))
                                          || !cus.Element("phone").Value.Contains('(')
                                          || Int32.TryParse(cus.Element("postalcode").Value, out i)
                                    select cus;
            foreach (var custumer in resultListWithCus)
            {
                Console.WriteLine($"Id = {custumer.Element("id").Value}\t" +
                                  $"region = { (string)custumer.Element("region")}\t" +
                                  $"phone = { (string)custumer.Element("phone")}\t" +
                                  $"postalcode = { (string)custumer.Element("postalcode")}\t");

            }
        }
            
        public void Task7()
        {
            var ruseltWithAveragePrise = 
                from cus in _rootElement.Elements()
                where cus.Element("orders")
                                    .Elements()
                                    .Any()
                from order in cus.Element("orders").Elements()
                group Decimal.Parse(order.Element("total").Value)   
                                        by cus.Element("city").Value into gr
                select new
                {
                    average = gr.Average(),
                    city = gr.Key,
                    number = gr.Count()
                };


            foreach (var el in ruseltWithAveragePrise)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"City: {el.city}");
                Console.WriteLine($"Average {el.average}");
                Console.WriteLine($"THIS end {el.number}");
            }
        }
        
        }
    }

