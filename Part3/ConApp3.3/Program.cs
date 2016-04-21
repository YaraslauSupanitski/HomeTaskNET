using Library3._3Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(Solver.QuadraticEquation(1, 6, 9));
            Console.WriteLine(Solver.QuadraticEquation(2, 4, -7));
            Console.WriteLine(Solver.QuadraticEquation(2, 4, 7));
            */

            /*
            double[,] a = { { 1, 4 }, { 2, 5 }, { 3, 6 } }; ;
            double[,] b = { { 7, 8, 9 }, { 10, 11, 12 } };
            double[,] c = Solver.Matrix(a,b);

            for (int i = 0; i < c.GetLength(0) ; i++) {
                for (int y = 0; y < c.GetLength(1); y++)
                {
                    Console.WriteLine(c[i, y] + " ");
                }
            }
            */
            /*
            Console.WriteLine(Solver.LinearEquation(10, 5));
            */
            Console.Read();
        }

        public void ManagerSelection(int select)
        {
            switch (select)
            {
                case 1:break;
                case 2:break;
                case 3:break;
            }
        }
    }
}
