using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_1
{
    class SingletonWebDr
    {
        private static IWebDriver _webDriver;

        private SingletonWebDr()
        { }

        public static IWebDriver getWebDriver()
        {
            if (_webDriver == null)
                _webDriver = DriverFactory.getDriver(ConfigurationManager.AppSettings["browser"]);
            return _webDriver;
        }

    }
}

