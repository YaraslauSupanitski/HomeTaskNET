using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2.CommandsClasses
{
    class PointsWorker : MathCommandAbstract
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public PointsWorker(){}
        public void SetParam(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public PointsWorker(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Execute()
        {
            Console.WriteLine($"Point1({x1},{y1}) Point2({x2},{y2})");
            Console.WriteLine($"Distanse = {DistanceBetweenPoints(x1, y1, x2, y2)}");
        }

        public override void SetParams(params int[] list)
        {
            SetParam(list[0],list[1],list[2],list[3]);
        }

        private double DistanceBetweenPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}
