using LibraryForConsole4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConApp5_3_NewTask_
{
    class Program
    {
        static void Main(string[] args)
        {
            //need add Log For out information.
            //need shange void to list methods
            string path = $"{Environment.CurrentDirectory}\\Data\\Customers.xml";

            LinqWorkerForCustumers linqWorker = new LinqWorkerForCustumers(path);

            int i = 10;
            int CountOfTask = 7;
            while (i != 0)
            {
                i = ConsoleWorker.getIntegerValue("We have 7 tasks. Press number 1-7 for show some task. If you whant see all task press 8. 0 - exit\n");
                if (i == CountOfTask+1)
                {
                    for (int y = 1; y < CountOfTask+1; y++)
                    {
                        Console.WriteLine($"====================== Task {y} ======================");
                        ShowResult.Show(y, path);
                    }
                }
                else
                {
                    ShowResult.Show(i, path);
                }
            }

                        
            Console.Read();
            }
        }
    }


