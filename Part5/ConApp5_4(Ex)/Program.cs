using ConApp5_4_Ex_.Classes;
using ConApp5_4_Ex_.Pages;
using LibraryForConsole4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5_4_Ex_
{
    class Program
    {
        static void Main(string[] args)
        {

            //message to console
            string helloMessage = "Hello. Input 1 If you want to see all buttons on StartPage.\nInput 2 to click on all buttons";
            bool flagToExit = false;

            
            //page to work
            StartPage st = new StartPage();
            Console.WriteLine(helloMessage);

            //logic for console
            while (!flagToExit)
            {
                int inputtedNumber = ConsoleWorker.getIntegerValue("Input your number ");
                switch (inputtedNumber)
                {
                    case 1:
                        st.ShowAllButtonInConsole();
                        break;
                    case 2:
                        try
                        {
                            string resOfClick;
                            st.ClickAllButtons( out resOfClick);
                            Console.WriteLine(resOfClick);
                        } catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("You must input 1 or 2");
                        break;
                }

                //can create new method for this choice
                Console.WriteLine("Input n, if you whant exit.\nInput other symbol for return to programm ? (any line(y))/n");
                if (Console.ReadLine().ToUpper().Equals("N"))
                {
                    flagToExit = true;
                }
                
            }
           Console.WriteLine("Good by");
           Console.ReadLine();
        }

        1
    }
}
