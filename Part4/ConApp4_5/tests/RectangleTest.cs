using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConApp4_5.tests
{
    [TestClass]
    class RectangleTest
    {
        [TestMethod]
        public void RectTest()
        {
            FigureWorker a = new FigureWorker();
            int rectang = a.FindAllRectangle(8, 9, 2, 2);
            Assert.AreEqual(rectang,16);
        }

    }
}
