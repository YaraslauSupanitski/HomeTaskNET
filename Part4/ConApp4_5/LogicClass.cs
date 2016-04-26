using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForConsole4;

namespace ConApp4_5
{
    class LogicClass
    {
        public LogicClass()
        {

        }

        public void DoTaskWithRectangles()
        {
            int figureWidth;
            int figureLength;
            int rectanglWidth;
            int rectangLength;

            string mainMessage = "Give me ";
            string figureWidthMessage = mainMessage + "figure width: ";
            string figureLengthMessage = mainMessage + "figure length: ";
            string rectanglWidthMessage = mainMessage + "rectang width: ";
            string rectangLengthMessage = mainMessage + "rectang length: ";


            figureWidth = ConsoleWorker.getIntegerValue(figureWidthMessage);
            figureLength = ConsoleWorker.getIntegerValue(figureLengthMessage);
            rectanglWidth = ConsoleWorker.getIntegerValue(rectanglWidthMessage);
            rectangLength = ConsoleWorker.getIntegerValue(rectangLengthMessage);
            

            FigureWorker a = new FigureWorker();
            int rectang = a.FindAllRectangle(figureWidth, figureLength, rectanglWidth, rectangLength);
            Console.WriteLine(helpOutPutInfo(rectang.ToString()));
            Console.Read();
        }

        private string helpOutPutInfo(string result)
        {
            return $"In maint figure we have {result} rectang(s)";
        }
    }
}

