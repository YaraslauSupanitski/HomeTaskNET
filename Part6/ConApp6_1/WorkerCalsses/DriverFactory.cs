using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_1
{
    abstract class DriverFactoryAbstr
    {
        public abstract IWebDriver getDriver(string driverName);
    }
}
