using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_1.Tests
{
    [TestClass]
    public class TestForDriver
    {
        [TestMethod]
        public void DriverTest()
        {
            string BrowNameForTest = "FireFox";
            string driverName = ConfigurationManager.AppSettings["FireFox"];

            DriverFactoryAbstr fc = new DriverFactoryByCommand();
            fc.getDriver(driverName);

            ICapabilities capabilities = ((RemoteWebDriver)SingletonWebDr.getWebDriver()).Capabilities;
            Assert.AreEqual(BrowNameForTest.ToLower(), capabilities.BrowserName);
            SingletonWebDr.getWebDriver().Quit();
        }
    }
}
