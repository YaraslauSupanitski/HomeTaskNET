using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
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
                SetWebDriver(new FirefoxDriver());
            return _webDriver;
        }

        public static void SetWebDriver(IWebDriver wb)
        {
            _webDriver = wb;
        }
    }
}

