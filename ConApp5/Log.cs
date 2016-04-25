using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ConApp5
{
    class Log
    {
        public static void LoginInfo(string filePath, string mes)
        {

            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(mes);
            }

//            File.AppendAllText(filePath, mes);

        }
    }
}