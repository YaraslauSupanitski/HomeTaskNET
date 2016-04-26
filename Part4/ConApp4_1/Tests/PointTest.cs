using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ConApp4_1.Tests
{
    [TestClass]
    public class PointTest
    {
        /*
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("ssssss");
            Console.Read();
            Point p1 = new Point();
            p1.X = 1;
            p1.Y = 2;

            Point p2 = new Point(1, 2);
            Point p3 = new Point(3, 2);
        }
        */

        [TestMethod]
        public void TestEquals()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 2);
            Point p3 = new Point(3, 2);
            Assert.AreEqual(p1.Equals(p2), true);
            Assert.AreEqual(p2.Equals(p3), false);
            Assert.AreEqual(p1.Equals(p3), false);

        }

    }

}
//Small task = small test in main

/*
Console.WriteLine($"p1 {p1}\np2 {p2}\np3 {p3}");

Console.WriteLine("p1-p2 " + p1.Equals(p2));
Console.WriteLine("p2-p3 " + p2.Equals(p3));
Console.WriteLine("p1-p3 " + p1.Equals(p3));
Console.Read();
*/
