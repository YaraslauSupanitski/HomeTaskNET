using ConApp5_4_Ex_.Classes;
using ConApp5_4_Ex_.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5_4_Ex_.Test
{
    [TestClass]
    public class TestClassForButton
    {
        [TestMethod]
        public void ClicTestPos()
        {
            Button bt = new Button();
            bt.Name = "ButForTest";
            bt.status = true;

            
            Assert.AreEqual(bt.Click(), "ButForTest");
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void ClicTestNeg()
        {
            Button bt = new Button();
            bt.Name = "ButForTest";
            bt.status = false;

            bt.Click();
        }

    }
}
