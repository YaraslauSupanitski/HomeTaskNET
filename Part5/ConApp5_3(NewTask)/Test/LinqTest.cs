using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5_3_NewTask_.Test
{
    [TestClass]
    public class LinqTest
    {
        private LinqWorkerForCustumers linqWorker;

        [TestInitialize]
        public void InicialTest()
        {
            string path = $"{Environment.CurrentDirectory}\\Data\\Customers.xml";
            linqWorker = new LinqWorkerForCustumers(path);
        }

        [TestMethod]
        public void TestTask1()
        {
            decimal price = 10000;
            var list = linqWorker.Task1(price).ToList();
            var listForTest_ID = list.Select(cus => cus.Element("id").Value).ToList();
            CollectionAssert.Contains(listForTest_ID, "BERGS");
            CollectionAssert.DoesNotContain(listForTest_ID, "ANATR");
        }

        [TestMethod]
        public void TestTask2()
        {
            var list = linqWorker.Task2();
            var GermanyList = list.First(country => country.Key == "Germany").Select(count => count);
            var personInGerman = GermanyList.Select(person => person.Element("id").Value).ToList();
            CollectionAssert.Contains(personInGerman, "DRACD");
            CollectionAssert.Contains(personInGerman, "BLAUS");
            CollectionAssert.DoesNotContain(personInGerman, "ANATR");

        }
    }
    /*
    [TestMethod]
    public void TestTask3()
    {
        linqWorker.Task1();
    }

    [TestMethod]
    public void TestTask4()
    {
        linqWorker.Task1();
    }

    [TestMethod]
    public void TestTask5()
    {
        linqWorker.Task1();
    }

    [TestMethod]
    public void TestTask6()
    {
        linqWorker.Task1();
    }

    [TestMethod]
    public void TestTask7()
    {
        linqWorker.Task1();
    }

    }
    */
}
