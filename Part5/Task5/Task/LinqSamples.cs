// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
//
//Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using SampleSupport;
using Task.Data;
using System.Text.RegularExpressions;

// Version Mad01

namespace SampleQueries
{
    [Title("LINQ Module")]
    [Prefix("Linq")]
    public class LinqSamples : SampleHarness
    {

        private DataSource dataSource = new DataSource();

        [Category("Restriction Operators")]
        [Title("Where - Task 1")]
        [Description("This sample uses the where clause to find all elements of an array with a value less than 5.")]
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums =
                from num in numbers
                where num < 5
                select num;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

        [Category("Restriction Operators")]
        [Title("Where - Task 2")]
        [Description("This sample return return all presented in market products")]

        public void Linq2()
        {
            var products =
                from p in dataSource.Products
                where p.UnitsInStock > 0
                select p;

            foreach (var p in products)
            {
                ObjectDumper.Write(p);
            }
        }


        //Start to my tast


        [Category(" ")]
        [Title("Where - Task 001")]
        [Description("")]
        public void Linq001()
        {
            Random rnd = new Random();
            var maxOrder = dataSource.Customers.Max(n => n.Orders.Length);
            decimal x = rnd.Next(10000,100000);

            Console.WriteLine($"Max Sum {x}");
            var a = dataSource.Customers.
                Where(cus => cus.Orders.
                Sum(ord => ord.Total) > x).
                Select(cus => cus);

            a.ToList().ForEach(cus => Console.WriteLine($"{cus.CustomerID} {cus.Orders.Sum(ord => ord.Total)}"));


        /*
        dataSource.Customers.Where(n => n.Orders.Length > i).ToList()
            .ForEach(n=> Console.WriteLine($"Id:{n.CustomerID}  OrdersLenght:{n.Orders.Length}"));
           */
    
}


        [Category(" ")]
        [Title("Where - Task 002")]
        [Description("")]
        public void Linq002()
        {

            var a = (from customer in dataSource.Customers
                     from supplier in dataSource.Suppliers
                     where supplier.City.Equals(customer.City) && supplier.Country.Equals(customer.Country)
                     group supplier.SupplierName by customer.CustomerID);

            foreach (var q in a)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine(q.Key + ":");
                ObjectDumper.Write(q);
            }
        }

        [Category(" ")]
        [Title("Where - Task 003")]
        [Description("")]
        public void Linq003()
        {
            decimal price = 10000;

            /*
            dataSource.Customers.ForEach(cust => cust.Orders.ToList()
                    .Select(order => order.Total >= price));
                    */

            var products = (from customer in dataSource.Customers
                            from order in customer.Orders
                            where order.Total >= price
                            select customer
                     );

            HashSet<Customer> productsSet = new HashSet<Customer>(from x in products select x);

            foreach (var p in productsSet)
            {
                ObjectDumper.Write(p.CustomerID);
            }

        }

        [Category(" ")]
        [Title("Where - Task 004")]
        [Description("")]
        public void Linq004()
        {
            var customerList = (from customer in dataSource.Customers
                                from order in customer.Orders
                                group order.OrderDate by customer
                            );

            foreach (var customer in customerList)
            {
                Console.Write($"{customer.Key.CustomerID}:\t");
                ObjectDumper.Write(customer.First());
            }

        }

        [Category(" ")]
        [Title("Where - Task 005")]
        [Description("")]
        public void Linq005()
        {
            var customerList = (from customer in dataSource.Customers
                                from order in customer.Orders
                                orderby order.OrderDate, customer.CustomerID
                                group order.OrderDate by customer
                            );

            {
                foreach (var customer in customerList)
                {
                    Console.Write($"{customer.Key.CustomerID}:\t");
                    ObjectDumper.Write(customer.First());
                }
            }

        }

        [Category(" ")]
        [Title("Where - Task 006")]
        [Description("")]
        public void Linq006()
        {
            string text1 = "5qw4e564qwe5";
            string text2 = "5qw4e564qwe5";
            Regex.IsMatch(text1,"");

            int i;
            var c = from cus in dataSource.Customers
                    where String.IsNullOrEmpty(cus.Region) || !cus.Phone.Contains('(') ||  Int32.TryParse(cus.PostalCode,out i)
                    select cus;
            foreach (var cas in c) {
                ObjectDumper.Write(cas.Region+"          " + cas.Phone+ "     " + cas.PostalCode);
                    }
        }

        [Category(" ")]
        [Title("Where - Task 007")]
        [Description("")]
        public void Linq007()
        {

            var c = from prod in dataSource.Products
                    group prod by prod.Category into categ
                    from prodInStockGroup in
                        (from prod in categ
                         orderby prod.UnitPrice
                         group prod by prod.UnitsInStock>0)
                         group prodInStockGroup by categ.Key;


            foreach (var categ in c)
            {
                Console.WriteLine($"Category: {categ.Key}");
                foreach (var innerGroup in categ)
                {
                    Console.WriteLine($"\tUnits in stock {innerGroup.Key}:\t");
                    foreach (var innerProd in innerGroup)
                    {
                        ObjectDumper.Write($"\t\tID={innerProd.ProductID}\tPrice={innerProd.UnitPrice}\tStock={innerProd.UnitsInStock}");
                    }
                }
                
            }
         }
        
  
        [Category(" ")]
        [Title("Where - Task 008")]
        [Description("")]
        public void Linq008()
        {
            var c = from prod in dataSource.Products
                    where prod.UnitPrice <= 100
                    group prod.UnitPrice by prod.ProductID
                    
                    ;
            }

        [Category(" ")]
        [Title("Where - Task 009")]
        [Description("")]
        public void Linq009()
        {

        }

        [Category(" ")]
        [Title("Where - Task 010")]
        [Description("")]
        public void Linq010()
        {

        }
    }
}
