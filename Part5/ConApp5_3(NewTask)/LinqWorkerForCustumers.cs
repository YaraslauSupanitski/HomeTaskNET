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


        public IEnumerable<XElement> Task1(out decimal maxResult)
        {
            Random rnd = new Random();
            var maxOrder = _rootElement.Elements("customer")
                    .Max(cust => cust.Element("orders").Elements("order").Count());

            maxResult = rnd.Next(0, maxOrder);
            decimal maxResultForLinq = maxResult;

            return Task1(maxResultForLinq);
        }

        public IEnumerable<XElement> Task1(decimal maxResultForLinq)
        {
            var listResult = _rootElement.Elements("customer").
                Where(cus => cus.Element("orders").Elements("order").
                Sum(ord => Decimal.Parse(ord.Element("total").Value)) > maxResultForLinq).
                Select(cus => cus).ToList();

            return listResult;
        }



        public IEnumerable<IGrouping<string,XElement>> Task2()
        {
            var custByCountry = from customer in _rootElement.Elements("customer")
                    group customer by customer.Element("country").Value;

            return custByCountry;
        }
        
        public IEnumerable<XElement> Task3(decimal price)
        {
            var custListWithPriceHighPrice = (from customer in _rootElement.Elements("customer")
                    from order in customer.Element("orders").Elements()
                    where Decimal.Parse(order.Element("total").Value) >= price
                    select customer);
            return custListWithPriceHighPrice;
        }
        
        public IEnumerable<IGrouping<XElement, DateTime>> Task4()
        {
            var customerList = (from customer in _rootElement.Elements()
                                from order in customer.Element("orders").Elements()
                                group DateTime.Parse(order.Element("orderdate").Value) by customer
                            );
            return customerList;
        }
        
        public IEnumerable<dynamic> Task5()
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
            return customerList;
        }       
        
        public IEnumerable<XElement> Task6()
        {
            int i;
            var resultListWithCus = from cus in _rootElement.Elements()
                                    where String.IsNullOrEmpty((string)cus.Element("region"))
                                          || !cus.Element("phone").Value.Contains('(')
                                          || Int32.TryParse(cus.Element("postalcode").Value, out i)
                                    select cus;

            return resultListWithCus;
        }
            
        public IEnumerable<dynamic> Task7()
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
                Console.WriteLine($"Average: {el.average}");
                Console.WriteLine($"Count: {el.number}");
            }
            return ruseltWithAveragePrise;
        }
        
        }
    }

