using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroductionSamples.MyWorkSpace;
using IntroductionSamples;

namespace ConApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlSerializerSamples o = new XmlSerializerSamples();
            //o.Deserialize();
            XMLForBook a = new XMLForBook();
            //a.Deserialize();
            //a.DesToList();
            a.Serial();
        }
    }
}
