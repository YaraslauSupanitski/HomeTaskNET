using System;
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
            DriverFactoryByCommand fc = new DriverFactoryByCommand();

            string b = ConfigurationManager.AppSettings["FireFox"];
            string a = ConfigurationManager.AppSettings["Chrome"];
            fc.getDriver(a);
        }
    }
}
