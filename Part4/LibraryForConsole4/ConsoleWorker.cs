using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForConsole4
{
    public static class ConsoleWorker
    {
        public static int getIntegerValue()
        {
            return getIntegerValue("");
        }

        public static int getIntegerValue(string message)
        {
            //we can use while(true) and break

            int result = 0;
            bool flag = false;

            while (!flag)
            {
                Console.Write(message);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    flag = true;
                }
            }

            return result;
        }

    }
}
