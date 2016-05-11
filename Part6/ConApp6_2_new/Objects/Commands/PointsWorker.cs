using ConApp6_2.Objects.Recirvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2.CommandsClasses
{
    class PointsWorker : MathCommandAbstract
    {
        private PointRecirver recirver;
        public PointsWorker(PointRecirver bs): base(bs)
        {
            recirver = bs;
        }

        public override void Execute()
        {
            
            Console.WriteLine($"Point1({recirver.x1},{recirver.y1}) Point2({recirver.x2},{recirver.y2})");
            Console.WriteLine($"Distanse = {DistanceBetweenPoints()}");
        }

        private double DistanceBetweenPoints()
        {
            return Math.Sqrt(Math.Pow((recirver.x2 - recirver.x1), 2) + Math.Pow((recirver.y2 - recirver.y1), 2));
        }
    }
}
