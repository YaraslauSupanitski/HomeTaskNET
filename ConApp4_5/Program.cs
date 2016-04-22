using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes = "Hello. Now we find out how many rectangles can we put in your figure. String generate parameters";

            Console.WriteLine(mes);
            LogicClass logicClass = new LogicClass();
            logicClass.DoTaskWithRectangles();
        }
    }
}
