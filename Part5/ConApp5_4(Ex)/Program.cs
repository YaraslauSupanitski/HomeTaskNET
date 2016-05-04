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
            string helloMessage = "Hello. Input 1 If you want to see all buttons on StartPage."+
                "Input 2 to click on all buttons";
            bool flagToExit = false;

            
            //page to work
            StartPage st = new StartPage();
            Console.WriteLine(helloMessage);

            //logic for console
            while (!flagToExit)
            {
                int res = ConsoleWorker.getIntegerValue("Give me your number ");
                switch (res)
                {
                    case 1:
                        st.ShowAllButtonInConsole();
                        break;
                    case 2:
                        try
                        {//catch exeption on main...bad idea
                            st.ClickOnAllButtons();
                        } catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("There aren't the number you're looking for");
                        break;
                }

                //can create new method for this choice
                Console.WriteLine("New choise? (any line(y))/n");
                if (Console.ReadLine().ToUpper().Equals("N"))
                {
                    flagToExit = true;
                }
                
            }
           Console.WriteLine("Good by");
           Console.ReadLine();
        }
    }
}
