using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConApp3._3
{
    class Log
    {
        public static void LoginInfo(string filePath, string mes)
        {
            string date = DateTime.Now.ToString();
            string name = Program.nameByOperation;
            string param = Program.paramStr;
            string result = Program.resultAfterMathOperation;


            string path = filePath;
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                                    sw.WriteLine(date);
                    sw.WriteLine(name);
                    sw.WriteLine(param);
            }

        }
    }
}
