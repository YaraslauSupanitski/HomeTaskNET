﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dr = SingletonWebDr.getWebDriver();
            dr.Close();
        }
    }
}
