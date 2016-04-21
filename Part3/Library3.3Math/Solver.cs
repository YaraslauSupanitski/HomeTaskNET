using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3._3Math
{
    public class Solver
    {
        public static string QuadraticEquation(double a,double b,double c)
        {
            double? root1;
            double? root2;
            double discriminant;
            string res = String.Empty;

            discriminant = Math.Pow(b,2) - (4 * a * c);

            if (discriminant > 0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2*a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            } else if (discriminant==0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = root1;
            } else
            {
                root1 = root2 = null;
            }


            if (root1 == null)
            {
                res = "Havemt roots";
            }
            else
            {
                res = root1.ToString() + " " + root2.ToString();
            }

            return res;
            }

        public static double[,] Matrix(double[,] matrix1, double[,] matrix2)
        {
            double[,] resultMatrix = null;
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                resultMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

                for (int row = 0; row< matrix1.GetLength(0); row++)
                {
                    for(int col = 0; col< matrix2.GetLength(1);col++)
                    {
                        for (int inner = 0; inner < matrix1.GetLength(1); inner++) {
                            resultMatrix[row,col] += matrix1[row,inner] *
                                matrix2[inner,col];
                                }
                    }
                }
            }
            return resultMatrix;
        }

        public static string LinearEquation(double a, double b)
        {
            string res = String.Empty;
            if (a == 0 && b == 0)
            {
                res = "a=0 and b=0. Wikipedia say that \"Every number is a solution of the equation\"";
            }else if (a ==0 && b !=0)
            {
                res = "a=0 and b!=0. Wikipedia say that \"there are no solutions (and the equation is said to be inconsistent.\"";
            }
            else if (a != 0)
            {
                res = (b / a).ToString();
            }
            return res;
        }
    }
}


