using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryTask1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            Assert.AreEqual(CalculatorClass.Add(2, 3), 5);
            Assert.AreEqual(CalculatorClass.Add(-6, 6), 0);
            Assert.AreEqual(CalculatorClass.Add(1, 3), 4);
            Assert.AreEqual(CalculatorClass.Add(2, 1000000000), 1000000002);
        }

        [TestMethod]
        public void TestMethodMultiplication()
        {
            Assert.AreEqual(CalculatorClass.Multiplication(8, 8), 8*8);
            Assert.AreEqual(CalculatorClass.Multiplication(210, 210), 210*210);
            Assert.AreEqual(CalculatorClass.Multiplication(0, 3), 0);
            Assert.AreEqual(CalculatorClass.Multiplication(5, 0), 0);
        }

        [TestMethod]
        public void TestMethodSubtraction()
        {
            Assert.AreEqual(CalculatorClass.Subtraction(0, 10), -10);
            Assert.AreEqual(CalculatorClass.Subtraction(8, 8), 0);
            Assert.AreEqual(CalculatorClass.Subtraction(05, 10), -5);
            Assert.AreEqual(CalculatorClass.Subtraction(30, 10), 20);
        }

        [TestMethod]
        public void TestMethodDivision()
        {
            Assert.AreEqual(CalculatorClass.Division(5, 5), 1);
            Assert.AreEqual(CalculatorClass.Division(10, 5), 2);
            Assert.AreEqual(CalculatorClass.Division(0, 5), 0);
            //need write for exeption Method to this
            //Assert.AreEqual(CalculatorClass.Division(5, 0), 0);
           
        }
    }
}
