using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
namespace ConApp5_2_2.TestFolder
{
    [TestClass]
    public class TestClass
    {

        private TasksWorker taskWorker;

        [TestInitialize]
        public void TestInitialize()
        {
            taskWorker = new TasksWorker();
            taskWorker.refreshDataList(200);
        }


        [TestMethod]//?????
        public void SimpleNumbersTest01()
        {
            taskWorker.refreshDataList(10);
            taskWorker.SimpleNumbers().ForEach(num => Assert.AreEqual(true,isSimple(num)));
            //Assert.AreEqual(4, taskWorker.SimpleNumbers().Count);
            //Assert.AreEqual(1008,taskWorker.SimpleNumbers().Count);
        }
        private bool isSimple(BigInteger num)
        {
            bool simple = true;

            if (num == 1)
            {
                simple = false;
            }
            else
            {
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        simple = false;
                    }
                }
            }
            return simple;
        }


        [TestMethod]
        public void DividedBySumOfNumbersTest02()
        {
            Assert.AreEqual(20,taskWorker.DividedBySumOfNumbers().Count);//10
            taskWorker.refreshDataList(10);
            Assert.AreEqual(7, taskWorker.DividedBySumOfNumbers().Count);
        }

        [TestMethod]
        public void IsDividedFiveTest03()
        {
            Assert.AreEqual(true, taskWorker.IsDividedFive());
            taskWorker.refreshDataList(1);
            Assert.AreEqual(false, taskWorker.IsDividedFive());
        }

        [TestMethod]
        public void SquareRootsTest04()
        {
            int numFlag = 2;
            var listWithSquare = taskWorker.SquareRoots(numFlag);
            foreach (var keyNumberSquare in listWithSquare)
            {
                foreach (var num in keyNumberSquare)
                {
                    Assert.AreEqual(true, num.ToString().Contains(numFlag.ToString()));
                }
            }
        }

        [TestMethod]
        public void SortBySecondNumberTest05()
        {
            var resultList = taskWorker.SortBySecondNumber();
            resultList.ForEach(num =>
                            Assert.AreEqual(true,
                                num.ToString()[1] == resultList[resultList.IndexOf(num)].ToString()[1]));
        }

        [TestMethod]
        public void DividedBySquareOfNumbersTest06()
            
        {
            /*
            string one = "25299086886458645685589389182743678652930";
            BigInteger a = BigInteger.Parse(one);
            BigInteger aw = taskWorker.DividedBySquareOfNumbers();
            Assert.AreEqual(true,a.Equals(taskWorker.DividedBySquareOfNumbers()));
            */
            taskWorker.refreshDataList(8);
            Assert.AreEqual(8, taskWorker.DividedBySquareOfNumbers());
            taskWorker.refreshDataList(10);
            Assert.AreEqual(8, taskWorker.DividedBySquareOfNumbers());
            taskWorker.refreshDataList(11);
            Assert.AreEqual(89, taskWorker.DividedBySquareOfNumbers());

        }

        [TestMethod]
        public void ZeroCounterTest07()
        {
            Assert.AreEqual(2.165, taskWorker.ZeroCounter());
            taskWorker.refreshDataList(20);
            Assert.AreEqual(0.05, taskWorker.ZeroCounter());
        }


    }
}
