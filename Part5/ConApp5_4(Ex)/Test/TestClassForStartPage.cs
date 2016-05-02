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
    public class TestClassForStartPage
    {
        [TestMethod]
        public void ClistElementsPos()
        {
            Button bt1 = new Button("B1", true);
            Button bt2 = new Button("B2", true);
            Button bt3 = new Button("B3", true);

            List<Button> listButtonCorrect = new List<Button>();
            listButtonCorrect.Add(bt1);
            listButtonCorrect.Add(bt2);
            listButtonCorrect.Add(bt3);

            List<Button> listButtonForClick = new List<Button>();
            listButtonForClick.Add(bt1);
            listButtonForClick.Add(bt2);
            listButtonForClick.Add(bt3);

            StartPage st = new StartPage(listButtonCorrect, listButtonForClick);
            Assert.AreEqual(true,st.ClickOnAllButtons());
        }

        [TestMethod]
        public void ClistElementsNeg()
        {
            string pathPageData = $"{Environment.CurrentDirectory}\\..\\..\\Test\\DataForTest\\PageData.xml";
            string pathButtonsState = $"{Environment.CurrentDirectory}\\..\\..\\Test\\DataForTest\\ButtonsState.xml";
            StartPage st = new StartPage(pathPageData, pathButtonsState);
            Assert.AreEqual(false,st.ClickOnAllButtons());
        }

    }
}
