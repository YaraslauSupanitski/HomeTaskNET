using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_1
{
    class DriverFactory
    {

        public static IWebDriver getDriver(string driverName)
        {
            IWebDriver dr=null;

            switch (driverName)
            {
                case "Chrome": dr = initChromeDriver(); break;
                case "Firefox": dr =  initFirefoxDriver(); break;
            }

            return dr;
        }

        private static IWebDriver initChromeDriver()
        {
            return new ChromeDriver();
        }

        private static IWebDriver initFirefoxDriver()
        {
            return new FirefoxDriver();
        }
    }
}
