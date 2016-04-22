using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConApp4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ClassWhichWatchesItself b = new ClassWhichWatchesItself();

            for (int i = 0; i<10; i++)
            {
                ClassWhichWatchesItself a = new ClassWhichWatchesItself();
                
            }
            Console.WriteLine(b.QuontityPublic);
            Console.Read();
        }
    }
}
