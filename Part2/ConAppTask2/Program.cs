using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = String.Empty;
            text = GetText().ToLower();

            DateTime localDate = DateTime.Now;
            /*
            string logTime = localDate.ToString("yyyy-MM-dd h:ss:fff");
            */
            string pattern = "[.,!?:…]";//[:punct:]
            Regex rgx = new Regex(pattern);
            /*
            string splitString = String.Format("\n{0} ", logTime);

            string splitString = String.Format("\n{0} ", localDate.ToString("yyyy-MM-dd h:ss:fff"));
            string result = rgx.Replace(text, splitString)
             */

            string result = rgx.Replace(text, String.Format("\n{0} ", localDate.ToString("yyyy-MM-dd h:ss:fff")));
            Console.Write(localDate.ToString("yyyy-MM-dd h:ss:fff") + result);
            Console.Read();


        }
        public static string GetText()
        {
            string result = String.Empty;
            int mes = 0;
            string textForMes = "What do u want? input 1 if u use text\n" +
                "unput 2 if u want use txt.file";

            Console.WriteLine(textForMes);
            Int32.TryParse(Console.ReadLine(),out mes);

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Ok. Give me ur text:");
                    result = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Ok. Give me path to file,");
                    Console.WriteLine("but remember: if path not valid, i close program");
                    try
                    {
                        result = File.ReadAllText(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Read();
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("Bad command. Good by");
                    Console.Read();
                    Environment.Exit(0);
                    break;
            }

            return result;
        }

    }
}
