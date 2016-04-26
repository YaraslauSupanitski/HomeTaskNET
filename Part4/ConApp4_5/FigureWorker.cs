using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4_5
{
    class FigureWorker
    {
        public int FindAllRectangle(double figureWidth,double figureLingth, double rectangleWidth, double rectangleLenght)
        {

            int result = 0;

            int row1 = (int) (figureWidth / rectangleWidth);
            int col1 = (int) (figureLingth / rectangleLenght);
            //swap
            int row2 = (int)(figureWidth / rectangleLenght);
            int col2 = (int)(figureLingth / rectangleWidth);

            result = Math.Max(row1 * col1, row2 * col2);

            return result;
            
        }
    }//4x4 vs 1x3
}
