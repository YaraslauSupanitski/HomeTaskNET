using System;
using System.IO;

namespace ConApp3._1{
    class Program
    {
        static void Main(string[] args)
        {
            string pathName = @"c:\";
            //for creating dir
            DirectoryInfo dir;

            //get dir name on c:\
            Console.WriteLine("Give me name by dir: ");
            pathName += Console.ReadLine().Trim();

            try
            {//create dir
                if (Directory.Exists(pathName))
                {
                    Console.WriteLine("That path exists already.");
                    Directory.Delete(pathName, true);
                }
                dir = Directory.CreateDirectory(pathName);
                //dir ready
                /*
                dir = Directory.CreateDirectory(pathName);
                DirectoryInfo d = new DirectoryInfo(@"c:\");
                
                foreach (var file in d.GetFiles("*.log"))
                {
                    for (int i = 0; i < 20; i++)
                    {
                        string filePath = file.FullName;
                        Console.WriteLine(File.OpenText(filePath));
                        Console.WriteLine(file.OpenText().ReadLine());
                    }
                    break;
                }
                */

                //my file
                string myFilePath = pathName + @"\myFileForAppends.txt";

                var myFile = File.Create(myFilePath);
                myFile.Close();

                //file for read
                int count = 0;
                foreach (string line in File.ReadLines(@"C:\Users\Yaraslau_Supanitski@epam.com\Desktop\Presentations\myTxtFile.txt"))
                {
                    
                    string mes = line + "\t"; //"n"
                    File.AppendAllText(myFilePath,mes);
                    if (count++ == 19)
                    {
                        break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            Console.Read();

        }
    }
}
