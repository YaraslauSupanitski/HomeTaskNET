using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4_1
{
    class Point
    {
        
        //private int _x;
        //private int _y;

        public int X { get; set; }
        public int Y { get; set; }



        public Point()
        {
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }




        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())//!= typeof(Point)
            {
                return false;
            }

            Point p = (Point)obj;
            return Equals(p);
        }
        
        //Not override. Like in Java.
        //Can we use this structure in c# or
        //its bad practice(mixing 2 language)?
        public bool Equals(Point p)
        {
            return (X == p.X) && (Y == p.Y);
        }

        public override string ToString()
        {
            string str = String.Empty;
            str = $"x={X} y={Y}";
            return str;
        }
    }

    
}
