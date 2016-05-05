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
    class DriverFactoryByCommand : DriverFactoryAbstr
    {

        public override IWebDriver getDriver(string driverName)
        {
            IWebDriver dr=null;

            switch (driverName)
            {
                case "Chrome": dr = ChromeFactory(); break;
                case "FireFox": dr =  FireFoxFactory(); break;
            }

            return dr;
        }

        private IWebDriver ChromeFactory()
        {
            SingletonWebDr.SetWebDriver(new ChromeDriver());
            return SingletonWebDr.getWebDriver();
        }

        private IWebDriver FireFoxFactory()
        {
            SingletonWebDr.SetWebDriver(new FirefoxDriver());
            return SingletonWebDr.getWebDriver();
        }
    }
}
