using Library3._3Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace ConApp3._3
{
    class Program
    {
        public static string nameByOperation = String.Empty;
        public static string paramStr = String.Empty;
        public static string resultAfterMathOperation = String.Empty;

        static void Main(string[] args)
        {
            string mesSelect = "What do u whant to do?:\n" +
                "press 1 for Quadratic Equation\n" +
                "press 2 for Linear Equation\n" +
                "press 3 for Matrix work\n";

            string mesParam = "Okay, Good. Now (if need, else press enter) input parameters via space, like this: 1 2 -4: ";

            
            //try/catch = bad style, but more eyse for this task
            while (true) {
                try
                {
                    Console.Write(mesSelect);
                    string select = Console.ReadLine();
                    Console.Write(mesParam);
                    Program.paramStr = Console.ReadLine();
                    string[] param = paramStr.Split(' ');

                    if (ManagerSelection(Int32.Parse(select), param))
                    {
                        break;
                    }
                } catch (Exception e)
                {

                }
            }
            Console.ReadLine();



            ///*
            //Console.WriteLine(Solver.QuadraticEquation(1, 6, 9));
            //Console.WriteLine(Solver.QuadraticEquation(2, 4, -7));
            //Console.WriteLine(Solver.QuadraticEquation(2, 4, 7));
            //*/

            //string matrixStr1 = File.ReadAllText(ConfigurationManager.AppSettings["matrix1Path"]);
            //string matrixStr2 = File.ReadAllText(ConfigurationManager.AppSettings["matrix2Path"]);

            //double[,] mtrx1 = GenerateMatrix(matrixStr1.Split('\n'));
            //double[,] mtrx2 = GenerateMatrix(matrixStr2.Split('\n'));

            //double[,] c = Solver.Matrix(mtrx1, mtrx2);


            ////show new matrix
            //for (int i = 0; i < c.GetLength(0) ; i++) {
            //    for (int y = 0; y < c.GetLength(1); y++)
            //    {
            //        Console.Write(String.Format("{0:0.00}", c[i, y]));
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();

            //}


            ///*
            //Console.WriteLine(Solver.LinearEquation(10, 5));
            //*/
            //Console.Read();

        }

        public static double[,] GenerateMatrix(string[] row)
        {
            double[,] rusult = new double[row.Length, row[0].Split(' ').Length];

            for (int i = 0; i < row.Length; i++)
            {
                string[] colm = row[i].Split(' ');
                {
                    //foreach (string num in colm)
                    for (int j = 0; j < colm.Length; j++)
                    {
                        rusult[i, j] = Double.Parse(colm[j]);
                    }
                }

            }
            return rusult;
        }


        public static bool ManagerSelection(int select, string[] param)
        {
            //need method or class for inspection parameters in Salary
            //but for euse way we do inspection this
            //cause = bad architecture
            double[] convertArray;

            string result = String.Empty;
            bool success = false;
            switch (select)
            {
                case 1:
                    Program.nameByOperation = "QuadraticEquation";
                    convertArray = Array.ConvertAll(param, Double.Parse);
                    result = Solver.QuadraticEquation(convertArray[0], convertArray[1], convertArray[2]);
                    success = true;
                    break;

                case 2:
                    Program.nameByOperation = "LinearEquation";
                    convertArray = Array.ConvertAll(param, Double.Parse);
                    Console.WriteLine(Solver.LinearEquation(convertArray[0], convertArray[1]));
                    success = true;
                    break;

                case 3:
                    Program.nameByOperation = "Matrix";
                    //for this we can create new method with all steps for matrix
                    string matrixStr1 = File.ReadAllText(ConfigurationManager.AppSettings["matrix1Path"]);
                    string matrixStr2 = File.ReadAllText(ConfigurationManager.AppSettings["matrix2Path"]);

                    double[,] mtrx1 = GenerateMatrix(matrixStr1.Split('\n'));
                    double[,] mtrx2 = GenerateMatrix(matrixStr2.Split('\n'));

                    double[,] c = Solver.Matrix(mtrx1, mtrx2);

                    //show new matrix
                    string mtrxStr = String.Empty;
                    for (int i = 0; i < c.GetLength(0); i++)
                    {
                        for (int y = 0; y < c.GetLength(1); y++)
                        {
                            mtrxStr += String.Format("{0:0.00}", c[i, y]);
                            mtrxStr += " ";
                        }
                        mtrxStr += "\n";
                    }
                    success = true;
                    result = mtrxStr;
                    break;
            }

            if (success)
            {
                Program.resultAfterMathOperation = result;
            }
            string pp = @"C:\Users\Yaraslau_Supanitski@epam.com\Desktop\Presentations\w.txt";
            Log.LoginInfo(pp,"_____");
            return success;
        }
    }
    }

